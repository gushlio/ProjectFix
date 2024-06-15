using DataAccessLayer;
using DesktopApp;
using Domain.Interfaces;
using Domain.Manager;
using Microsoft.Extensions.DependencyInjection;
using ZooBazarDesktopApp.Classes;

namespace ZooBazarDesktopApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configure dependency injection
            var services = new ServiceCollection();
            ConfigureServices(services);


            /*   Application.Run(new MainForm());*/

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var loginForm = serviceProvider.GetRequiredService<Login>();
                Application.Run(loginForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<Login>();
            services.AddTransient<MainForm>();
        }
    }
}