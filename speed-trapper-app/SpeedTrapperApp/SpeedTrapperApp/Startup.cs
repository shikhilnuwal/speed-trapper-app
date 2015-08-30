using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpeedTrapperApp.Startup))]
namespace SpeedTrapperApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            var configuration = new HubConfiguration();
            configuration.EnableJSONP = true;
            configuration.EnableDetailedErrors = true;
            app.MapSignalR(configuration);
        }
    }
}
