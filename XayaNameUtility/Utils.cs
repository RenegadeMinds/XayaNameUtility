using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayaNameUtility
{
    public static class Utils
    {
        /// <summary>
        /// XAYA: Returns whether or not a name is valid.
        /// </summary>
        /// <param name="name">The name including the namespace.</param>
        /// <param name="XAYAnamespace">Optional. The namespace to check in, e.g. "p/" for a player name or for a game name, "g/".</param>
        /// <returns>True if the name is valid. False if the name is not valid.</returns>
        public static bool IsValidName(string name, string XAYAnamespace = "p/")
        {
            bool result = false;
            if (XAYAnamespace.Length != 2 && !XAYAnamespace.EndsWith("/"))
            {
                // All namespaces must be 1 character and 1 "/".
                // Namespaces must use a lower case a-z character. We're not checking for that here though.
                return false;
            }

            if (name.StartsWith(XAYAnamespace) && name.Length >= 3 && name.Length < 255)
            {
                // If the above tests pass, then we have a valid name.
                // Should check on the maximum length though...
                return true;
            }
            // This is merely a catch all. 
            return result;
        } // End IsValidName


        /// <summary>
        /// XAYA: Returns whether or not a string is valid JSON. 
        /// From https://stackoverflow.com/questions/14977848/how-to-make-sure-that-string-is-valid-json-using-json-net
        /// </summary>
        /// <param name="strInput">The string to check.</param>
        /// <returns>True for valid JSON or false for invalid JSON.</returns>
        public static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        } // End IsValidJson

        public static List<WalletSettings> GetWalletSettings()
        {
            List<WalletSettings> wallets = new List<WalletSettings>();
            WalletSettings temp = new WalletSettings();

            string[] rpcPassword = Properties.Settings.Default.rpcPassword;
            string[] rpcUsername = Properties.Settings.Default.rpcUsername;
            short[]  rpcRequestTimeoutInSeconds = Properties.Settings.Default.rpcRequestTimeoutInSeconds;
            string[] walletName = Properties.Settings.Default.walletName;
            string[] walletPassword = Properties.Settings.Default.walletPassword;
            string[] daemonUrl = Properties.Settings.Default.daemonUrl;

            if (rpcPassword == null)
                return null;

            int count = rpcPassword.Length;

            for (int i = 0; i < count; i++)
            {
                temp = new WalletSettings();
                temp.rpcPassword = rpcPassword[i];
                temp.rpcRequestTimeoutInSeconds = rpcRequestTimeoutInSeconds[i];
                temp.rpcUsername = rpcUsername[i];
                temp.walletName = walletName[i];
                temp.walletPassword = walletPassword[i];
                temp.daemonUrl = daemonUrl[i];

                wallets.Add(temp);
            }

            return wallets;
        }


    }
}
