using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
//using Microsoft.Extensions.Hosting;
using MailSender.TestWPF.ViewModels;


namespace MailSender.TestWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //private static IHost __Hosting;
        protected override void OnStartup(StartupEventArgs e)
        {
            ////Hosting.Start();
            ////base.OnStartup(e);

            //var services = new ServiceCollection();
            //services.AddScoped<MainWindowViewModel>();
        }

    }
}
