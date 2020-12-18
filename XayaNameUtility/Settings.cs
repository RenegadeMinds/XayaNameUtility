using BitcoinLib.Services.Coins.Base;
using BitcoinLib.Services.Coins.XAYA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XayaNameUtility
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            List<WalletSettings> wallets = Utils.GetWalletSettings();

            if (wallets != null)
            {

                foreach (WalletSettings settings in wallets)
                {
                    ListViewItem lvi = new ListViewItem();

                    lvi.Text = settings.walletName;
                    lvi.SubItems.Add(settings.daemonUrl);
                    lvi.SubItems.Add(settings.rpcUsername);
                    lvi.SubItems.Add(settings.rpcPassword);
                    lvi.SubItems.Add(settings.walletPassword);
                    lvi.SubItems.Add(settings.rpcRequestTimeoutInSeconds.ToString());
                    lvWalletSettings.Items.Add(lvi);

                }
            }
        }

        private void btnAddWalletSettings_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = txtWalletName.Text;
            lvi.SubItems.Add(txtDaemonUrl.Text);
            lvi.SubItems.Add(txtRpcUsername.Text);
            lvi.SubItems.Add(txtRpcPassword.Text);
            lvi.SubItems.Add(txtWalletPassword.Text);
            lvi.SubItems.Add(txtRpcRequestTimeoutInSeconds.Text.ToString());
            lvWalletSettings.Items.Add(lvi);

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string[] rpcPassword = new string[lvWalletSettings.Items.Count];
            string[] rpcUsername = new string[lvWalletSettings.Items.Count];
            short[] rpcRequestTimeoutInSeconds = new short[lvWalletSettings.Items.Count];
            string[] walletName = new string[lvWalletSettings.Items.Count];
            string[] walletPassword = new string[lvWalletSettings.Items.Count];
            string[] daemonUrl = new string[lvWalletSettings.Items.Count];

            int i = 0;

            foreach (ListViewItem item in lvWalletSettings.Items)
            {
                // We should verify that the settings are valid first.
                #region Validate settings work
                ICoinService xayaCoinServiceTest;
                try
                {
                    xayaCoinServiceTest = new XAYAService(/*daemonUrl*/ item.SubItems[1].Text, 
                    /*rpcUsername*/ item.SubItems[2].Text, 
                    /*rpcPassword*/ item.SubItems[3].Text, 
                    /*walletPassword*/ item.SubItems[4].Text, 
                    /*rpcRequestTimeoutInSeconds*/ Convert.ToInt16(item.SubItems[5].Text));

                    decimal balance = xayaCoinServiceTest.GetBalance();
                }
                catch
                {
                    MessageBox.Show("The \"" + item.Text + "\" wallet settings are invalid.\r\n\r\nIf you're trying to load the default (QT) wallet, you must load it using xaya-cli as stated in the guide.", "Invalid Wallet Settings");
                    continue;
                }

                #endregion

                // If the parameters are valid, we then add them to our settings arrays.

                walletName[i] = item.Text;
                daemonUrl[i] = item.SubItems[1].Text;
                rpcUsername[i] = item.SubItems[2].Text;
                rpcPassword[i] = item.SubItems[3].Text;
                walletPassword[i] = item.SubItems[4].Text;
                rpcRequestTimeoutInSeconds[i] = Convert.ToInt16(item.SubItems[5].Text);
                i++; // Increment counter
            }

            // Set the settings and save them.

            Properties.Settings.Default.walletName = walletName;
            Properties.Settings.Default.daemonUrl = daemonUrl;
            Properties.Settings.Default.rpcUsername = rpcUsername;
            Properties.Settings.Default.rpcPassword = rpcPassword;
            Properties.Settings.Default.walletPassword = walletPassword;
            Properties.Settings.Default.rpcRequestTimeoutInSeconds = rpcRequestTimeoutInSeconds;

            Properties.Settings.Default.Save();

        }

        private void btnRemoveWallet_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvWalletSettings.Items)
            {
                if (item.Checked)
                {
                    lvWalletSettings.Items.Remove(item);
                }
            }
        }

        private void lvWalletSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWalletSettings.SelectedItems.Count <= 0)
                return;

            txtWalletName.Text = lvWalletSettings.SelectedItems[0].Text;
            txtDaemonUrl.Text = lvWalletSettings.SelectedItems[0].SubItems[1].Text;
            txtRpcUsername.Text = lvWalletSettings.SelectedItems[0].SubItems[2].Text;
            txtRpcPassword.Text = lvWalletSettings.SelectedItems[0].SubItems[3].Text;
            txtWalletPassword.Text = lvWalletSettings.SelectedItems[0].SubItems[4].Text;
            txtRpcRequestTimeoutInSeconds.Text = lvWalletSettings.SelectedItems[0].SubItems[5].Text;
        }

        private void btnGetCookieUserPass_Click(object sender, EventArgs e)
        {
            GetCookieUserPass();
        }

        private void GetCookieUserPass()
        {
            CookieReader cookieReader = new CookieReader();
            txtRpcUsername.Text = cookieReader.Username;
            txtRpcPassword.Text = cookieReader.Userpassword;
        }


        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show("You are about to reset the wallet settings to the default values.\r\n\r\nYou will need to re-enter the RPC username and password at a minimum.\r\n\r\nThis cannot be undone, but you can re-save the settings in the list here.\r\n\r\nAre you sure that you want to reset the wallet settings?", "Reset Wallet Settings?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
                return;

            Properties.Settings.Default.Reset(); // This deletes everything in the user.config file.
            var path = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;

        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            txtWalletName.Text = "game.dat";
            txtDaemonUrl.Text = "http://localhost:8396/wallet/game.dat";
            GetCookieUserPass();
            txtWalletPassword.Text = string.Empty;
            txtRpcRequestTimeoutInSeconds.Text = "60";
        }

        private void btnVault_Click(object sender, EventArgs e)
        {
            DoDefaults("vault.dat");
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            DoDefaults("wallet.dat");
        }

        private void DoDefaults(string wallet)
        {
            if (!wallet.EndsWith(".dat"))
            {
                wallet += ".dat";
            }

            txtWalletName.Text = wallet;
            txtDaemonUrl.Text = "http://localhost:8396/wallet/" + wallet;
            GetCookieUserPass();
            txtWalletPassword.Text = string.Empty;
            txtRpcRequestTimeoutInSeconds.Text = "60";
        }

    }
}
