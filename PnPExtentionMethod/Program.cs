using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
//using OfficeDevPnP.Core;

namespace PnPExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            SecureString password = new SecureString();

            using(var ctx = new ClientContext(""))
            {
                ctx.Credentials = new SharePointOnlineCredentials(userName, password);
                var list = ctx.Web.Lists[0];
            }
        }
    }
}
