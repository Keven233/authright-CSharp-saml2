using com.authright.saml2.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using com.authright.saml2;
using com.authright.saml2.Protocol;
using com.authright.saml2.Logging;
using com.authright.saml2.Identity;

namespace SPWebSiteDemo
{
    public class LogAction : IAction
    {
        public string Name
        {
            get { return "LogAction"; }
            set
            {

            }
        }

        public void LoginAction(AbstractEndpointHandler handler, HttpContext context, Saml20Assertion assertion)
        {
  
        }

        public void LogoutAction(AbstractEndpointHandler handler, HttpContext context, bool IdPInitiated)
        {
            AuditLogging.logEntry(Direction.IN, Operation.LOGOUT, "ServiceProvider logout",
                "SP local user id: " + (context.User.Identity.IsAuthenticated ? context.User.Identity.Name : "none") + " login status: " + Saml20Identity.IsInitialized());
        }
    }
}