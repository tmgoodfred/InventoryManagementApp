using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.DependencyInjection;

[assembly: UserSecretsId("8e301d9a-0bc0-48c9-b6c2-4cec06d799b4")]

namespace InventoryManagementApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize application configuration
            ApplicationConfiguration.Initialize();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddUserSecrets<Secrets>()
                .AddEnvironmentVariables();

            var configuration = builder.Build();

            var services = new ServiceCollection()
                .Configure<Secrets>(configuration.GetSection(nameof(Secrets)))
                .AddSingleton<DatabaseFunctions>()
                .AddSingleton<AddUserForm>() // Register AddUserForm
                .AddSingleton<LoginScreen>() // Register LoginScreen
                .AddSingleton<InventoryScreen>() // Register InventoryScreen
                .BuildServiceProvider();

            var loginScreen = services.GetService<LoginScreen>();

            Application.Run(loginScreen);
        }
    }
}
