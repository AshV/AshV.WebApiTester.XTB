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
            cmbMethod.SelectedIndex = 0;
            txtRequestUri.ScrollBars = ScrollBars.Vertical;
            tabReqestResponse.Dock = DockStyle.Fill;
            tabRequestChild.Dock = DockStyle.Fill;
            txtRequestBody.Dock = DockStyle.Fill;
            txtRequestBody.ScrollBars = ScrollBars.Vertical;
            tabResponseChild.Dock = DockStyle.Fill;
            txtResponseBody.Dock = DockStyle.Fill;
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
                    var customResponse = args.Result as CustomResponse;
                    var result = customResponse.Response;
                    if (result != null)
                    {
                        tabReqestResponse.SelectedIndex = 1;
                        tabResponseChild.SelectedIndex = 0;
                        //    lblResponseStatus.Text += result.StatusCode.ToString();

                        var responseBody = "";
                        if (result.IsSuccessStatusCode)
                        {
                            var timer = new Stopwatch();
                            timer.Start();
                            responseBody = result.Content.ReadAsStringAsync().Result;
                            timer.Stop();
                        }
                        else
                        {
                            ShowErrorNotification("Bawal!", null);
                        }

                        MessageBox.Show("Time Spent" + customResponse.TimeSpent);
                        txtResponseBody.Text = JValue.Parse(responseBody).ToString(Formatting.Indented);
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
            var customResponse = new CustomResponse();
            var client = new HttpClient();
            var msg = new HttpRequestMessage(method, "https://" + csc.CrmConnectOrgUriActual.Host + "/api/data/v" + csc.ConnectedOrgVersion.ToString() + "/" + queryString);
            MessageBox.Show(msg.RequestUri.ToString());
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
            timer.Stop();
            customResponse.Response = response;
            customResponse.TimeSpentHead = timer.Elapsed.TotalSeconds;
            MessageBox.Show(response.IsSuccessStatusCode.ToString());
            timer.Start();
            var responseBody = response.Content.ReadAsStringAsync().Result;
            timer.Stop();
            customResponse.TimeSpentBody = timer.Elapsed.TotalSeconds;
            customResponse.TimeSpent = customResponse.TimeSpentHead + customResponse.TimeSpentBody;
            customResponse.ResponseBody = responseBody;

            return customResponse;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ExecuteMethod(ExecuteWebApiRequest);
        }
    }
}