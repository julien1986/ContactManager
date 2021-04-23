using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.API.Tools
{
    public abstract class LocatorBase
    {
        protected IServiceProvider Container { get; private set; }

        

        public LocatorBase()
        {
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            Container = services.BuildServiceProvider();
        }

        protected abstract void ConfigureServices(IServiceCollection services);
    }
}