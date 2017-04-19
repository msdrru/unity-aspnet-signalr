using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Unity.SignalR.WebApplication.Startup))]

namespace Unity.SignalR.WebApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var hubConfiguration = UnitySignalRActivator.Start();
            app.MapSignalR(hubConfiguration);
        }
    }
}
