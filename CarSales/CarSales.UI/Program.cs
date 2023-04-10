using CarSales.Core;
using CarSales.Core.Repositories;
using CarSales.Infrastructure;
using CarSales.UI.Controllers;
using CarSales.UI.Views;
using CarSales.UI.Views.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;
using System.Data.SqlClient;
using UI.MVC;

namespace CarSales.UI
{
    internal static class Program
    {
        private static readonly string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=XYZCarSales;trusted_connection=true";

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services
                        .AddSingleton<IDbConnection>(_ => new SqlConnection(connectionString))
                        .AddSingleton<DbContext>()
                        .AddSingleton<IUnitOfWork>(sp => sp.GetRequiredService<DbContext>())
                        .AddSingleton<ICarRepository, CarRepository>()
                        .AddSingleton<ICustomerRepository, CustomerRepository>()
                        .AddSingleton<ISalesRepository, SalesRepository>()
                        .AddSingleton<IEmployeeRepository, EmployeeRepository>();
                });
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            ViewManager viewManager = new ViewManager();
            viewManager.RegisterViews<IMainView, MainView, MainController>();
            viewManager.RegisterViews<ICarListView, MainView, CarListController>();
            viewManager.RegisterViews<ICarFormView, CarFormView, CarFormController>();
            viewManager.RegisterViews<ILoginView, LoginView, LoginController>();
            viewManager.RegisterViews<INewSaleFormView, NewSaleFormView, NewSaleFormController>();
            viewManager.RegisterViews<ICustomerListView, MainView, CustomerListController>();
            viewManager.RegisterViews<ICustomerFormView, CustomerFormView, CustomerFormController>();
            viewManager.RegisterViews<ISaleListView, MainView, SalesListController>();

            // Show login window by default
            viewManager.Activate<ILoginView, IViewParameter>();
        }
    }

    public static class RepositoryFactory
    {
        public static ICarRepository GetCarRepository() => Program.ServiceProvider.GetRequiredService<ICarRepository>();
        public static ICustomerRepository GetCustomerRepository() => Program.ServiceProvider.GetRequiredService<ICustomerRepository>();
        public static ISalesRepository GetSalesRepository() => Program.ServiceProvider.GetRequiredService<ISalesRepository>();
        public static IEmployeeRepository GetEmployeeRepository() => Program.ServiceProvider.GetRequiredService<IEmployeeRepository>();
        public static IUnitOfWork GetUnitOfWork() => Program.ServiceProvider.GetRequiredService<IUnitOfWork>();
    }
}