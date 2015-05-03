using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class DiscoveryController : Controller
    {
        private const string discoResource = "https://api.office.com/discovery/";
        private const string discoEndpoint = "https://api.office.com/discovery/v1.0/";

        // GET: Discovery
        public ActionResult Index(string code)
        {
            AuthorizationContext authContext = new AuthorizationContext(
                ConfigurationManager.AppSettings["ida:AuthorizationUri"] + "/common", true);

            ClientCredential creds = new ClientCredential(
                ConfigurationManager.AppSettings["ida:ClientID"],
                ConfigurationManager.AppSettings["ida:Password"]);
        }
    }
}