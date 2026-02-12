using System;
using ContactManagement.Application.Interfaces.Presenters;
using ContactManagement.Application.Interfaces.Views;
using System.Windows.Forms;
using ContactManagement.WinForms.Views;
using Microsoft.Extensions.DependencyInjection;
using ContactManagement.WinForms.Presenters;
using ContactManagement.Application.Services;
using ContactManagement.Application.Interfaces.Services;
using ContactManagement.Application.Interfaces.DataAccess;
using ContactManagement.Infrastructure.DataAccess;
using ContactManagement.Infrastructure.DataAccess.Repositories;
using ContactManagement.Application.Interfaces.Repositories;
using System.Threading;

namespace ContactManagement.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            System.Windows.Forms.Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            System.Windows.Forms.Application.ThreadException += Application_ThreadException;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            var services = new ServiceCollection();
            ConfigureServices(services);

            var provider = services.BuildServiceProvider();
            var initializer = provider.GetRequiredService<IDatabaseInitializer>();
            initializer.Initialize();
            initializer.SeedDemoData();

            IMainView mainView = provider.GetRequiredService<IMainView>();
            IMainPresenter presenter = provider.GetRequiredService<IMainPresenter>();
            mainView.SetPresenter(presenter);

            System.Windows.Forms.Application.Run((Form)mainView);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Infrastructure
            services.AddSingleton<IDbConnectionFactory>(
                new SqliteConnectionFactory("contacts.db"));
            services.AddSingleton<IDatabaseInitializer, SqliteDatabaseInitializer>();
            services.AddTransient<IContactRepository, ContactRepository>();

            // Application
            services.AddTransient<IContactService, ContactService>();

            //Forms
            services.AddSingleton<IMainView, MainView>();
            services.AddSingleton<IMainPresenter, MainPresenter>();
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowFatal(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            ShowFatal(ex);
        }

        private static void ShowFatal(Exception ex)
        {
            try
            {
                var msg = ex == null ? "Unknown error" : ex.Message;

                MessageBox.Show(
                    msg,
                    "Unexpected error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch
            {
                
            }
        }
    }
}
