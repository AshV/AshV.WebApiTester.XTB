
namespace AshV.WebApiTester.XTB
{
    partial class AddRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRequest));
            this.lblOr = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboExisting = new System.Windows.Forms.ComboBox();
            this.lblUpdateExisting = new System.Windows.Forms.Label();
            this.txtSaveName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitLower = new System.Windows.Forms.SplitContainer();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLower)).BeginInit();
            this.splitLower.Panel1.SuspendLayout();
            this.splitLower.Panel2.SuspendLayout();
            this.splitLower.SuspendLayout();
            this.grpDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(132, 39);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(74, 13);
            this.lblOr.TabIndex = 11;
            this.lblOr.Text = "------- OR --------";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleDescription = "Ok Button";
            this.btnOK.AccessibleName = "Ok Button";
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(122, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboExisting
            // 
            this.cboExisting.AccessibleDescription = "Drop Down for Existing Request";
            this.cboExisting.AccessibleName = "Existing Request";
            this.cboExisting.FormattingEnabled = true;
            this.cboExisting.Location = new System.Drawing.Point(122, 55);
            this.cboExisting.Name = "cboExisting";
            this.cboExisting.Size = new System.Drawing.Size(198, 21);
            this.cboExisting.TabIndex = 9;
            this.cboExisting.SelectedIndexChanged += new System.EventHandler(this.cboExisting_SelectedValueChanged);
            // 
            // lblUpdateExisting
            // 
            this.lblUpdateExisting.AccessibleDescription = "Label for Update Exisiting Selection";
            this.lblUpdateExisting.AccessibleName = "Label Update Existing";
            this.lblUpdateExisting.AutoSize = true;
            this.lblUpdateExisting.Location = new System.Drawing.Point(21, 58);
            this.lblUpdateExisting.Name = "lblUpdateExisting";
            this.lblUpdateExisting.Size = new System.Drawing.Size(84, 13);
            this.lblUpdateExisting.TabIndex = 8;
            this.lblUpdateExisting.Text = "Update Existing:";
            // 
            // txtSaveName
            // 
            this.txtSaveName.AccessibleDescription = "Name to save Request as";
            this.txtSaveName.AccessibleName = "Request Name";
            this.txtSaveName.Location = new System.Drawing.Point(122, 14);
            this.txtSaveName.Name = "txtSaveName";
            this.txtSaveName.Size = new System.Drawing.Size(198, 20);
            this.txtSaveName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AccessibleDescription = "Label for Request Name";
            this.lblName.AccessibleName = "Label Request";
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "New Request Name:";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.txtSaveName);
            this.splitMain.Panel1.Controls.Add(this.lblOr);
            this.splitMain.Panel1.Controls.Add(this.lblName);
            this.splitMain.Panel1.Controls.Add(this.cboExisting);
            this.splitMain.Panel1.Controls.Add(this.lblUpdateExisting);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitLower);
            this.splitMain.Size = new System.Drawing.Size(332, 315);
            this.splitMain.SplitterDistance = 83;
            this.splitMain.TabIndex = 12;
            // 
            // splitLower
            // 
            this.splitLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLower.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitLower.Location = new System.Drawing.Point(0, 0);
            this.splitLower.Name = "splitLower";
            this.splitLower.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLower.Panel1
            // 
            this.splitLower.Panel1.Controls.Add(this.grpDescription);
            // 
            // splitLower.Panel2
            // 
            this.splitLower.Panel2.Controls.Add(this.btnOK);
            this.splitLower.Size = new System.Drawing.Size(332, 228);
            this.splitLower.SplitterDistance = 181;
            this.splitLower.TabIndex = 11;
            // 
            // grpDescription
            // 
            this.grpDescription.AccessibleDescription = "Description of Request";
            this.grpDescription.AccessibleName = "Description";
            this.grpDescription.Controls.Add(this.txtDescription);
            this.grpDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDescription.Location = new System.Drawing.Point(0, 0);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(332, 181);
            this.grpDescription.TabIndex = 0;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(3, 16);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(326, 162);
            this.txtDescription.TabIndex = 0;
            // 
            // AddRequest
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 315);
            this.Controls.Add(this.splitMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRequest";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Request to History";
            this.Load += new System.EventHandler(this.AddRequest_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel1.PerformLayout();
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.splitLower.Panel1.ResumeLayout(false);
            this.splitLower.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLower)).EndInit();
            this.splitLower.ResumeLayout(false);
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboExisting;
        private System.Windows.Forms.Label lblUpdateExisting;
        private System.Windows.Forms.TextBox txtSaveName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitLower;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}