using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AshV.WebApiTester.XTB
{
    public partial class AddRequest : Form
    {
        public Settings Settings { get; }
        public string SettingName { get; private set; }
        public string Description { get; private set; } = string.Empty;

        public AddRequest(Settings settings)
        {
            InitializeComponent();
            Settings = settings;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSaveName.Text))
            {
                SettingName = cboExisting.Text;
                Description = txtDescription.Text;
            }
            else
            {
                if (Settings.Requests.Any(rw => rw.Name.ToLower() == txtSaveName.Text.ToLower()))
                {
                    MessageBox.Show("Please use a unique name for your request");
                    DialogResult = DialogResult.None;
                    return;
                }
                SettingName = txtSaveName.Text;
                Description = txtDescription.Text;
            }
        }


        private void cboExisting_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSaveName.Text = string.Empty;
            txtDescription.Text = ((Request)cboExisting.SelectedItem).Description;
        }

        private void AddRequest_Load(object sender, EventArgs e)
        {
            cboExisting.Items.AddRange(Settings.Requests.ToArray());

        }
    }
}
