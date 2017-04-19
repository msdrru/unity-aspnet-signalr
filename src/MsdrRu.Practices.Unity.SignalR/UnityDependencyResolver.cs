using System;
using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using Microsoft.Practices.Unity;

namespace MsdrRu.Practices.Unity.SignalR
{
    public sealed class UnityDependencyResolver : DefaultDependencyResolver
    {
        private readonly IUnityContainer container;

        public UnityDependencyResolver(IUnityContainer container)
        {
            this.container = container;
        }

        public override object GetService(Type serviceType)
        {
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (container.IsRegistered(serviceType) || serviceType.IsSubclassOf(typeof(Hub)))
            {
                return container.Resolve(serviceType);
            }

            return base.GetService(serviceType);
        }

        public override IEnumerable<object> GetServices(Type serviceType)
        {
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (container.IsRegistered(serviceType))
            {
                return container.ResolveAll(serviceType);
            }

            return base.GetServices(serviceType);
        }
    }
}
