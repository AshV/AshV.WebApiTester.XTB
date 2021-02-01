
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebApiTesterControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparatorMid = new System.Windows.Forms.ToolStripSeparator();
            this.tsbToken = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainerRoot = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRequestUri = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.tabReqestResponse = new System.Windows.Forms.TabControl();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.tabRequestChild = new System.Windows.Forms.TabControl();
            this.tabPageRequestBody = new System.Windows.Forms.TabPage();
            this.txtRequestBody = new System.Windows.Forms.TextBox();
            this.tabPageRequestHeaders = new System.Windows.Forms.TabPage();
            this.tabPageResponse = new System.Windows.Forms.TabPage();
            this.tabResponseChild = new System.Windows.Forms.TabControl();
            this.tabPageResponseBody = new System.Windows.Forms.TabPage();
            this.tabPageResponseHeaders = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResponseBody = new System.Windows.Forms.TextBox();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRoot)).BeginInit();
            this.splitContainerRoot.Panel1.SuspendLayout();
            this.splitContainerRoot.Panel2.SuspendLayout();
            this.splitContainerRoot.SuspendLayout();
            this.tabReqestResponse.SuspendLayout();
            this.tabPageRequest.SuspendLayout();
            this.tabRequestChild.SuspendLayout();
            this.tabPageRequestBody.SuspendLayout();
            this.tabPageResponse.SuspendLayout();
            this.tabResponseChild.SuspendLayout();
            this.tabPageResponseBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparatorMid,
            this.tsbToken,
            this.toolStripSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(907, 27);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(34, 24);
            this.tsbClose.Text = "❌";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparatorMid
            // 
            this.tssSeparatorMid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tssSeparatorMid.Margin = new System.Windows.Forms.Padding(1);
            this.tssSeparatorMid.Name = "tssSeparatorMid";
            this.tssSeparatorMid.Padding = new System.Windows.Forms.Padding(1);
            this.tssSeparatorMid.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbToken
            // 
            this.tsbToken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbToken.Name = "tsbToken";
            this.tsbToken.Size = new System.Drawing.Size(127, 24);
            this.tsbToken.Text = "Get Access Token";
            this.tsbToken.Click += new System.EventHandler(this.tsbSample_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // splitContainerRoot
            // 
            this.splitContainerRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRoot.Location = new System.Drawing.Point(0, 27);
            this.splitContainerRoot.Name = "splitContainerRoot";
            this.splitContainerRoot.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRoot.Panel1
            // 
            this.splitContainerRoot.Panel1.Controls.Add(this.label5);
            this.splitContainerRoot.Panel1.Controls.Add(this.label4);
            this.splitContainerRoot.Panel1.Controls.Add(this.label3);
            this.splitContainerRoot.Panel1.Controls.Add(this.label2);
            this.splitContainerRoot.Panel1.Controls.Add(this.label1);
            this.splitContainerRoot.Panel1.Controls.Add(this.txtRequestUri);
            this.splitContainerRoot.Panel1.Controls.Add(this.btnSend);
            this.splitContainerRoot.Panel1.Controls.Add(this.cmbMethod);
            // 
            // splitContainerRoot.Panel2
            // 
            this.splitContainerRoot.Panel2.Controls.Add(this.tabReqestResponse);
            this.splitContainerRoot.Size = new System.Drawing.Size(907, 670);
            this.splitContainerRoot.SplitterDistance = 179;
            this.splitContainerRoot.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "lblSize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "lblTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "lblStatusMessage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "lblStatusCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "lblVersion";
            // 
            // txtRequestUri
            // 
            this.txtRequestUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequestUri.Location = new System.Drawing.Point(202, 14);
            this.txtRequestUri.Multiline = true;
            this.txtRequestUri.Name = "txtRequestUri";
            this.txtRequestUri.Size = new System.Drawing.Size(690, 154);
            this.txtRequestUri.TabIndex = 2;
            this.txtRequestUri.Text = resources.GetString("txtRequestUri.Text");
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(14, 44);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(182, 36);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cmbMethod.Location = new System.Drawing.Point(14, 14);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(182, 24);
            this.cmbMethod.TabIndex = 0;
            // 
            // tabReqestResponse
            // 
            this.tabReqestResponse.Controls.Add(this.tabPageRequest);
            this.tabReqestResponse.Controls.Add(this.tabPageResponse);
            this.tabReqestResponse.Location = new System.Drawing.Point(60, 37);
            this.tabReqestResponse.Name = "tabReqestResponse";
            this.tabReqestResponse.SelectedIndex = 0;
            this.tabReqestResponse.Size = new System.Drawing.Size(668, 266);
            this.tabReqestResponse.TabIndex = 0;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.tabRequestChild);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequest.Size = new System.Drawing.Size(660, 237);
            this.tabPageRequest.TabIndex = 0;
            this.tabPageRequest.Text = "Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // tabRequestChild
            // 
            this.tabRequestChild.Controls.Add(this.tabPageRequestBody);
            this.tabRequestChild.Controls.Add(this.tabPageRequestHeaders);
            this.tabRequestChild.Location = new System.Drawing.Point(41, 27);
            this.tabRequestChild.Name = "tabRequestChild";
            this.tabRequestChild.SelectedIndex = 0;
            this.tabRequestChild.Size = new System.Drawing.Size(552, 167);
            this.tabRequestChild.TabIndex = 0;
            // 
            // tabPageRequestBody
            // 
            this.tabPageRequestBody.Controls.Add(this.txtRequestBody);
            this.tabPageRequestBody.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequestBody.Name = "tabPageRequestBody";
            this.tabPageRequestBody.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequestBody.Size = new System.Drawing.Size(544, 138);
            this.tabPageRequestBody.TabIndex = 0;
            this.tabPageRequestBody.Text = "Request Body";
            this.tabPageRequestBody.UseVisualStyleBackColor = true;
            // 
            // txtRequestBody
            // 
            this.txtRequestBody.Location = new System.Drawing.Point(45, 26);
            this.txtRequestBody.Multiline = true;
            this.txtRequestBody.Name = "txtRequestBody";
            this.txtRequestBody.Size = new System.Drawing.Size(100, 22);
            this.txtRequestBody.TabIndex = 0;
            // 
            // tabPageRequestHeaders
            // 
            this.tabPageRequestHeaders.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequestHeaders.Name = "tabPageRequestHeaders";
            this.tabPageRequestHeaders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequestHeaders.Size = new System.Drawing.Size(544, 138);
            this.tabPageRequestHeaders.TabIndex = 1;
            this.tabPageRequestHeaders.Text = "Request Headers";
            this.tabPageRequestHeaders.UseVisualStyleBackColor = true;
            // 
            // tabPageResponse
            // 
            this.tabPageResponse.Controls.Add(this.tabResponseChild);
            this.tabPageResponse.Location = new System.Drawing.Point(4, 25);
            this.tabPageResponse.Name = "tabPageResponse";
            this.tabPageResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponse.Size = new System.Drawing.Size(660, 237);
            this.tabPageResponse.TabIndex = 1;
            this.tabPageResponse.Text = "Response";
            this.tabPageResponse.UseVisualStyleBackColor = true;
            // 
            // tabResponseChild
            // 
            this.tabResponseChild.Controls.Add(this.tabPageResponseBody);
            this.tabResponseChild.Controls.Add(this.tabPageResponseHeaders);
            this.tabResponseChild.Location = new System.Drawing.Point(36, 25);
            this.tabResponseChild.Name = "tabResponseChild";
            this.tabResponseChild.SelectedIndex = 0;
            this.tabResponseChild.Size = new System.Drawing.Size(550, 169);
            this.tabResponseChild.TabIndex = 0;
            // 
            // tabPageResponseBody
            // 
            this.tabPageResponseBody.Controls.Add(this.txtResponseBody);
            this.tabPageResponseBody.Location = new System.Drawing.Point(4, 25);
            this.tabPageResponseBody.Name = "tabPageResponseBody";
            this.tabPageResponseBody.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponseBody.Size = new System.Drawing.Size(542, 140);
            this.tabPageResponseBody.TabIndex = 0;
            this.tabPageResponseBody.Text = "Response Body";
            this.tabPageResponseBody.UseVisualStyleBackColor = true;
            // 
            // tabPageResponseHeaders
            // 
            this.tabPageResponseHeaders.Location = new System.Drawing.Point(4, 25);
            this.tabPageResponseHeaders.Name = "tabPageResponseHeaders";
            this.tabPageResponseHeaders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResponseHeaders.Size = new System.Drawing.Size(542, 140);
            this.tabPageResponseHeaders.TabIndex = 1;
            this.tabPageResponseHeaders.Text = "Response Headers";
            this.tabPageResponseHeaders.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(405, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(486, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "lblOrgUrl";
            // 
            // txtResponseBody
            // 
            this.txtResponseBody.Location = new System.Drawing.Point(53, 42);
            this.txtResponseBody.Multiline = true;
            this.txtResponseBody.Name = "txtResponseBody";
            this.txtResponseBody.Size = new System.Drawing.Size(100, 22);
            this.txtResponseBody.TabIndex = 0;
            // 
            // WebApiTesterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.splitContainerRoot);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WebApiTesterControl";
            this.Size = new System.Drawing.Size(907, 697);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainerRoot.Panel1.ResumeLayout(false);
            this.splitContainerRoot.Panel1.PerformLayout();
            this.splitContainerRoot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRoot)).EndInit();
            this.splitContainerRoot.ResumeLayout(false);
            this.tabReqestResponse.ResumeLayout(false);
            this.tabPageRequest.ResumeLayout(false);
            this.tabRequestChild.ResumeLayout(false);
            this.tabPageRequestBody.ResumeLayout(false);
            this.tabPageRequestBody.PerformLayout();
            this.tabPageResponse.ResumeLayout(false);
            this.tabResponseChild.ResumeLayout(false);
            this.tabPageResponseBody.ResumeLayout(false);
            this.tabPageResponseBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbToken;
        private System.Windows.Forms.ToolStripSeparator tssSeparatorMid;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRequestBody;
        private System.Windows.Forms.TextBox txtResponseBody;
    }
}
