using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayaNameUtility
{
    public class WalletSettings
    {
        public string daemonUrl { get; set; }
        public string walletPassword { get; set; }
        public string rpcUsername { get; set; }
        public string rpcPassword { get; set; }
        public Int16 rpcRequestTimeoutInSeconds { get; set; }
        public string walletName { get; set; }

        public WalletSettings()
        {
            daemonUrl = string.Empty;
            walletName = string.Empty;
            walletPassword = string.Empty;
            rpcPassword = string.Empty;
            rpcUsername = string.Empty;
            rpcRequestTimeoutInSeconds = 60;
        }

        public override string ToString()
        {
            return walletName;
        }
    }
}
