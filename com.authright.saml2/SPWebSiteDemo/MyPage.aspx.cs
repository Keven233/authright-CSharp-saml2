using com.authright.saml2.config;
using com.authright.saml2.Logging;
using com.authright.saml2.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SPWebSiteDemo
{
    public partial class MyPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Title = "My page on SP " + SAML20FederationConfig.GetConfig().ServiceProvider.ID;
            if (Request.QueryString["action"] == "sso")
            {
                // Example of logging required by the requirements BSA6/SSO6 ("Id of internal account that is matched to SAML Assertion")
                // Since FormsAuthentication is used in this sample, the user name to log can be found in context.User.Identity.Name.
                // This user will not be set until after a new redirect, so unfortunately we cannot just log it in our LogAction.LoginAction
                AuditLogging.logEntry(Direction.IN, Operation.LOGIN, "ServiceProvider login",
                                      "SP internal user id: " +
                                      (Context.User.Identity.IsAuthenticated ? Context.User.Identity.Name : "(not logged in)"));
            }
        }

        protected void Btn_Relogin_Click(object sender, EventArgs e)
        {
            Session[Saml20AbstractEndpointHandler.IDPForceAuthn] = true;

            Response.Redirect("/demo/login.ashx");
        }

        protected void Btn_ReloginNoForceAuthn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/demo/login.ashx");
        }

        protected void Btn_Logoff_Click(object sender, EventArgs e)
        {
            // Example of logging required by the requirements SLO1 ("Id of internal account that is matched to SAML Assertion")
            // Since FormsAuthentication is used in this sample, the user name to log can be found in context.User.Identity.Name
            AuditLogging.logEntry(Direction.OUT, Operation.LOGOUTREQUEST, "ServiceProvider logoff requested, local user id: " + HttpContext.Current.User.Identity.Name);
            Response.Redirect("logout.ashx");
        }
    }
}