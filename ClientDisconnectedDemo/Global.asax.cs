using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ClientDisconnectedDemo
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            var context = HttpContext.Current;
            Debug.WriteLine($"{context.Response.StatusCode}:{context.Response.SubStatusCode}:{context.Request.Path}:{context.Request.Url.AbsoluteUri}");
        }
    }
}
