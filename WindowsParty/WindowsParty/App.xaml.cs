using Autofac;
using Autofac.Core;
using Autofac.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WindowsParty.Clients;
using WindowsParty.Clients.Contracts;

namespace WindowsParty
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IContainer Container { get; private set; }

        public App()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ApiClient>().As<IApiClient>();
            Container = builder.Build();
        }
    }
}
