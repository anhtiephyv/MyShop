using Microsoft.Owin;
using Owin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.ServiceCollection;
[assembly: OwinStartupAttribute(typeof(Web.Startup))]
namespace Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        public void ConfigurationSerivce(IServiceCollection )
        {
           Applicatio
        }
    }
}
