using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace OAuth2.Demo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //从url中获取token的另外一种解决方式
            //if (ReferenceEquals(null, HttpContext.Current.Request.Headers["Authorization"]))
            //{
            //    var token = HttpContext.Current.Request.Params["access_token"];
            //    if (!String.IsNullOrEmpty(token))
            //    {
            //        HttpContext.Current.Request.Headers.Add("Authorization", "Bearer " + token);
            //    }
            //}
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}