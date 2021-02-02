using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using ScintillaNET;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using XrmToolBox.Extensibility.Interfaces;
using System.Xml;
using System.IO;

namespace AshV.WebApiTester.XTB
{
    public partial class WebApiTesterControl : PluginControlBase, IGitHubPlugin, IHelpPlugin
    {
        private Settings mySettings;

        public string RepositoryName => "AshV.WebApiTester.XTB";

        public string UserName => "AshV";

        public string HelpUrl => "https://github.com/AshV/AshV.WebApiTester.XTB/wiki";

        public WebApiTesterControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ApplyTheme(this);
            InitCustomStyle();

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void ExecuteWebApiRequest()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Executing WebAPI Request...",
                Work = (worker, args) =>
                {
                    try
                    {
                        var csc = ConnectionDetail.GetCrmServiceClient();
                        switch (cmbMethod.SelectedItem.ToString())
                        {
                            case "GET":
                                args.Result = RequestHelper(csc, HttpMethod.Get, txtRequestUri.Text);
                                break;
                            case "POST":
                                args.Result = RequestHelper(csc, HttpMethod.Post, txtRequestUri.Text, txtRequestBody.Text);
                                break;
                            case "PATCH":
                                args.Result = RequestHelper(csc, new HttpMethod("PATCH"), txtRequestUri.Text, txtRequestBody.Text);
                                break;
                            case "DELETE":
                                args.Result = RequestHelper(csc, HttpMethod.Delete, txtRequestUri.Text, txtRequestBody.Text);
                                break;
                            default:
                                ShowErrorNotification("Request is not proper!", null);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowErrorNotification(ex.Message + " | " + ex?.InnerException?.Message, null);
                    }
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var cr = args.Result as CustomResponse;
                    var result = cr.Response;
                    if (result != null)
                    {
                        //Set response body tab as active
                        tabReqestResponse.SelectedIndex = 1;
                        tabResponseChild.SelectedIndex = 0;

                        if (!string.IsNullOrEmpty(cr.ResponseBody))
                            txtResponseBody.Text =
                            cr.ResponseBody.StartsWith("{") ?
                            JValue.Parse(cr.ResponseBody).ToString(Newtonsoft.Json.Formatting.Indented)
                            : cr.ResponseBody.StartsWith("<") ?
                            FormatXml(cr.ResponseBody) :
                            cr.ResponseBody;

                        btnSend.BackColor = result.IsSuccessStatusCode ? Color.DarkGreen : Color.Red;
                        var resultBool = result.IsSuccessStatusCode ? "✔️ Success!" : "❌ Failed!";
                        lblMain.ForeColor = result.IsSuccessStatusCode ? Color.DarkGreen : Color.Red;
                        lblMain.Text = $"\n{resultBool}\n🌐 {(int)result.StatusCode} {result.StatusCode}\n\n📚 {cr.Size / 1024} KB\n⌛ {cr.TimeSpent} ms";

                        dgvResponseHeaders.DataSource = cr.Headers;
                        dgvResponseHeaders.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        dgvResponseHeaders.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvResponseHeaders.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
                        dgvResponseHeaders.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        internal CustomResponse RequestHelper(CrmServiceClient csc, HttpMethod method, string queryString, string body = null, Dictionary<string, List<string>> customHeaders = null, string contentType = null)
        {
            if (!csc.IsReady)
            {
                ShowErrorNotification("Service initiation failed! Try in a moment or restart the tool.", null);
                return new CustomResponse();
            }
            var token = csc.CurrentAccessToken;
            var cr = new CustomResponse();
            cr.Headers = new List<KeyValuePair<string, string>>();
            cr.StartedAt = DateTime.Now;

            var client = new HttpClient();
            cr.Endpoint = $"https://{csc.CrmConnectOrgUriActual.Host}/api/data/v{csc.ConnectedOrgVersion}/";
            cr.ApiVersion = csc.ConnectedOrgVersion.ToString();
            var msg = new HttpRequestMessage(method, cr.Endpoint + queryString);
            msg.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token);
            if (!string.IsNullOrEmpty(body))
            {
                msg.Content = new StringContent(
                    body,
                    UnicodeEncoding.UTF8,
                    "application/json");
            }

            var timer = new Stopwatch();
            timer.Start();
            var response = client.SendAsync(msg).Result;
            var responseBody = response.Content.ReadAsStringAsync().Result;
            timer.Stop();
            cr.TimeSpent = timer.ElapsedMilliseconds;
            cr.FinishedAt = DateTime.Now;

            cr.Response = response;
            cr.ResponseBody = responseBody;

            cr.ContentSize = responseBody.LongCount();
            cr.ResponseSize = (long)response.Content.Headers.ContentLength;
            cr.Size = cr.ResponseSize + cr.ContentSize;

            var list = "";
            var header = response.Headers;
            var h = header.GetEnumerator();
            do
            {
                list += h.Current.Key + " : " + JsonConvert.SerializeObject(h.Current.Value) + Environment.NewLine;
                cr.Headers.Add(new KeyValuePair<string, string>(h.Current.Key, JsonConvert.SerializeObject(h.Current.Value)));
            } while (h.MoveNext());
            list += "------------------" + Environment.NewLine;
            var header1 = response.Content.Headers;
            var h1 = header1.GetEnumerator();
            do
            {
                list += h1.Current.Key + " : " + JsonConvert.SerializeObject(h1.Current.Value) + Environment.NewLine;
                cr.Headers.Add(new KeyValuePair<string, string>(h.Current.Key, JsonConvert.SerializeObject(h.Current.Value)));
            } while (h1.MoveNext());
            cr.Headers.RemoveAll((a) => { return string.IsNullOrWhiteSpace(a.Key); });

            return cr;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            timerSendButton.Start();
            btnSend.Enabled = false;
            ExecuteMethod(ExecuteWebApiRequest);
        }

        internal void ApplyTheme(UserControl parent)
        {
            foreach (Control c in parent.Controls)
                UpdateColorControls(c);

            void UpdateColorControls(Control myControl)
            {
                myControl.Font = new System.Drawing.Font("Verdana", 8);

                //if (!(myControl is Button) || !(myControl is ComboBox))
                //    myControl.BackColor = Color.White;

                if (myControl is TextBox)
                {
                    var txtBox = (TextBox)myControl;
                    txtBox.ForeColor = Color.Purple;
                    txtBox.BorderStyle = BorderStyle.FixedSingle;
                }

                foreach (Control subC in myControl.Controls)
                    UpdateColorControls(subC);
            }
        }

        internal void InitCustomStyle()
        {
            timerLogoRemove.Start();

            splitContainer1.SplitterDistance = 80;
            splitContainerRoot.SplitterDistance = 100;

            cmbMethod.SelectedIndex = 0;

            tabReqestResponse.Dock = DockStyle.Fill;
            tabRequestChild.Dock = DockStyle.Fill;
            txtRequestBody.Dock = DockStyle.Fill;
            tabResponseChild.Dock = DockStyle.Fill;
            txtResponseBody.Dock = DockStyle.Fill;

            txtResponseBody.ScrollBars = ScrollBars.Vertical;
            txtRequestUri.ScrollBars = ScrollBars.Vertical;
            txtRequestBody.ScrollBars = ScrollBars.Vertical;
        }

        /// <summary>
        /// Formats the provided XML so it's indented and humanly-readable.
        /// </summary>
        /// <param name="inputXml">The input XML to format.</param>
        /// <returns></returns>
        public static string FormatXml(string inputXml)
        {
            XmlDocument document = new XmlDocument();
            document.Load(new StringReader(inputXml));

            StringBuilder builder = new StringBuilder();
            using (XmlTextWriter writer = new XmlTextWriter(new StringWriter(builder)))
            {
                writer.Formatting = System.Xml.Formatting.Indented;
                document.Save(writer);
            }

            return builder.ToString();
        }

        private void timerSendButton_Tick(object sender, EventArgs e)
        {
            btnSend.Enabled = true;
            timerSendButton.Stop();
        }

        private void timerLogoRemove_Tick(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Remove(pictureBoxLogo);
        }
    }
}