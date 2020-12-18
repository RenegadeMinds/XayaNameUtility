using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitcoinLib;
using BitcoinLib.Services.Coins.Base;
using BitcoinLib.Services.Coins.XAYA;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XayaNameUtility
{
    public partial class XayaNameUtility : Form
    {
        public XayaNameUtility()
        {
            InitializeComponent();
        }

        // Instantiate our XAYA coin service.
        private static ICoinService xayaCoinService;
        // Should do it as an array of wallets. Add in multi-wallet functionality later.
        private static ICoinService[] xayaCoinServices;
        string daemonUrl, rpcUsername, rpcPassword, walletPassword;
        short rpcRequestTimeoutInSeconds;

        private void XayaNameUtility_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S )
            {
                OpenSettings();
            }
        }

        private void OpenSettings()
        {
            string returnToWalletName = tscbWallets.ComboBox.Text;
            Settings settings = new Settings();
            settings.ShowDialog();
            tscbWallets.ComboBox.Items.Clear();
            PopulateWalletComboBox(returnToWalletName);
        }

        private bool IsWalletLoaded(WalletSettings wallet)
        {
            bool isLoaded = false;

            try
            {
                BitcoinLib.Responses.GetWalletInfoResponse r = xayaCoinService.GetWalletInfo();
                isLoaded = true;
            }
            catch
            {
                // xayaCoinService.ImportWallet
            }

            return isLoaded;
        }

        private void btnGetNamesInWallet_Click(object sender, EventArgs e)
        {
            bool b = IsWalletLoaded(null);


            List<BitcoinLib.Responses.GetNameListResponse> r = xayaCoinService.GetNameList();
            StringBuilder sb = new StringBuilder();
            lvNames.Items.Clear();
            foreach (var v in r)
            {
                if (v.ismine == true) // Only display them if we own them.
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = v.name;
                    lvNames.Items.Add(lvi);
                    sb.AppendLine(v.name);
                }
                else
                {
                    Console.WriteLine("We don't own " + v.name);
                }
            }

            txtWalletNames.Text = sb.ToString();
        }

        private void btnSendNamesToAddress_Click(object sender, EventArgs e)
        {
            BitcoinLib.Responses.ValidateAddressResponse validate = xayaCoinService.ValidateAddress(txtChiAddressToSendNamesTo.Text);

            if (validate.IsValid)
            {
                foreach (ListViewItem item in lvNames.Items)
                {
                    if (item.Checked)
                    {
                        Console.WriteLine(item.Text);
                        // Send names to address
                        JObject job = new JObject();
                        job["destAddress"] = txtChiAddressToSendNamesTo.Text;

                        string result = xayaCoinService.NameUpdate(item.Text, "{}", job);
                        Console.WriteLine(result);
                    }
                }
            }
        }

        private void tsmiCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvNames.Items) { item.Checked = true; }
        }

        private void tsmiUncheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvNames.Items) { item.Checked = false; }
        }

        private void XayaNameUtility_Load(object sender, EventArgs e)
        {
            
            // This is to just be able to close the wallet and not have to do any reconfig.
            // That is, we'll always have the correct password even across restarts.
            CookieReader cookie = new CookieReader();
            Console.WriteLine("Username = " + cookie.Username);
            Console.WriteLine("Userpassword = " + cookie.Userpassword);

            // daemonUrl, rpcUsername, rpcPassword, walletPassword, rpcRequestTimeoutInSeconds
            daemonUrl = ConfigurationManager.AppSettings["XAYA_DaemonUrl"]; //  + "/wallet/game.dat";
            rpcUsername = cookie.Username; //  ConfigurationManager.AppSettings["XAYA_RpcUsername"]; //
            rpcPassword = cookie.Userpassword; //  ConfigurationManager.AppSettings["XAYA_RpcPassword"]; //
            walletPassword = ConfigurationManager.AppSettings["XAYA_WalletPassword"];
            rpcRequestTimeoutInSeconds = 60;

            //daemonUrl = "http://localhost:8396/wallet/game.dat";
            //rpcUsername = "__cookie__";
            //rpcPassword = "b5acfa36d8b32edc45a94d31ad50062f832b77cccad35b94528e09833c36e502";
            //walletPassword = "MyWalletPassword";
            //rpcRequestTimeoutInSeconds = 60;

            xayaCoinService = new XAYAService(daemonUrl, rpcUsername, rpcPassword, walletPassword, rpcRequestTimeoutInSeconds);
            
            this.Text = xayaCoinService.GetBlockCount().ToString();

            foreach (var v in xayaCoinService.GetPeerInfo())
            {
                Console.WriteLine(v.Version);
            }

            // Load wallet settings into combobox
            PopulateWalletComboBox(string.Empty);

        }

        private void tscbWallets_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<WalletSettings> wallets = Utils.GetWalletSettings();

            foreach (WalletSettings wallet in wallets)
            {
                if (wallet.walletName == tscbWallets.ComboBox.Text)
                {
                    // this is the wallet we want to use.
                    try
                    {
                        xayaCoinService = new XAYAService(wallet.daemonUrl,
                            wallet.rpcUsername,
                            wallet.rpcPassword,
                            wallet.walletPassword,
                            wallet.rpcRequestTimeoutInSeconds);
                        this.Text = tscbWallets.Text +  " wallet balance: " + string.Format("{0:0,0.00000000}", xayaCoinService.GetBalance()).ToString();
                    }
                    catch
                    {
                        this.Text = "Failed to load default wallet.";
                        MessageBox.Show("Failed to load default wallet. \r\n\r\nMake corrections in settings & try again. \r\n\r\n(Probably username & password are wrong or blank.)");
                    }
                }
            }
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiGetTheCodeOnGitHub_Click(object sender, EventArgs e)
        {
            // https://github.com/RenegadeMinds/XayaNameUtility
            System.Diagnostics.Process.Start("https://github.com/RenegadeMinds/XayaNameUtility");
        }

        private void btnATTACK_Click(object sender, EventArgs e)
        {
            CancelAttack = false;
            Thread thread = new Thread(new ThreadStart(FindPassword));
            thread.Start();
        }

        public void FindPassword()
        {
            // We're going to use an address for testing below. This gets an address with coins in it. 
            List<List<BitcoinLib.Responses.ListAddressGroupingsResponse>> listAddressGroupings = xayaCoinService.ListAddressGroupings();

            string address = string.Empty;

            foreach (var v in listAddressGroupings)
            {
                foreach (var a in v)
                {
                    if (a.Balance > 0)
                    {
                        address = a.Address;
                        break;
                    }
                }
                if (address != string.Empty)
                    break;
            }

            // possible to stop if there are no coins in the wallet

            // Create a unique file name for the wallet dump test if you want to use that method
            // string dumpfile = "Dump file test - " + DateTime.Now.Ticks.ToString();
            // Create a string to hold the private key for the address we got above. 
            // This is for testing to see if we got the password right.
            string privatekey = string.Empty;

            // Create a string for a file name. We'll write the password to that file if we find it.
            string found_password_file = "XAYA PASSWORD FOUND - " + DateTime.Now.Ticks.ToString() + "- xaya.txt";

            // Keep track of time
            Stopwatch s = Stopwatch.StartNew();
            long previous_elapsed_time = 0;
            long current_elapsed_time = 0;

            foreach (string password in txtDictionary.Lines)
            {
                if (CancelAttack)
                    break;

                current_elapsed_time = s.ElapsedMilliseconds;

                // Try the password
                string result = xayaCoinService.WalletPassphrase(password, 10000000);
                // We need to test to see if the password actually unlocked the wallet. 
                // There is no actual method for this, so we use another method to see if it worked,
                // and if it worked, then the wallet is unlocked.
                // If it didn't work, the wallet is still locked. 
                privatekey = xayaCoinService.DumpPrivKey(address);

                this.SafeInvoke(d => d.UpdatePasswordFinding( password + "\t" + result + " (" + current_elapsed_time.ToString() + "s :: +" + (current_elapsed_time - previous_elapsed_time).ToString() + "s)" + Environment.NewLine ));
                if (privatekey != null && privatekey != string.Empty)
                {
                    // We've got it! We found the password!
                    File.WriteAllText(found_password_file, password);
                    this.SafeInvoke(d => d.UpdatePasswordFinding( "FOUND THE PASSWORD! It is: " + password + Environment.NewLine + "Your password is saved in the '" + found_password_file + "' file. It is located in the same folder as this program. " + Environment.NewLine ));
                    // Stop processing at this point.
                    break;
                }
                previous_elapsed_time = current_elapsed_time;
            }

            s.Stop();

            this.SafeInvoke(d => d.UpdatePasswordFinding("Finished in " + s.ElapsedMilliseconds.ToString() + "s"));

        }

        public void UpdatePasswordFinding(string text)
        {
            txtAttackResults.Text += text;
            txtAttackResults.SelectionStart = txtAttackResults.Text.Length - 1;
            txtAttackResults.ScrollToCaret();
        }

        bool CancelAttack = false;

        private void btnCancelAttack_Click(object sender, EventArgs e)
        {
            CancelAttack = !CancelAttack;
        }

        private void PopulateWalletComboBox(string returnToWalletName)
        {
            // Load wallet settings into combobox
            string[] walletName = Properties.Settings.Default.walletName;

            for (int i = 0; i < walletName.Length; i++)
            {
                WalletSettings walletSettings = new WalletSettings();

                walletSettings.walletName = Properties.Settings.Default.walletName[i];
                walletSettings.daemonUrl = Properties.Settings.Default.daemonUrl[i];
                walletSettings.rpcUsername = Properties.Settings.Default.rpcUsername[i];
                walletSettings.rpcPassword = Properties.Settings.Default.rpcPassword[i];
                walletSettings.walletPassword = Properties.Settings.Default.walletPassword[i];
                walletSettings.rpcRequestTimeoutInSeconds = Properties.Settings.Default.rpcRequestTimeoutInSeconds[i];

                if (walletSettings.walletName == null || walletSettings.daemonUrl == null)
                {
                    continue;
                }

                tscbWallets.ComboBox.Items.Add(walletSettings);
            }
            if (returnToWalletName == string.Empty)
            {
                if (tscbWallets.ComboBox.Items.Count > 0)
                    tscbWallets.ComboBox.SelectedIndex = 0; // 2020-03-26 - fixed for null errors.
            }
            else
            {
                try
                {
                    int index = tscbWallets.ComboBox.FindStringExact(returnToWalletName);
                    if (index < 0) { index = 0; }
                    tscbWallets.ComboBox.SelectedIndex = index;
                }
                catch
                {
                    if (tscbWallets.Items.Count > 0)
                    {
                        tscbWallets.ComboBox.SelectedIndex = 0;
                    }
                    else
                    {
                        tscbWallets.Items.Add("NO WALLETS SET");
                    }
                }
            }

        }

        private void btnCheckSingleNameExists_Click(object sender, EventArgs e)
        {
            BitcoinLib.Responses.GetShowNameResponse r = xayaCoinService.ShowName(txtCheckSingleNameExists.Text);

            if (r == null)
            {
                chkCheckSingleNameExists.Checked = false;
                chkCheckSingleNameExists.Text = "Does not exist";
                chkNameIsMine.Checked = false;
                chkNameIsMine.Text = "This name is available to buy.";
            }
            else
            {
                chkCheckSingleNameExists.Checked = true;
                chkCheckSingleNameExists.Text = "Exists";
                if (r.ismine)
                {
                    chkNameIsMine.Checked = true;
                    chkNameIsMine.Text = "This name belongs to me in the " + tscbWallets.Text + " wallet.";
                }
                else
                {
                    chkNameIsMine.Checked = false;
                    chkNameIsMine.Text = "This name is not in the " + tscbWallets.Text + " wallet.";
                }
            }
        }


        private void btnCreateNamesFromList_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string line in txtNameListToCreate.Lines)
            {
                BitcoinLib.Responses.GetShowNameResponse r = xayaCoinService.ShowName(line);
                if (r == null)
                {
                    if (line.Length <3)
                    {
                        // All names must have a namespace and should be at least 1 character in length,
                        // so the minimum number of characters is 3. 
                        continue;
                    }
                    // Create the name because it doesn't exist.
                    string result = xayaCoinService.RegisterName(line, "{}", new object());
                    if (result == "Failed.")
                    { sb.AppendLine("\"" + line + "\" failed to register. " + result); }
                    else
                    {
                        if (result != string.Empty && result != null)
                        {
                            sb.AppendLine("\"" + line + "\" registered successfully. " + result);
                        }
                        else
                        { sb.AppendLine("\"" + line + "\" Failed for one reason or another, e.g. too many transactions, wallet is locked, couldn't submit more, etc. " + result); }
                    }
                }
                else
                {
                    // The name exists, so output that it is already taken.
                    sb.AppendLine("\"" + r.name + "\" already exists.");
                }

            }
            txtNameListResults.Text = sb.ToString();
        }



    }
}
