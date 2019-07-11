using System.Web.Http;
using WebActivatorEx;
using MortageDataSwitch;
using Swashbuckle.Application;
using System;
using System.Net.Http;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace MortageDataSwitch
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger("docs/help/{apiVersion}", c =>
                    {
                        c.RootUrl((req) => req.RequestUri.GetLeftPart(UriPartial.Authority) + req.GetConfiguration().VirtualPathRoot.TrimEnd('/'));

                        c.SingleApiVersion("v1", "Mortage Data Switch");
                        
                        c.IncludeXmlComments($"{System.AppDomain.CurrentDomain.BaseDirectory}bin\\MortageDataSwitch.xml");
                        c.DescribeAllEnumsAsStrings();
                        
                    })
                .EnableSwaggerUi("help/{*assetPath}");
        }
    }
}
