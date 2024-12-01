using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;

namespace InventoryManagementApp
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

            // Build configuration to include user secrets
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<System.Reflection.Assembly>()
                .Build();

            // Access user secrets
            var dbUser = builder["dbUser"];
            var dbPassword = builder["dbPassword"];

            // Optionally, you can pass the secrets to your form or use them as needed
            Application.Run(new InventoryScreen(dbUser, dbPassword));
        }
    }
}
