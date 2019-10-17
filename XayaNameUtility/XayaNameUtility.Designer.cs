namespace XayaNameUtility
{
    partial class XayaNameUtility
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XayaNameUtility));
            this.btnCheckSingleNameExists = new System.Windows.Forms.Button();
            this.txtCheckSingleNameExists = new System.Windows.Forms.TextBox();
            this.chkCheckSingleNameExists = new System.Windows.Forms.CheckBox();
            this.txtNameListToCreate = new System.Windows.Forms.TextBox();
            this.txtNameListResults = new System.Windows.Forms.TextBox();
            this.btnCreateNamesFromList = new System.Windows.Forms.Button();
            this.txtChiAddressToSendNamesTo = new System.Windows.Forms.TextBox();
            this.txtWalletNames = new System.Windows.Forms.TextBox();
            this.btnGetNamesInWallet = new System.Windows.Forms.Button();
            this.lvNames = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsNameListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUncheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSendNamesToAddress = new System.Windows.Forms.Button();
            this.tabUtilities = new System.Windows.Forms.TabControl();
            this.tpCheckNameExists = new System.Windows.Forms.TabPage();
            this.tpBulkRegisterNames = new System.Windows.Forms.TabPage();
            this.tpBulkSendNames = new System.Windows.Forms.TabPage();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbWallets = new System.Windows.Forms.ToolStripComboBox();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tpGuide = new System.Windows.Forms.TabPage();
            this.txtGuide = new System.Windows.Forms.TextBox();
            this.txtSendGuide = new System.Windows.Forms.TextBox();
            this.lblChiAddress = new System.Windows.Forms.Label();
            this.lblListOfNamesToRegister = new System.Windows.Forms.Label();
            this.lblRegisterNamesResults = new System.Windows.Forms.Label();
            this.txtRegisterGuide = new System.Windows.Forms.TextBox();
            this.txtNameExistsGuide = new System.Windows.Forms.TextBox();
            this.lblNameToCheck = new System.Windows.Forms.Label();
            this.chkNameIsMine = new System.Windows.Forms.CheckBox();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetTheCodeOnGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNameListMenu.SuspendLayout();
            this.tabUtilities.SuspendLayout();
            this.tpCheckNameExists.SuspendLayout();
            this.tpBulkRegisterNames.SuspendLayout();
            this.tpBulkSendNames.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.tpGuide.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckSingleNameExists
            // 
            this.btnCheckSingleNameExists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckSingleNameExists.Location = new System.Drawing.Point(9, 120);
            this.btnCheckSingleNameExists.Name = "btnCheckSingleNameExists";
            this.btnCheckSingleNameExists.Size = new System.Drawing.Size(694, 23);
            this.btnCheckSingleNameExists.TabIndex = 0;
            this.btnCheckSingleNameExists.Text = "Check if name exists";
            this.btnCheckSingleNameExists.UseVisualStyleBackColor = true;
            this.btnCheckSingleNameExists.Click += new System.EventHandler(this.btnCheckSingleNameExists_Click);
            // 
            // txtCheckSingleNameExists
            // 
            this.txtCheckSingleNameExists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckSingleNameExists.Location = new System.Drawing.Point(109, 94);
            this.txtCheckSingleNameExists.Name = "txtCheckSingleNameExists";
            this.txtCheckSingleNameExists.Size = new System.Drawing.Size(594, 20);
            this.txtCheckSingleNameExists.TabIndex = 1;
            // 
            // chkCheckSingleNameExists
            // 
            this.chkCheckSingleNameExists.AutoSize = true;
            this.chkCheckSingleNameExists.Enabled = false;
            this.chkCheckSingleNameExists.Location = new System.Drawing.Point(9, 149);
            this.chkCheckSingleNameExists.Name = "chkCheckSingleNameExists";
            this.chkCheckSingleNameExists.Size = new System.Drawing.Size(15, 14);
            this.chkCheckSingleNameExists.TabIndex = 2;
            this.chkCheckSingleNameExists.UseVisualStyleBackColor = true;
            // 
            // txtNameListToCreate
            // 
            this.txtNameListToCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNameListToCreate.Location = new System.Drawing.Point(6, 137);
            this.txtNameListToCreate.MaxLength = 327673344;
            this.txtNameListToCreate.Multiline = true;
            this.txtNameListToCreate.Name = "txtNameListToCreate";
            this.txtNameListToCreate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNameListToCreate.Size = new System.Drawing.Size(335, 230);
            this.txtNameListToCreate.TabIndex = 3;
            // 
            // txtNameListResults
            // 
            this.txtNameListResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameListResults.Location = new System.Drawing.Point(347, 136);
            this.txtNameListResults.MaxLength = 327673344;
            this.txtNameListResults.Multiline = true;
            this.txtNameListResults.Name = "txtNameListResults";
            this.txtNameListResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNameListResults.Size = new System.Drawing.Size(356, 231);
            this.txtNameListResults.TabIndex = 4;
            // 
            // btnCreateNamesFromList
            // 
            this.btnCreateNamesFromList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNamesFromList.Location = new System.Drawing.Point(3, 95);
            this.btnCreateNamesFromList.Name = "btnCreateNamesFromList";
            this.btnCreateNamesFromList.Size = new System.Drawing.Size(700, 23);
            this.btnCreateNamesFromList.TabIndex = 5;
            this.btnCreateNamesFromList.Text = "Register all names in list";
            this.btnCreateNamesFromList.UseVisualStyleBackColor = true;
            this.btnCreateNamesFromList.Click += new System.EventHandler(this.btnCreateNamesFromList_Click);
            // 
            // txtChiAddressToSendNamesTo
            // 
            this.txtChiAddressToSendNamesTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtChiAddressToSendNamesTo.Location = new System.Drawing.Point(81, 321);
            this.txtChiAddressToSendNamesTo.Name = "txtChiAddressToSendNamesTo";
            this.txtChiAddressToSendNamesTo.Size = new System.Drawing.Size(244, 20);
            this.txtChiAddressToSendNamesTo.TabIndex = 6;
            // 
            // txtWalletNames
            // 
            this.txtWalletNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWalletNames.Location = new System.Drawing.Point(6, 152);
            this.txtWalletNames.MaxLength = 327673344;
            this.txtWalletNames.Multiline = true;
            this.txtWalletNames.Name = "txtWalletNames";
            this.txtWalletNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWalletNames.Size = new System.Drawing.Size(319, 163);
            this.txtWalletNames.TabIndex = 7;
            // 
            // btnGetNamesInWallet
            // 
            this.btnGetNamesInWallet.Location = new System.Drawing.Point(3, 123);
            this.btnGetNamesInWallet.Name = "btnGetNamesInWallet";
            this.btnGetNamesInWallet.Size = new System.Drawing.Size(322, 23);
            this.btnGetNamesInWallet.TabIndex = 8;
            this.btnGetNamesInWallet.Text = "Get names in wallet";
            this.btnGetNamesInWallet.UseVisualStyleBackColor = true;
            this.btnGetNamesInWallet.Click += new System.EventHandler(this.btnGetNamesInWallet_Click);
            // 
            // lvNames
            // 
            this.lvNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvNames.CheckBoxes = true;
            this.lvNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
            this.lvNames.ContextMenuStrip = this.cmsNameListMenu;
            this.lvNames.GridLines = true;
            this.lvNames.Location = new System.Drawing.Point(331, 6);
            this.lvNames.Name = "lvNames";
            this.lvNames.Size = new System.Drawing.Size(372, 361);
            this.lvNames.TabIndex = 10;
            this.lvNames.UseCompatibleStateImageBehavior = false;
            this.lvNames.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 293;
            // 
            // cmsNameListMenu
            // 
            this.cmsNameListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheckAll,
            this.tsmiUncheckAll});
            this.cmsNameListMenu.Name = "cmsNameListMenu";
            this.cmsNameListMenu.Size = new System.Drawing.Size(174, 48);
            // 
            // tsmiCheckAll
            // 
            this.tsmiCheckAll.Name = "tsmiCheckAll";
            this.tsmiCheckAll.Size = new System.Drawing.Size(173, 22);
            this.tsmiCheckAll.Text = "Check all names";
            this.tsmiCheckAll.Click += new System.EventHandler(this.tsmiCheckAll_Click);
            // 
            // tsmiUncheckAll
            // 
            this.tsmiUncheckAll.Name = "tsmiUncheckAll";
            this.tsmiUncheckAll.Size = new System.Drawing.Size(173, 22);
            this.tsmiUncheckAll.Text = "Uncheck all names";
            this.tsmiUncheckAll.Click += new System.EventHandler(this.tsmiUncheckAll_Click);
            // 
            // btnSendNamesToAddress
            // 
            this.btnSendNamesToAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendNamesToAddress.Location = new System.Drawing.Point(6, 347);
            this.btnSendNamesToAddress.Name = "btnSendNamesToAddress";
            this.btnSendNamesToAddress.Size = new System.Drawing.Size(319, 23);
            this.btnSendNamesToAddress.TabIndex = 11;
            this.btnSendNamesToAddress.Text = "Send Names to Address";
            this.btnSendNamesToAddress.UseVisualStyleBackColor = true;
            this.btnSendNamesToAddress.Click += new System.EventHandler(this.btnSendNamesToAddress_Click);
            // 
            // tabUtilities
            // 
            this.tabUtilities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabUtilities.Controls.Add(this.tpGuide);
            this.tabUtilities.Controls.Add(this.tpCheckNameExists);
            this.tabUtilities.Controls.Add(this.tpBulkRegisterNames);
            this.tabUtilities.Controls.Add(this.tpBulkSendNames);
            this.tabUtilities.Location = new System.Drawing.Point(12, 39);
            this.tabUtilities.Name = "tabUtilities";
            this.tabUtilities.SelectedIndex = 0;
            this.tabUtilities.Size = new System.Drawing.Size(717, 399);
            this.tabUtilities.TabIndex = 12;
            // 
            // tpCheckNameExists
            // 
            this.tpCheckNameExists.Controls.Add(this.chkNameIsMine);
            this.tpCheckNameExists.Controls.Add(this.lblNameToCheck);
            this.tpCheckNameExists.Controls.Add(this.txtNameExistsGuide);
            this.tpCheckNameExists.Controls.Add(this.txtCheckSingleNameExists);
            this.tpCheckNameExists.Controls.Add(this.btnCheckSingleNameExists);
            this.tpCheckNameExists.Controls.Add(this.chkCheckSingleNameExists);
            this.tpCheckNameExists.Location = new System.Drawing.Point(4, 22);
            this.tpCheckNameExists.Name = "tpCheckNameExists";
            this.tpCheckNameExists.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheckNameExists.Size = new System.Drawing.Size(709, 373);
            this.tpCheckNameExists.TabIndex = 0;
            this.tpCheckNameExists.Text = "Check Name Exists";
            this.tpCheckNameExists.UseVisualStyleBackColor = true;
            // 
            // tpBulkRegisterNames
            // 
            this.tpBulkRegisterNames.Controls.Add(this.txtRegisterGuide);
            this.tpBulkRegisterNames.Controls.Add(this.lblRegisterNamesResults);
            this.tpBulkRegisterNames.Controls.Add(this.lblListOfNamesToRegister);
            this.tpBulkRegisterNames.Controls.Add(this.btnCreateNamesFromList);
            this.tpBulkRegisterNames.Controls.Add(this.txtNameListToCreate);
            this.tpBulkRegisterNames.Controls.Add(this.txtNameListResults);
            this.tpBulkRegisterNames.Location = new System.Drawing.Point(4, 22);
            this.tpBulkRegisterNames.Name = "tpBulkRegisterNames";
            this.tpBulkRegisterNames.Padding = new System.Windows.Forms.Padding(3);
            this.tpBulkRegisterNames.Size = new System.Drawing.Size(709, 373);
            this.tpBulkRegisterNames.TabIndex = 1;
            this.tpBulkRegisterNames.Text = "Bulk Register Names";
            this.tpBulkRegisterNames.UseVisualStyleBackColor = true;
            // 
            // tpBulkSendNames
            // 
            this.tpBulkSendNames.Controls.Add(this.lblChiAddress);
            this.tpBulkSendNames.Controls.Add(this.txtSendGuide);
            this.tpBulkSendNames.Controls.Add(this.btnGetNamesInWallet);
            this.tpBulkSendNames.Controls.Add(this.btnSendNamesToAddress);
            this.tpBulkSendNames.Controls.Add(this.txtChiAddressToSendNamesTo);
            this.tpBulkSendNames.Controls.Add(this.lvNames);
            this.tpBulkSendNames.Controls.Add(this.txtWalletNames);
            this.tpBulkSendNames.Location = new System.Drawing.Point(4, 22);
            this.tpBulkSendNames.Name = "tpBulkSendNames";
            this.tpBulkSendNames.Padding = new System.Windows.Forms.Padding(3);
            this.tpBulkSendNames.Size = new System.Drawing.Size(709, 373);
            this.tpBulkSendNames.TabIndex = 2;
            this.tpBulkSendNames.Text = "Bulk Send Names";
            this.tpBulkSendNames.UseVisualStyleBackColor = true;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiTools,
            this.tscbWallets,
            this.tsmiHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(741, 27);
            this.msMenu.TabIndex = 13;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 23);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(47, 23);
            this.tsmiTools.Text = "&Tools";
            // 
            // tscbWallets
            // 
            this.tscbWallets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbWallets.Name = "tscbWallets";
            this.tscbWallets.Size = new System.Drawing.Size(121, 23);
            this.tscbWallets.ToolTipText = "Wallets";
            this.tscbWallets.SelectedIndexChanged += new System.EventHandler(this.tscbWallets_SelectedIndexChanged);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout,
            this.tsmiGetTheCodeOnGitHub});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 23);
            this.tsmiHelp.Text = "&Help";
            // 
            // tpGuide
            // 
            this.tpGuide.Controls.Add(this.txtGuide);
            this.tpGuide.Location = new System.Drawing.Point(4, 22);
            this.tpGuide.Name = "tpGuide";
            this.tpGuide.Padding = new System.Windows.Forms.Padding(3);
            this.tpGuide.Size = new System.Drawing.Size(709, 373);
            this.tpGuide.TabIndex = 3;
            this.tpGuide.Text = "Guide";
            this.tpGuide.UseVisualStyleBackColor = true;
            // 
            // txtGuide
            // 
            this.txtGuide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGuide.Location = new System.Drawing.Point(3, 3);
            this.txtGuide.Multiline = true;
            this.txtGuide.Name = "txtGuide";
            this.txtGuide.ReadOnly = true;
            this.txtGuide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuide.Size = new System.Drawing.Size(703, 367);
            this.txtGuide.TabIndex = 0;
            this.txtGuide.Text = resources.GetString("txtGuide.Text");
            // 
            // txtSendGuide
            // 
            this.txtSendGuide.Location = new System.Drawing.Point(6, 6);
            this.txtSendGuide.MaxLength = 327673344;
            this.txtSendGuide.Multiline = true;
            this.txtSendGuide.Name = "txtSendGuide";
            this.txtSendGuide.ReadOnly = true;
            this.txtSendGuide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendGuide.Size = new System.Drawing.Size(319, 111);
            this.txtSendGuide.TabIndex = 12;
            this.txtSendGuide.Text = resources.GetString("txtSendGuide.Text");
            // 
            // lblChiAddress
            // 
            this.lblChiAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChiAddress.AutoSize = true;
            this.lblChiAddress.Location = new System.Drawing.Point(6, 324);
            this.lblChiAddress.Name = "lblChiAddress";
            this.lblChiAddress.Size = new System.Drawing.Size(69, 13);
            this.lblChiAddress.TabIndex = 13;
            this.lblChiAddress.Text = "CHI Address:";
            // 
            // lblListOfNamesToRegister
            // 
            this.lblListOfNamesToRegister.AutoSize = true;
            this.lblListOfNamesToRegister.Location = new System.Drawing.Point(6, 121);
            this.lblListOfNamesToRegister.Name = "lblListOfNamesToRegister";
            this.lblListOfNamesToRegister.Size = new System.Drawing.Size(118, 13);
            this.lblListOfNamesToRegister.TabIndex = 6;
            this.lblListOfNamesToRegister.Text = "List of names to register";
            // 
            // lblRegisterNamesResults
            // 
            this.lblRegisterNamesResults.AutoSize = true;
            this.lblRegisterNamesResults.Location = new System.Drawing.Point(344, 120);
            this.lblRegisterNamesResults.Name = "lblRegisterNamesResults";
            this.lblRegisterNamesResults.Size = new System.Drawing.Size(139, 13);
            this.lblRegisterNamesResults.TabIndex = 7;
            this.lblRegisterNamesResults.Text = "Results of registering names";
            // 
            // txtRegisterGuide
            // 
            this.txtRegisterGuide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegisterGuide.Location = new System.Drawing.Point(6, 8);
            this.txtRegisterGuide.MaxLength = 327673344;
            this.txtRegisterGuide.Multiline = true;
            this.txtRegisterGuide.Name = "txtRegisterGuide";
            this.txtRegisterGuide.ReadOnly = true;
            this.txtRegisterGuide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegisterGuide.Size = new System.Drawing.Size(697, 81);
            this.txtRegisterGuide.TabIndex = 8;
            this.txtRegisterGuide.Text = resources.GetString("txtRegisterGuide.Text");
            // 
            // txtNameExistsGuide
            // 
            this.txtNameExistsGuide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameExistsGuide.Location = new System.Drawing.Point(6, 7);
            this.txtNameExistsGuide.MaxLength = 327673344;
            this.txtNameExistsGuide.Multiline = true;
            this.txtNameExistsGuide.Name = "txtNameExistsGuide";
            this.txtNameExistsGuide.ReadOnly = true;
            this.txtNameExistsGuide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNameExistsGuide.Size = new System.Drawing.Size(697, 81);
            this.txtNameExistsGuide.TabIndex = 9;
            this.txtNameExistsGuide.Text = "Enter a name into the text box. Remember to include the namespace, e.g. \"p/\".\r\n\r\n" +
    "Click the Check button to see if the name exists.\r\n\r\nThe results are output in t" +
    "he checkboxes.\r\n\r\n";
            // 
            // lblNameToCheck
            // 
            this.lblNameToCheck.AutoSize = true;
            this.lblNameToCheck.Location = new System.Drawing.Point(6, 97);
            this.lblNameToCheck.Name = "lblNameToCheck";
            this.lblNameToCheck.Size = new System.Drawing.Size(80, 13);
            this.lblNameToCheck.TabIndex = 10;
            this.lblNameToCheck.Text = "Name to check";
            // 
            // chkNameIsMine
            // 
            this.chkNameIsMine.AutoSize = true;
            this.chkNameIsMine.Enabled = false;
            this.chkNameIsMine.Location = new System.Drawing.Point(9, 169);
            this.chkNameIsMine.Name = "chkNameIsMine";
            this.chkNameIsMine.Size = new System.Drawing.Size(15, 14);
            this.chkNameIsMine.TabIndex = 11;
            this.chkNameIsMine.UseVisualStyleBackColor = true;
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::XayaNameUtility.Properties.Resources.ROMx116circleredcancel1;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(92, 22);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Image = global::XayaNameUtility.Properties.Resources.ROMx116gear;
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(116, 22);
            this.tsmiSettings.Text = "&Settings";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Image = global::XayaNameUtility.Properties.Resources.ROMx116circlehelp3;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(199, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiGetTheCodeOnGitHub
            // 
            this.tsmiGetTheCodeOnGitHub.Image = global::XayaNameUtility.Properties.Resources.GitHubMark16px;
            this.tsmiGetTheCodeOnGitHub.Name = "tsmiGetTheCodeOnGitHub";
            this.tsmiGetTheCodeOnGitHub.Size = new System.Drawing.Size(199, 22);
            this.tsmiGetTheCodeOnGitHub.Text = "&Get the code on GitHub";
            this.tsmiGetTheCodeOnGitHub.Click += new System.EventHandler(this.tsmiGetTheCodeOnGitHub_Click);
            // 
            // XayaNameUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.tabUtilities);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(757, 489);
            this.Name = "XayaNameUtility";
            this.Text = "Xaya Name Utility";
            this.Load += new System.EventHandler(this.XayaNameUtility_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XayaNameUtility_KeyDown);
            this.cmsNameListMenu.ResumeLayout(false);
            this.tabUtilities.ResumeLayout(false);
            this.tpCheckNameExists.ResumeLayout(false);
            this.tpCheckNameExists.PerformLayout();
            this.tpBulkRegisterNames.ResumeLayout(false);
            this.tpBulkRegisterNames.PerformLayout();
            this.tpBulkSendNames.ResumeLayout(false);
            this.tpBulkSendNames.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tpGuide.ResumeLayout(false);
            this.tpGuide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckSingleNameExists;
        private System.Windows.Forms.TextBox txtCheckSingleNameExists;
        private System.Windows.Forms.CheckBox chkCheckSingleNameExists;
        private System.Windows.Forms.TextBox txtNameListToCreate;
        private System.Windows.Forms.TextBox txtNameListResults;
        private System.Windows.Forms.Button btnCreateNamesFromList;
        private System.Windows.Forms.TextBox txtChiAddressToSendNamesTo;
        private System.Windows.Forms.TextBox txtWalletNames;
        private System.Windows.Forms.Button btnGetNamesInWallet;
        private System.Windows.Forms.ListView lvNames;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnSendNamesToAddress;
        private System.Windows.Forms.ContextMenuStrip cmsNameListMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiUncheckAll;
        private System.Windows.Forms.TabControl tabUtilities;
        private System.Windows.Forms.TabPage tpCheckNameExists;
        private System.Windows.Forms.TabPage tpBulkRegisterNames;
        private System.Windows.Forms.TabPage tpBulkSendNames;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripComboBox tscbWallets;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabPage tpGuide;
        private System.Windows.Forms.TextBox txtGuide;
        private System.Windows.Forms.TextBox txtNameExistsGuide;
        private System.Windows.Forms.TextBox txtRegisterGuide;
        private System.Windows.Forms.Label lblRegisterNamesResults;
        private System.Windows.Forms.Label lblListOfNamesToRegister;
        private System.Windows.Forms.Label lblChiAddress;
        private System.Windows.Forms.TextBox txtSendGuide;
        private System.Windows.Forms.Label lblNameToCheck;
        private System.Windows.Forms.CheckBox chkNameIsMine;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetTheCodeOnGitHub;
    }
}

