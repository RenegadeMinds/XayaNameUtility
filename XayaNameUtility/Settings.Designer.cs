namespace XayaNameUtility
{
    partial class Settings
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
            this.lblDaemonUrl = new System.Windows.Forms.Label();
            this.txtDaemonUrl = new System.Windows.Forms.TextBox();
            this.txtWalletName = new System.Windows.Forms.TextBox();
            this.lblWalletName = new System.Windows.Forms.Label();
            this.txtRpcUsername = new System.Windows.Forms.TextBox();
            this.rpcUsername = new System.Windows.Forms.Label();
            this.txtRpcPassword = new System.Windows.Forms.TextBox();
            this.lblRpcPassword = new System.Windows.Forms.Label();
            this.txtWalletPassword = new System.Windows.Forms.TextBox();
            this.lblWalletPassword = new System.Windows.Forms.Label();
            this.txtRpcRequestTimeoutInSeconds = new System.Windows.Forms.TextBox();
            this.lblRpcRequestTimeoutInSeconds = new System.Windows.Forms.Label();
            this.btnAddWalletSettings = new System.Windows.Forms.Button();
            this.lvWalletSettings = new System.Windows.Forms.ListView();
            this.chWalletName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDaemonUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWalletRpcUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRpcPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWalletPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRpcRequestTimeoutInSeconds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnRemoveWallet = new System.Windows.Forms.Button();
            this.btnGetCookieUserPass = new System.Windows.Forms.Button();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.btnCloseSettings = new System.Windows.Forms.Button();
            this.gbxAutoFix = new System.Windows.Forms.GroupBox();
            this.btnWallet = new System.Windows.Forms.Button();
            this.btnVault = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.gbxAutoFix.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDaemonUrl
            // 
            this.lblDaemonUrl.AutoSize = true;
            this.lblDaemonUrl.Location = new System.Drawing.Point(12, 41);
            this.lblDaemonUrl.Name = "lblDaemonUrl";
            this.lblDaemonUrl.Size = new System.Drawing.Size(72, 13);
            this.lblDaemonUrl.TabIndex = 0;
            this.lblDaemonUrl.Text = "Daemon URL";
            // 
            // txtDaemonUrl
            // 
            this.txtDaemonUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDaemonUrl.Location = new System.Drawing.Point(176, 38);
            this.txtDaemonUrl.Name = "txtDaemonUrl";
            this.txtDaemonUrl.Size = new System.Drawing.Size(546, 20);
            this.txtDaemonUrl.TabIndex = 1;
            // 
            // txtWalletName
            // 
            this.txtWalletName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWalletName.Location = new System.Drawing.Point(176, 12);
            this.txtWalletName.Name = "txtWalletName";
            this.txtWalletName.Size = new System.Drawing.Size(546, 20);
            this.txtWalletName.TabIndex = 3;
            // 
            // lblWalletName
            // 
            this.lblWalletName.AutoSize = true;
            this.lblWalletName.Location = new System.Drawing.Point(12, 15);
            this.lblWalletName.Name = "lblWalletName";
            this.lblWalletName.Size = new System.Drawing.Size(66, 13);
            this.lblWalletName.TabIndex = 2;
            this.lblWalletName.Text = "Wallet name";
            // 
            // txtRpcUsername
            // 
            this.txtRpcUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRpcUsername.Location = new System.Drawing.Point(176, 64);
            this.txtRpcUsername.Name = "txtRpcUsername";
            this.txtRpcUsername.Size = new System.Drawing.Size(315, 20);
            this.txtRpcUsername.TabIndex = 5;
            // 
            // rpcUsername
            // 
            this.rpcUsername.AutoSize = true;
            this.rpcUsername.Location = new System.Drawing.Point(12, 67);
            this.rpcUsername.Name = "rpcUsername";
            this.rpcUsername.Size = new System.Drawing.Size(78, 13);
            this.rpcUsername.TabIndex = 4;
            this.rpcUsername.Text = "RPC username";
            // 
            // txtRpcPassword
            // 
            this.txtRpcPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRpcPassword.Location = new System.Drawing.Point(176, 90);
            this.txtRpcPassword.Name = "txtRpcPassword";
            this.txtRpcPassword.Size = new System.Drawing.Size(315, 20);
            this.txtRpcPassword.TabIndex = 7;
            // 
            // lblRpcPassword
            // 
            this.lblRpcPassword.AutoSize = true;
            this.lblRpcPassword.Location = new System.Drawing.Point(12, 93);
            this.lblRpcPassword.Name = "lblRpcPassword";
            this.lblRpcPassword.Size = new System.Drawing.Size(77, 13);
            this.lblRpcPassword.TabIndex = 6;
            this.lblRpcPassword.Text = "RPC password";
            // 
            // txtWalletPassword
            // 
            this.txtWalletPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWalletPassword.Location = new System.Drawing.Point(176, 116);
            this.txtWalletPassword.Name = "txtWalletPassword";
            this.txtWalletPassword.Size = new System.Drawing.Size(546, 20);
            this.txtWalletPassword.TabIndex = 9;
            // 
            // lblWalletPassword
            // 
            this.lblWalletPassword.AutoSize = true;
            this.lblWalletPassword.Location = new System.Drawing.Point(12, 119);
            this.lblWalletPassword.Name = "lblWalletPassword";
            this.lblWalletPassword.Size = new System.Drawing.Size(85, 13);
            this.lblWalletPassword.TabIndex = 8;
            this.lblWalletPassword.Text = "Wallet password";
            // 
            // txtRpcRequestTimeoutInSeconds
            // 
            this.txtRpcRequestTimeoutInSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRpcRequestTimeoutInSeconds.Location = new System.Drawing.Point(176, 142);
            this.txtRpcRequestTimeoutInSeconds.Name = "txtRpcRequestTimeoutInSeconds";
            this.txtRpcRequestTimeoutInSeconds.Size = new System.Drawing.Size(546, 20);
            this.txtRpcRequestTimeoutInSeconds.TabIndex = 11;
            this.txtRpcRequestTimeoutInSeconds.Text = "60";
            // 
            // lblRpcRequestTimeoutInSeconds
            // 
            this.lblRpcRequestTimeoutInSeconds.AutoSize = true;
            this.lblRpcRequestTimeoutInSeconds.Location = new System.Drawing.Point(12, 145);
            this.lblRpcRequestTimeoutInSeconds.Name = "lblRpcRequestTimeoutInSeconds";
            this.lblRpcRequestTimeoutInSeconds.Size = new System.Drawing.Size(158, 13);
            this.lblRpcRequestTimeoutInSeconds.TabIndex = 10;
            this.lblRpcRequestTimeoutInSeconds.Text = "RPC request timeout in seconds";
            // 
            // btnAddWalletSettings
            // 
            this.btnAddWalletSettings.Location = new System.Drawing.Point(15, 179);
            this.btnAddWalletSettings.Name = "btnAddWalletSettings";
            this.btnAddWalletSettings.Size = new System.Drawing.Size(431, 23);
            this.btnAddWalletSettings.TabIndex = 12;
            this.btnAddWalletSettings.Text = "Add Wallet";
            this.btnAddWalletSettings.UseVisualStyleBackColor = true;
            this.btnAddWalletSettings.Click += new System.EventHandler(this.btnAddWalletSettings_Click);
            // 
            // lvWalletSettings
            // 
            this.lvWalletSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvWalletSettings.CheckBoxes = true;
            this.lvWalletSettings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWalletName,
            this.chDaemonUrl,
            this.chWalletRpcUsername,
            this.chRpcPassword,
            this.chWalletPassword,
            this.chRpcRequestTimeoutInSeconds});
            this.lvWalletSettings.FullRowSelect = true;
            this.lvWalletSettings.GridLines = true;
            this.lvWalletSettings.HideSelection = false;
            this.lvWalletSettings.Location = new System.Drawing.Point(15, 208);
            this.lvWalletSettings.MultiSelect = false;
            this.lvWalletSettings.Name = "lvWalletSettings";
            this.lvWalletSettings.Size = new System.Drawing.Size(866, 128);
            this.lvWalletSettings.TabIndex = 13;
            this.lvWalletSettings.UseCompatibleStateImageBehavior = false;
            this.lvWalletSettings.View = System.Windows.Forms.View.Details;
            this.lvWalletSettings.SelectedIndexChanged += new System.EventHandler(this.lvWalletSettings_SelectedIndexChanged);
            // 
            // chWalletName
            // 
            this.chWalletName.Text = "Wallet name";
            this.chWalletName.Width = 78;
            // 
            // chDaemonUrl
            // 
            this.chDaemonUrl.Text = "Daemon URL";
            this.chDaemonUrl.Width = 85;
            // 
            // chWalletRpcUsername
            // 
            this.chWalletRpcUsername.Text = "RPC username";
            this.chWalletRpcUsername.Width = 92;
            // 
            // chRpcPassword
            // 
            this.chRpcPassword.Text = "RPC password";
            this.chRpcPassword.Width = 95;
            // 
            // chWalletPassword
            // 
            this.chWalletPassword.Text = "Wallet password";
            this.chWalletPassword.Width = 98;
            // 
            // chRpcRequestTimeoutInSeconds
            // 
            this.chRpcRequestTimeoutInSeconds.Text = "RPC request timeout";
            this.chRpcRequestTimeoutInSeconds.Width = 128;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.Location = new System.Drawing.Point(12, 342);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(635, 23);
            this.btnSaveSettings.TabIndex = 14;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnRemoveWallet
            // 
            this.btnRemoveWallet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveWallet.Location = new System.Drawing.Point(452, 179);
            this.btnRemoveWallet.Name = "btnRemoveWallet";
            this.btnRemoveWallet.Size = new System.Drawing.Size(431, 23);
            this.btnRemoveWallet.TabIndex = 15;
            this.btnRemoveWallet.Text = "Remove Checked Wallet(s)";
            this.btnRemoveWallet.UseVisualStyleBackColor = true;
            this.btnRemoveWallet.Click += new System.EventHandler(this.btnRemoveWallet_Click);
            // 
            // btnGetCookieUserPass
            // 
            this.btnGetCookieUserPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetCookieUserPass.Location = new System.Drawing.Point(497, 62);
            this.btnGetCookieUserPass.Name = "btnGetCookieUserPass";
            this.btnGetCookieUserPass.Size = new System.Drawing.Size(225, 48);
            this.btnGetCookieUserPass.TabIndex = 16;
            this.btnGetCookieUserPass.Text = "Get RPC Username and Password from .cookie File";
            this.btnGetCookieUserPass.UseVisualStyleBackColor = true;
            this.btnGetCookieUserPass.Click += new System.EventHandler(this.btnGetCookieUserPass_Click);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSettings.Location = new System.Drawing.Point(653, 342);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(228, 23);
            this.btnResetSettings.TabIndex = 17;
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // btnCloseSettings
            // 
            this.btnCloseSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSettings.Location = new System.Drawing.Point(12, 374);
            this.btnCloseSettings.Name = "btnCloseSettings";
            this.btnCloseSettings.Size = new System.Drawing.Size(869, 23);
            this.btnCloseSettings.TabIndex = 18;
            this.btnCloseSettings.Text = "Close Settings";
            this.btnCloseSettings.UseVisualStyleBackColor = true;
            this.btnCloseSettings.Click += new System.EventHandler(this.btnCloseSettings_Click);
            // 
            // gbxAutoFix
            // 
            this.gbxAutoFix.Controls.Add(this.btnWallet);
            this.gbxAutoFix.Controls.Add(this.btnVault);
            this.gbxAutoFix.Controls.Add(this.btnGame);
            this.gbxAutoFix.Location = new System.Drawing.Point(728, 15);
            this.gbxAutoFix.Name = "gbxAutoFix";
            this.gbxAutoFix.Size = new System.Drawing.Size(155, 147);
            this.gbxAutoFix.TabIndex = 19;
            this.gbxAutoFix.TabStop = false;
            this.gbxAutoFix.Text = "Autogenerate Defaults";
            // 
            // btnWallet
            // 
            this.btnWallet.Location = new System.Drawing.Point(6, 84);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Size = new System.Drawing.Size(143, 23);
            this.btnWallet.TabIndex = 2;
            this.btnWallet.Text = "QT wallet defaults";
            this.btnWallet.UseVisualStyleBackColor = true;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // btnVault
            // 
            this.btnVault.Location = new System.Drawing.Point(6, 55);
            this.btnVault.Name = "btnVault";
            this.btnVault.Size = new System.Drawing.Size(143, 23);
            this.btnVault.TabIndex = 1;
            this.btnVault.Text = "Vault defaults";
            this.btnVault.UseVisualStyleBackColor = true;
            this.btnVault.Click += new System.EventHandler(this.btnVault_Click);
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(6, 26);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(143, 23);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "Game defaults";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 409);
            this.Controls.Add(this.gbxAutoFix);
            this.Controls.Add(this.btnCloseSettings);
            this.Controls.Add(this.btnResetSettings);
            this.Controls.Add(this.btnGetCookieUserPass);
            this.Controls.Add(this.btnRemoveWallet);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.lvWalletSettings);
            this.Controls.Add(this.btnAddWalletSettings);
            this.Controls.Add(this.txtRpcRequestTimeoutInSeconds);
            this.Controls.Add(this.lblRpcRequestTimeoutInSeconds);
            this.Controls.Add(this.txtWalletPassword);
            this.Controls.Add(this.lblWalletPassword);
            this.Controls.Add(this.txtRpcPassword);
            this.Controls.Add(this.lblRpcPassword);
            this.Controls.Add(this.txtRpcUsername);
            this.Controls.Add(this.rpcUsername);
            this.Controls.Add(this.txtWalletName);
            this.Controls.Add(this.lblWalletName);
            this.Controls.Add(this.txtDaemonUrl);
            this.Controls.Add(this.lblDaemonUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gbxAutoFix.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaemonUrl;
        private System.Windows.Forms.TextBox txtDaemonUrl;
        private System.Windows.Forms.TextBox txtWalletName;
        private System.Windows.Forms.Label lblWalletName;
        private System.Windows.Forms.TextBox txtRpcUsername;
        private System.Windows.Forms.Label rpcUsername;
        private System.Windows.Forms.TextBox txtRpcPassword;
        private System.Windows.Forms.Label lblRpcPassword;
        private System.Windows.Forms.TextBox txtWalletPassword;
        private System.Windows.Forms.Label lblWalletPassword;
        private System.Windows.Forms.TextBox txtRpcRequestTimeoutInSeconds;
        private System.Windows.Forms.Label lblRpcRequestTimeoutInSeconds;
        private System.Windows.Forms.Button btnAddWalletSettings;
        private System.Windows.Forms.ListView lvWalletSettings;
        private System.Windows.Forms.ColumnHeader chWalletName;
        private System.Windows.Forms.ColumnHeader chDaemonUrl;
        private System.Windows.Forms.ColumnHeader chWalletRpcUsername;
        private System.Windows.Forms.ColumnHeader chRpcPassword;
        private System.Windows.Forms.ColumnHeader chWalletPassword;
        private System.Windows.Forms.ColumnHeader chRpcRequestTimeoutInSeconds;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnRemoveWallet;
        private System.Windows.Forms.Button btnGetCookieUserPass;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.Button btnCloseSettings;
        private System.Windows.Forms.GroupBox gbxAutoFix;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnVault;
        private System.Windows.Forms.Button btnWallet;
    }
}