using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Http.Filters;

namespace MortageDataSwitch.Controllers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class SecurityAuthenticationFilter : AuthorizationFilterAttribute
    {
        private string channelUsername = "3D071789-F701-43D4-AB49-98BC0B63F82B";
        private string channelPassword = "90309592-5AB2-46F0-89AC-1CF5DAF38E75";
        bool Active = true;

        //TODO: register callback handlers: https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/basic-authentication
        public SecurityAuthenticationFilter()
        {
            

        }

        /// <summary>
        /// Overriden constructor to allow explicit disabling of this
        /// filter's behavior. Pass false to disable (same as no filter
        /// but declarative)
        /// </summary>
        /// <param name="active"></param>
        public SecurityAuthenticationFilter(bool active)
        {
            Active = active;
        }

        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            var whiteListIps = WebConfigurationManager.AppSettings["WhiteListIp"];

            var ips = whiteListIps.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if(ips.Count > 0 && !ips.Contains("*"))
            {
                var ipFound = false;

                foreach(var ip in ips)
                {
                    if(actionContext.Request.Headers.Host.Contains(ip))
                    {
                        ipFound = true;
                        break;
                    }
                }

                if(!ipFound)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                    return;
                }
            }
            

            AuthenticationHeaderValue header = actionContext.Request.Headers.Authorization;

            if (header != null)
            {
                var basic = header.Parameter;

                var encoding = Encoding.GetEncoding("iso-8859-1");
                var authCredentials = encoding.GetString(Convert.FromBase64String(basic));

                int separator = authCredentials.IndexOf(':');
                string authname = authCredentials.Substring(0, separator);
                string authpassword = authCredentials.Substring(separator + 1);

                if ((authname != channelUsername) || (authpassword != channelPassword))
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
            else
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
        }

        /// <summary>
        /// Base implementation for user authentication - you probably will
        /// want to override this method for application specific logic.
        /// 
        /// The base implementation merely checks for username and password
        /// present and set the Thread principal.
        /// 
        /// Override this method if you want to customize Authentication
        /// and store user data as needed in a Thread Principle or other
        /// Request specific storage.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        protected virtual bool OnAuthorizeUser(string username, string password, System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            AuthenticationHeaderValue header = actionContext.Request.Headers.Authorization;
            var basic = header.Parameter;

            var encoding = Encoding.GetEncoding("iso-8859-1");
            var authCredentials = encoding.GetString(Convert.FromBase64String(basic));

            int separator = authCredentials.IndexOf(':');
            string authname = authCredentials.Substring(0, separator);
            string authpassword = authCredentials.Substring(separator + 1);

            if ((authname != channelUsername) || (authpassword != channelPassword))
            {
                HttpContext.Current.Response.StatusCode = 401;
                throw new HttpException(401, "Unauthorized");
            }

            return true;
        }

       
    }
}