
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerRoot = new System.Windows.Forms.SplitContainer();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.splitLeftLower = new System.Windows.Forms.SplitContainer();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.splitInput = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cboFavourites = new System.Windows.Forms.ToolStripComboBox();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRemove = new System.Windows.Forms.ToolStripButton();
            this.txtRequestUri = new System.Windows.Forms.TextBox();
            this.tabReqestResponse = new System.Windows.Forms.TabControl();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.tabRequestChild = new System.Windows.Forms.TabControl();
            this.tabPageRequestBody = new System.Windows.Forms.TabPage();
            this.txtRequestBody = new System.Windows.Forms.TextBox();
            this.tabPageRequestHeaders = new System.Windows.Forms.TabPage();
            this.dgvRequestHeaders = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageResponse = new System.Windows.Forms.TabPage();
            this.tabResponseChild = new System.Windows.Forms.TabControl();
            this.tabPageResponseBody = new System.Windows.Forms.TabPage();
            this.txtResponseBody = new System.Windows.Forms.TextBox();
            this.tabPageResponseTable = new System.Windows.Forms.TabPage();
            this.dgvResponseTable = new System.Windows.Forms.DataGridView();
            this.tabPageResponseHeaders = new System.Windows.Forms.TabPage();
            this.dgvResponseHeaders = new System.Windows.Forms.DataGridView();
            this.timerSendButton = new System.Windows.Forms.Timer(this.components);
            this.timerLogoRemove = new System.Windows.Forms.Timer(this.components);
            this.txtMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRoot)).BeginInit();
            this.splitContainerRoot.Panel1.SuspendLayout();
            this.splitContainerRoot.Panel2.SuspendLayout();
            this.splitContainerRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftLower)).BeginInit();
            this.splitLeftLower.Panel1.SuspendLayout();
            this.splitLeftLower.Panel2.SuspendLayout();
            this.splitLeftLower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitInput)).BeginInit();
            this.splitInput.Panel1.SuspendLayout();
            this.splitInput.Panel2.SuspendLayout();
            this.splitInput.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabReqestResponse.SuspendLayout();
            this.tabPageRequest.SuspendLayout();
            this.tabRequestChild.SuspendLayout();
            this.tabPageRequestBody.SuspendLayout();
            this.tabPageRequestHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestHeaders)).BeginInit();
            this.tabPageResponse.SuspendLayout();
            this.tabResponseChild.SuspendLayout();
            this.tabPageResponseBody.SuspendLayout();
            this.tabPageResponseTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponseTable)).BeginInit();
            this.tabPageResponseHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponseHeaders)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerRoot
            // 
            this.splitContainerRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRoot.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRoot.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerRoot.Name = "splitContainerRoot";
            this.splitContainerRoot.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRoot.Panel1
            // 
            this.splitContainerRoot.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerRoot.Panel1.Controls.Add(this.splitMain);
            // 
            // splitContainerRoot.Panel2
            // 
            this.splitContainerRoot.Panel2.Controls.Add(this.tabReqestResponse);
            this.splitContainerRoot.Size = new System.Drawing.Size(680, 566);
            this.splitContainerRoot.SplitterDistance = 190;
            this.splitContainerRoot.SplitterWidth = 3;
            this.splitContainerRoot.TabIndex = 5;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Margin = new System.Windows.Forms.Padding(2);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitLeft);
            this.splitMain.Panel1MinSize = 10;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitInput);
            this.splitMain.Size = new System.Drawing.Size(680, 190);
            this.splitMain.SplitterDistance = 196;
            this.splitMain.SplitterWidth = 8;
            this.splitMain.TabIndex = 3;
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitLeft.IsSplitterFixed = true;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Margin = new System.Windows.Forms.Padding(0);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.Controls.Add(this.cmbMethod);
            this.splitLeft.Panel1MinSize = 21;
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.Controls.Add(this.splitLeftLower);
            this.splitLeft.Size = new System.Drawing.Size(196, 190);
            this.splitLeft.SplitterDistance = 21;
            this.splitLeft.TabIndex = 5;
            // 
            // cmbMethod
            // 
            this.cmbMethod.BackColor = System.Drawing.Color.Purple;
            this.cmbMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMethod.ForeColor = System.Drawing.Color.White;
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PATCH",
            "DELETE",
            "PUT"});
            this.cmbMethod.Location = new System.Drawing.Point(0, 0);
            this.cmbMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(196, 21);
            this.cmbMethod.TabIndex = 2;
            // 
            // splitLeftLower
            // 
            this.splitLeftLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeftLower.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitLeftLower.IsSplitterFixed = true;
            this.splitLeftLower.Location = new System.Drawing.Point(0, 0);
            this.splitLeftLower.Margin = new System.Windows.Forms.Padding(0);
            this.splitLeftLower.Name = "splitLeftLower";
            this.splitLeftLower.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeftLower.Panel1
            // 
            this.splitLeftLower.Panel1.Controls.Add(this.pictureBoxLogo);
            this.splitLeftLower.Panel1.Controls.Add(this.txtMessage);
            // 
            // splitLeftLower.Panel2
            // 
            this.splitLeftLower.Panel2.Controls.Add(this.btnSend);
            this.splitLeftLower.Panel2MinSize = 40;
            this.splitLeftLower.Size = new System.Drawing.Size(196, 165);
            this.splitLeftLower.SplitterDistance = 121;
            this.splitLeftLower.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(196, 121);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.BackColor = System.Drawing.Color.Purple;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(196, 40);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // splitInput
            // 
            this.splitInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitInput.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitInput.IsSplitterFixed = true;
            this.splitInput.Location = new System.Drawing.Point(0, 0);
            this.splitInput.Name = "splitInput";
            this.splitInput.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitInput.Panel1
            // 
            this.splitInput.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitInput.Panel2
            // 
            this.splitInput.Panel2.Controls.Add(this.txtRequestUri);
            this.splitInput.Size = new System.Drawing.Size(476, 190);
            this.splitInput.SplitterDistance = 25;
            this.splitInput.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboFavourites,
            this.btnAdd,
            this.btnRemove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(476, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cboFavourites
            // 
            this.cboFavourites.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFavourites.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFavourites.Name = "cboFavourites";
            this.cboFavourites.Size = new System.Drawing.Size(121, 25);
            this.cboFavourites.SelectedIndexChanged += new System.EventHandler(this.cboFavourites_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "Add current request information to your history";
            this.btnAdd.AccessibleName = "AddRequestToHistory";
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::AshV.WebApiTester.XTB.Properties.Resources.Plus;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "➕";
            this.btnAdd.ToolTipText = "Add current request information to your history";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleDescription = "Remove currently selected Request from favourites";
            this.btnRemove.AccessibleName = "Remove Request";
            this.btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemove.Image = global::AshV.WebApiTester.XTB.Properties.Resources.Stop;
            this.btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 22);
            this.btnRemove.Text = "Remove currently selected Request from favourites";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRequestUri
            // 
            this.txtRequestUri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequestUri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestUri.Location = new System.Drawing.Point(0, 0);
            this.txtRequestUri.Margin = new System.Windows.Forms.Padding(2);
            this.txtRequestUri.Multiline = true;
            this.txtRequestUri.Name = "txtRequestUri";
            this.txtRequestUri.Size = new System.Drawing.Size(476, 161);
            this.txtRequestUri.TabIndex = 1;
            this.txtRequestUri.Text = "accounts?$top=10\r\n&$select=name,emailaddress1,address1_line1,address1_city,addres" +
    "s1_stateorprovince,address1_composite\r\n&$expand=primarycontactid";
            // 
            // tabReqestResponse
            // 
            this.tabReqestResponse.Controls.Add(this.tabPageRequest);
            this.tabReqestResponse.Controls.Add(this.tabPageResponse);
            this.tabReqestResponse.Location = new System.Drawing.Point(19, 69);
            this.tabReqestResponse.Margin = new System.Windows.Forms.Padding(2);
            this.tabReqestResponse.Name = "tabReqestResponse";
            this.tabReqestResponse.SelectedIndex = 0;
            this.tabReqestResponse.Size = new System.Drawing.Size(644, 288);
            this.tabReqestResponse.TabIndex = 0;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.tabRequestChild);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequest.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageRequest.Size = new System.Drawing.Size(636, 262);
            this.tabPageRequest.TabIndex = 0;
            this.tabPageRequest.Text = "Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // tabRequestChild
            // 
            this.tabRequestChild.Controls.Add(this.tabPageRequestBody);
            this.tabRequestChild.Controls.Add(this.tabPageRequestHeaders);
            this.tabRequestChild.Location = new System.Drawing.Point(44, 34);
            this.tabRequestChild.Margin = new System.Windows.Forms.Padding(2);
            this.tabRequestChild.Name = "tabRequestChild";
            this.tabRequestChild.SelectedIndex = 0;
            this.tabRequestChild.Size = new System.Drawing.Size(557, 199);
            this.tabRequestChild.TabIndex = 0;
            // 
            // tabPageRequestBody
            // 
            this.tabPageRequestBody.Controls.Add(this.txtRequestBody);
            this.tabPageRequestBody.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequestBody.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageRequestBody.Name = "tabPageRequestBody";
            this.tabPageRequestBody.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageRequestBody.Size = new System.Drawing.Size(549, 173);
            this.tabPageRequestBody.TabIndex = 0;
            this.tabPageRequestBody.Text = "Request Body";
            this.tabPageRequestBody.UseVisualStyleBackColor = true;
            // 
            // txtRequestBody
            // 
            this.txtRequestBody.Location = new System.Drawing.Point(66, 46);
            this.txtRequestBody.Margin = new System.Windows.Forms.Padding(2);
            this.txtRequestBody.Multiline = true;
            this.txtRequestBody.Name = "txtRequestBody";
            this.txtRequestBody.Size = new System.Drawing.Size(398, 77);
            this.txtRequestBody.TabIndex = 0;
            // 
            // tabPageRequestHeaders
            // 
            this.tabPageRequestHeaders.Controls.Add(this.dgvRequestHeaders);
            this.tabPageRequestHeaders.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequestHeaders.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageRequestHeaders.Name = "tabPageRequestHeaders";
            this.tabPageRequestHeaders.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageRequestHeaders.Size = new System.Drawing.Size(549, 173);
            this.tabPageRequestHeaders.TabIndex = 1;
            this.tabPageRequestHeaders.Text = "Request Headers";
            this.tabPageRequestHeaders.UseVisualStyleBackColor = true;
            // 
            // dgvRequestHeaders
            // 
            this.dgvRequestHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.HeaderName,
            this.HeaderValue});
            this.dgvRequestHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequestHeaders.Location = new System.Drawing.Point(2, 2);
            this.dgvRequestHeaders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRequestHeaders.Name = "dgvRequestHeaders";
            this.dgvRequestHeaders.RowHeadersWidth = 51;
            this.dgvRequestHeaders.RowTemplate.Height = 24;
            this.dgvRequestHeaders.Size = new System.Drawing.Size(545, 169);
            this.dgvRequestHeaders.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.HeaderText = "";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.ToolTipText = "Select the headers to pass along with request.";
            this.Select.Width = 75;
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HeaderName.HeaderText = "Header Name";
            this.HeaderName.MinimumWidth = 6;
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.ToolTipText = "HTTP Header Name";
            this.HeaderName.Width = 98;
            // 
            // HeaderValue
            // 
            this.HeaderValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderValue.HeaderText = "Header Value";
            this.HeaderValue.MinimumWidth = 6;
            this.HeaderValue.Name = "HeaderValue";
            this.HeaderValue.ToolTipText = "HTTP Header Value";
            // 
            // tabPageResponse
            // 
            this.tabPageResponse.Controls.Add(this.tabResponseChild);
            this.tabPageResponse.Location = new System.Drawing.Point(4, 22);
            this.tabPageResponse.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageResponse.Name = "tabPageResponse";
            this.tabPageResponse.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageResponse.Size = new System.Drawing.Size(636, 262);
            this.tabPageResponse.TabIndex = 1;
            this.tabPageResponse.Text = "Response";
            this.tabPageResponse.UseVisualStyleBackColor = true;
            // 
            // tabResponseChild
            // 
            this.tabResponseChild.Controls.Add(this.tabPageResponseBody);
            this.tabResponseChild.Controls.Add(this.tabPageResponseTable);
            this.tabResponseChild.Controls.Add(this.tabPageResponseHeaders);
            this.tabResponseChild.Location = new System.Drawing.Point(18, 15);
            this.tabResponseChild.Margin = new System.Windows.Forms.Padding(2);
            this.tabResponseChild.Name = "tabResponseChild";
            this.tabResponseChild.SelectedIndex = 0;
            this.tabResponseChild.Size = new System.Drawing.Size(604, 231);
            this.tabResponseChild.TabIndex = 0;
            // 
            // tabPageResponseBody
            // 
            this.tabPageResponseBody.Controls.Add(this.txtResponseBody);
            this.tabPageResponseBody.Location = new System.Drawing.Point(4, 22);
            this.tabPageResponseBody.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageResponseBody.Name = "tabPageResponseBody";
            this.tabPageResponseBody.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageResponseBody.Size = new System.Drawing.Size(596, 205);
            this.tabPageResponseBody.TabIndex = 0;
            this.tabPageResponseBody.Text = "Response Body";
            this.tabPageResponseBody.UseVisualStyleBackColor = true;
            // 
            // txtResponseBody
            // 
            this.txtResponseBody.Location = new System.Drawing.Point(40, 34);
            this.txtResponseBody.Margin = new System.Windows.Forms.Padding(2);
            this.txtResponseBody.Multiline = true;
            this.txtResponseBody.Name = "txtResponseBody";
            this.txtResponseBody.Size = new System.Drawing.Size(484, 123);
            this.txtResponseBody.TabIndex = 0;
            // 
            // tabPageResponseTable
            // 
            this.tabPageResponseTable.Controls.Add(this.dgvResponseTable);
            this.tabPageResponseTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageResponseTable.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageResponseTable.Name = "tabPageResponseTable";
            this.tabPageResponseTable.Size = new System.Drawing.Size(596, 205);
            this.tabPageResponseTable.TabIndex = 2;
            this.tabPageResponseTable.Text = "Response As Table";
            this.tabPageResponseTable.UseVisualStyleBackColor = true;
            // 
            // dgvResponseTable
            // 
            this.dgvResponseTable.AllowUserToAddRows = false;
            this.dgvResponseTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            this.dgvResponseTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResponseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResponseTable.Location = new System.Drawing.Point(0, 0);
            this.dgvResponseTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResponseTable.Name = "dgvResponseTable";
            this.dgvResponseTable.ReadOnly = true;
            this.dgvResponseTable.RowHeadersVisible = false;
            this.dgvResponseTable.RowHeadersWidth = 51;
            this.dgvResponseTable.RowTemplate.Height = 24;
            this.dgvResponseTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResponseTable.Size = new System.Drawing.Size(596, 205);
            this.dgvResponseTable.TabIndex = 0;
            // 
            // tabPageResponseHeaders
            // 
            this.tabPageResponseHeaders.Controls.Add(this.dgvResponseHeaders);
            this.tabPageResponseHeaders.Location = new System.Drawing.Point(4, 22);
            this.tabPageResponseHeaders.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageResponseHeaders.Name = "tabPageResponseHeaders";
            this.tabPageResponseHeaders.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageResponseHeaders.Size = new System.Drawing.Size(596, 205);
            this.tabPageResponseHeaders.TabIndex = 1;
            this.tabPageResponseHeaders.Text = "Response Headers";
            this.tabPageResponseHeaders.UseVisualStyleBackColor = true;
            // 
            // dgvResponseHeaders
            // 
            this.dgvResponseHeaders.AllowUserToAddRows = false;
            this.dgvResponseHeaders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Purple;
            this.dgvResponseHeaders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResponseHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponseHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResponseHeaders.Location = new System.Drawing.Point(2, 2);
            this.dgvResponseHeaders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResponseHeaders.Name = "dgvResponseHeaders";
            this.dgvResponseHeaders.ReadOnly = true;
            this.dgvResponseHeaders.RowHeadersWidth = 51;
            this.dgvResponseHeaders.RowTemplate.Height = 24;
            this.dgvResponseHeaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResponseHeaders.Size = new System.Drawing.Size(592, 201);
            this.dgvResponseHeaders.TabIndex = 0;
            // 
            // timerSendButton
            // 
            this.timerSendButton.Interval = 2100;
            this.timerSendButton.Tick += new System.EventHandler(this.timerSendButton_Tick);
            // 
            // timerLogoRemove
            // 
            this.timerLogoRemove.Interval = 1100;
            this.timerLogoRemove.Tick += new System.EventHandler(this.timerLogoRemove_Tick);
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(0);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(196, 121);
            this.txtMessage.TabIndex = 4;
            // 
            // WebApiTesterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerRoot);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "WebApiTesterControl";
            this.Size = new System.Drawing.Size(680, 566);
            this.TabIcon = global::AshV.WebApiTester.XTB.Properties.Resources.Rocket;
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.splitContainerRoot.Panel1.ResumeLayout(false);
            this.splitContainerRoot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRoot)).EndInit();
            this.splitContainerRoot.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            this.splitLeftLower.Panel1.ResumeLayout(false);
            this.splitLeftLower.Panel1.PerformLayout();
            this.splitLeftLower.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftLower)).EndInit();
            this.splitLeftLower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.splitInput.Panel1.ResumeLayout(false);
            this.splitInput.Panel1.PerformLayout();
            this.splitInput.Panel2.ResumeLayout(false);
            this.splitInput.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitInput)).EndInit();
            this.splitInput.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabReqestResponse.ResumeLayout(false);
            this.tabPageRequest.ResumeLayout(false);
            this.tabRequestChild.ResumeLayout(false);
            this.tabPageRequestBody.ResumeLayout(false);
            this.tabPageRequestBody.PerformLayout();
            this.tabPageRequestHeaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestHeaders)).EndInit();
            this.tabPageResponse.ResumeLayout(false);
            this.tabResponseChild.ResumeLayout(false);
            this.tabPageResponseBody.ResumeLayout(false);
            this.tabPageResponseBody.PerformLayout();
            this.tabPageResponseTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponseTable)).EndInit();
            this.tabPageResponseHeaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponseHeaders)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.DataGridView dgvRequestHeaders;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Timer timerLogoRemove;
        private System.Windows.Forms.DataGridView dgvResponseHeaders;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderValue;
        private System.Windows.Forms.TabPage tabPageResponseTable;
        private System.Windows.Forms.DataGridView dgvResponseTable;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cboFavourites;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnRemove;
        private System.Windows.Forms.SplitContainer splitInput;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.SplitContainer splitLeftLower;
        private System.Windows.Forms.TextBox txtMessage;
    }
}
