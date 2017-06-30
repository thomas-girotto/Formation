using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(WebApi.App_Start.Startup))]
namespace WebApi.App_Start
{
    
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var httpConfiguration = new HttpConfiguration();
            var container = ConfigureAutofac();

            WebApiConfig.Register(httpConfiguration);
            appBuilder.UseAutofacMiddleware(container);
            appBuilder.UseAutofacWebApi(httpConfiguration);
            appBuilder.UseWebApi(httpConfiguration);
        }

        private IContainer ConfigureAutofac()
        {
            var containerBuilder = new ContainerBuilder();
            var assembly = Assembly.GetExecutingAssembly();

            containerBuilder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().SingleInstance();
            containerBuilder.RegisterApiControllers(assembly);

            return containerBuilder.Build();
        }
    }
}