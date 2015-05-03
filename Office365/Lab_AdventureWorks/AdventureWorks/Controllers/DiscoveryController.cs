using Microsoft.IdentityModel.Clients.ActiveDirectory;
using SalesClient.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorks.Controllers
{
    public class DiscoveryController : Controller
    {
        private const string discoResource = "https://api.office.com/discovery/";
        private const string discoEndpoint = "https://api.office.com/discovery/v1.0/me/";

        // GET: Discovery
        public ActionResult Index(string code)
        {
            // Where do we send auth requests to?
            AuthenticationContext authContext = new AuthenticationContext(
                  ConfigurationManager.AppSettings["ida:AuthorizationUri"] + "/common",
                  true);

            // wrapper for the ip and password for this applicaiton
            ClientCredential creds = new ClientCredential(
                ConfigurationManager.AppSettings["ida:ClientID"],
                ConfigurationManager.AppSettings["ida:Password"]);

            Uri redirectUri = authContext.GetAuthorizationRequestURL(
                discoResource, // Where the discovery service is
                creds.ClientId, // This identifies the application
                new Uri(Request.Url.AbsoluteUri.Split('?')[0]), // Redirect URL
                UserIdentifier.AnyUser,
                string.Empty);

            return Redirect(redirectUri.ToString()); // Redirect to the login page



            List<ViewDiscovery> discoveries = new List<ViewDiscovery>(){
                new ViewDiscovery(){
                    Capability = "Contacts",
                    EndpointUri = contactsDisco.ServiceEndpointUri.OriginalString,
                    ResourceId = contactsDisco.ServiceResourceId,
                    Version = contactsDisco.ServiceApiVersion
                },
                new ViewDiscovery(){
                    Capability = "My Files",
                    EndpointUri = filesDisco.ServiceEndpointUri.OriginalString,
                    ResourceId = filesDisco.ServiceApiVersion
                }
            };

            return View(discoveries);
        }

    }
}