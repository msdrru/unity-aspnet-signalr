using Microsoft.AspNet.SignalR;
using MsdrRu.Practices.Unity.SignalR;
using Unity.SignalR.WebApplication.App_Start;

namespace Unity.SignalR.WebApplication
{
    public static class UnitySignalRActivator
    {
        /// <summary>Integrates Unity when the application starts.</summary>
        public static HubConfiguration Start()
        {
            var resolver = new UnityDependencyResolver(UnityConfig.GetConfiguredContainer());

            var config = new HubConfiguration {Resolver = resolver};

            return config;
        }
    }
}