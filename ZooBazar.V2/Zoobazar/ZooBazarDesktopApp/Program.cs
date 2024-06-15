using DataAccessLayer;
using DesktopApp;
using Domain.Interfaces;
using Domain.Manager;
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
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeDatabase(), new FormOpener());
            Application.Run(new Login(employeeManager));
        }
    }
}