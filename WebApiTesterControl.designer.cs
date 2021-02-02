
namespace AshV.WebApiTester.XTB
{
    partial class WebApiTesterControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebApiTesterControl));
            this.splitContainerRoot = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblMain = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtRequestUri = new System.Windows.Forms.TextBox();
            this.tabReqestResponse = new System.Windows.Forms.TabControl();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.tabRequestChild = new System.Windows.Forms.TabControl();
            this.tabPageRequestBody = new System.Windows.Forms.TabPage();
            this.txtRequestBody = new System.Windows.Forms.TextBox();
            this.tabPageRequestHeaders = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageResponse = new System.Windows.Forms.TabPage();
            this.tabResponseChild = new System.Windows.Forms.TabControl();
            this.tabPageResponseBody = new System.Windows.Forms.TabPage();
            this.txtResponseBody = new System.Windows.Forms.TextBox();
            this.tabPageResponseHeaders = new System.Windows.Forms.TabPage();
            this.timerSendButton = new System.Windows.Forms.Timer(this.components);
            this.timerLogoRemove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRoot)).BeginInit();
            this.splitContainerRoot.Panel1.SuspendLayout();
            this.splitContainerRoot.Panel2.SuspendLayout();
            this.splitContainerRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabReqestResponse.SuspendLayout();
            this.tabPageRequest.SuspendLayout();
            this.tabRequestChild.SuspendLayout();
            this.tabPageRequestBody.SuspendLayout();
            this.tabPageRequestHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageResponse.SuspendLayout();
            this.tabResponseChild.SuspendLayout();
            this.tabPageResponseBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerRoot
            // 
            this.splitContainerRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRoot.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRoot.Name = "splitContainerRoot";
            this.splitContainerRoot.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRoot.Panel1
            // 
            this.splitContainerRoot.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerRoot.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainerRoot.Panel2
            // 
            this.splitContainerRoot.Panel2.Controls.Add(this.tabReqestResponse);
            this.splitContainerRoot.Size = new System.Drawing.Size(907, 697);
            this.splitContainerRoot.SplitterDistance = 234;
            this.splitContainerRoot.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblMain);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxLogo);
            this.splitContainer1.Panel1.Controls.Add(this.cmbMethod);
            this.splitContainer1.Panel1.Controls.Add(this.btnSend);
            this.splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtRequestUri);
            this.splitContainer1.Size = new System.Drawing.Size(907, 234);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Location = new System.Drawing.Point(0, 24);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(0, 17);
            this.lblMain.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(262, 168);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // cmbMethod
            // 
            this.cmbMethod.BackColor = System.Drawing.Color.Purple;
            this.cmbMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMethod.ForeColor = System.Drawing.Color.White;
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PATCH",
            "DELETE"});
            this.cmbMethod.Location = new System.Drawing.Point(0, 0);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(262, 24);
            this.cmbMethod.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.BackColor = System.Drawing.Color.Purple;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(0, 192);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(262, 42);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtRequestUri
            // 
            this.txtRequestUri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequestUri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestUri.Location = new System.Drawing.Point(0, 0);
            this.txtRequestUri.Multiline = true;
            this.txtRequestUri.Name = "txtRequestUri";
            this.txtRequestUri.Size = new System.Drawing.Size(641, 234);
            this.txtRequestUri.TabIndex = 1;
            this.txtRequestUri.Text = resources.GetString("txtRequestUri.Text");
            // 
            // tabReqestResponse
            // 
            this.tabReqestResponse.Controls.Add(this.tabPageRequest);
            this.tabReqestResponse.Controls.Add(this.tabPageResponse);
            this.tabReqestResponse.Location = new System.Drawing.Point(25, 85);
            this.tabReqestResponse.Name = "tabReqestResponse";
            this.tabReqestResponse.SelectedIndex = 0;
            this.tabReqestResponse.Size = new System.Drawing.Size(859, 354);
            this.tabReqestResponse.TabIndex = 0;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.tabRequestChild);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequest.Size = new System.Drawing.Size(851, 325);
            this.tabPageRequest.TabIndex = 0;
            this.tabPageRequest.Text = "Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // tabRequestChild
            // 
            this.tabRequestChild.Controls.Add(this.tabPageRequestBody);
            this.tabRequestChild.Controls.Add(this.tabPageRequestHeaders);
            this.tabRequestChild.Location = new System.Drawing.Point(59, 42);
            this.tabRequestChild.Name = "tabRequestChild";
            this.tabRequestChild.SelectedIndex = 0;
            this.tabRequestChild.Size = new System.Drawing.Size(743, 245);
            this.tabRequestChild.TabIndex = 0;
            // 
            // tabPageRequestBody
            // 
            this.tabPageRequestBody.Controls.Add(this.txtRequestBody);
            this.tabPageRequestBody.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequestBody.Name = "tabPageRequestBody";
            this.tabPageRequestBody.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequestBody.Size = new System.Drawing.Size(735, 216);
            this.tabPageRequestBody.TabIndex = 0;
            this.tabPageRequestBody.Text = "Request Body";
            this.tabPageRequestBody.UseVisualStyleBackColor = true;
            // 
            // txtRequestBody
            // 
            this.txtRequestBody.Location = new System.Drawing.Point(88, 57);
            this.txtRequestBody.Multiline = true;
            this.txtRequestBody.Name = "txtRequestBody";
            this.txtRequestBody.Size = new System.Drawing.Size(529, 94);
            this.txtRequestBody.TabIndex = 0;
            // 
            // tabPageRequestHeaders
            // 
            this.tabPageRequestHeaders.Controls.Add(this.dataGridView1);
            this.tabPageRequestHeaders.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequestHeaders.Name = "tabPageRequestHeaders";
            this.tabPageRequestHeaders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequestHeaders.Size = new System.Drawing.Size(735, 216);
            this.tabPageRequestHeaders.TabIndex = 1;
            this.tabPageRequestHeaders.Text = "Request Headers";
            this.tabPageRequestHeaders.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.HeaderName,
            this.HeaderValue});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Width = 125;
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderName.HeaderText = "Header Name";
            this.HeaderName.MinimumWidth = 6;
            this.HeaderName.Name = "HeaderName";
            // 
            // HeaderValue
            // 
            this.HeaderValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderValue.HeaderText = "Header Value";
            this.HeaderValue.MinimumWidth = 6;
            this.HeaderValue.Name = "HeaderValue";
            // 
            // tabPageResponse
            // 
            this.tabPageResponse.Controls.Add(this.tabResponseChild);
            this.tabPageResponse.Location = new System.Drawing.Point(4, 25);
            this.tabPageResponse.Name = "tabPageResponse";
            this.tabPageResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponse.Size = new System.Drawing.Size(851, 325);
            this.tabPageResponse.TabIndex = 1;
            this.tabPageResponse.Text = "Response";
            this.tabPageResponse.UseVisualStyleBackColor = true;
            // 
            // tabResponseChild
            // 
            this.tabResponseChild.Controls.Add(this.tabPageResponseBody);
            this.tabResponseChild.Controls.Add(this.tabPageResponseHeaders);
            this.tabResponseChild.Location = new System.Drawing.Point(24, 19);
            this.tabResponseChild.Name = "tabResponseChild";
            this.tabResponseChild.SelectedIndex = 0;
            this.tabResponseChild.Size = new System.Drawing.Size(805, 284);
            this.tabResponseChild.TabIndex = 0;
            // 
            // tabPageResponseBody
            // 
            this.tabPageResponseBody.Controls.Add(this.txtResponseBody);
            this.tabPageResponseBody.Location = new System.Drawing.Point(4, 25);
            this.tabPageResponseBody.Name = "tabPageResponseBody";
            this.tabPageResponseBody.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponseBody.Size = new System.Drawing.Size(797, 255);
            this.tabPageResponseBody.TabIndex = 0;
            this.tabPageResponseBody.Text = "Response Body";
            this.tabPageResponseBody.UseVisualStyleBackColor = true;
            // 
            // txtResponseBody
            // 
            this.txtResponseBody.Location = new System.Drawing.Point(53, 42);
            this.txtResponseBody.Multiline = true;
            this.txtResponseBody.Name = "txtResponseBody";
            this.txtResponseBody.Size = new System.Drawing.Size(644, 151);
            this.txtResponseBody.TabIndex = 0;
            // 
            // tabPageResponseHeaders
            // 
            this.tabPageResponseHeaders.Location = new System.Drawing.Point(4, 25);
            this.tabPageResponseHeaders.Name = "tabPageResponseHeaders";
            this.tabPageResponseHeaders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponseHeaders.Size = new System.Drawing.Size(797, 255);
            this.tabPageResponseHeaders.TabIndex = 1;
            this.tabPageResponseHeaders.Text = "Response Headers";
            this.tabPageResponseHeaders.UseVisualStyleBackColor = true;
            // 
            // timerSendButton
            // 
            this.timerSendButton.Interval = 2100;
            this.timerSendButton.Tick += new System.EventHandler(this.timerSendButton_Tick);
            // 
            // timerLogoRemove
            // 
            this.timerLogoRemove.Interval = 5100;
            this.timerLogoRemove.Tick += new System.EventHandler(this.timerLogoRemove_Tick);
            // 
            // WebApiTesterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerRoot);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WebApiTesterControl";
            this.Size = new System.Drawing.Size(907, 697);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.splitContainerRoot.Panel1.ResumeLayout(false);
            this.splitContainerRoot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRoot)).EndInit();
            this.splitContainerRoot.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabReqestResponse.ResumeLayout(false);
            this.tabPageRequest.ResumeLayout(false);
            this.tabRequestChild.ResumeLayout(false);
            this.tabPageRequestBody.ResumeLayout(false);
            this.tabPageRequestBody.PerformLayout();
            this.tabPageRequestHeaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageResponse.ResumeLayout(false);
            this.tabResponseChild.ResumeLayout(false);
            this.tabPageResponseBody.ResumeLayout(false);
            this.tabPageResponseBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerRoot;
        private System.Windows.Forms.TabControl tabReqestResponse;
        private System.Windows.Forms.TabPage tabPageRequest;
        private System.Windows.Forms.TabControl tabRequestChild;
        private System.Windows.Forms.TabPage tabPageRequestBody;
        private System.Windows.Forms.TabPage tabPageRequestHeaders;
        private System.Windows.Forms.TabPage tabPageResponse;
        private System.Windows.Forms.TabControl tabResponseChild;
        private System.Windows.Forms.TabPage tabPageResponseBody;
        private System.Windows.Forms.TabPage tabPageResponseHeaders;
        private System.Windows.Forms.TextBox txtRequestUri;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.TextBox txtRequestBody;
        private System.Windows.Forms.TextBox txtResponseBody;
        private System.Windows.Forms.Timer timerSendButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderValue;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Timer timerLogoRemove;
    }
}
