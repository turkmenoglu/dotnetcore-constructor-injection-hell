using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.MsDependencyInjection;
using DotNetCoreInjectionApiWithCastleWindsor.Factories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreInjectionApiWithCastleWindsor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args);

            builder.UseServiceProviderFactory(new WindsorServiceProviderFactory())
                .ConfigureContainer<WindsorContainer>((context, container) =>
                {
                    container.Kernel.AddFacility<TypedFactoryFacility>();
                    container.Kernel.Register(
                        Component.For<IServiceFactory>().AsFactory()
                    );
                });

            builder.ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });

            return builder;
        }
    }
}
