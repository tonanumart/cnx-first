using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Routing;
using Microsoft.Owin;
using Owin;
using Web.App_Start;

[assembly: OwinStartup(typeof(Web.Startup))]

namespace Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = CreateHttpConfiguration();
            AppSeed.RegisterAutoFac(config, app);
            AppSeed.RegisterStaticFile(app);
        }

        private static HttpConfiguration CreateHttpConfiguration()
        {
            var httpConfiguration = new HttpConfiguration();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            WebApiConfig.Register(httpConfiguration); //reuse web api route config with old configuration

            return httpConfiguration;
        }
    }
}
