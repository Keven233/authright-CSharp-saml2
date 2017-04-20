using com.authright.saml2.config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SPWebSiteDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected bool certificateMissing;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                FederationConfig.GetConfig().SigningCertificate.GetCertificate();
                certificateMissing = false; // GetCertificate() throws an exception when the certificate can not be retrieved.
            }
            catch (ConfigurationErrorsException)
            {
                certificateMissing = true;
            }
        }
    }
}