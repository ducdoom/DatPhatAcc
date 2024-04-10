using CommunityToolkit.Mvvm.ComponentModel;
using DatPhatAcc.Helpers;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels;
using DatPhatAcc.ViewModels.Shared;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
using System.Windows;
using Application = System.Windows.Application;

namespace DatPhatAcc
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<SyncPurchaseViewModel>();
            services.AddSingleton<SyncRetailTransViewModel>();
            services.AddSingleton<SyncExportInnerViewModel>();
            services.AddSingleton<ReportInventoryViewModel>();
            services.AddSingleton<ShareViewModel>();
            services.AddSingleton<OutwardViewModel>();
            services.AddSingleton<TCTInvoiceViewModel>();
            services.AddSingleton<UpdateLogViewModel>();
            services.AddSingleton<DebtViewModel>();
            services.AddSingleton<AutomationViewModel>();
            services.AddSingleton<CreateSaleInvoiceViewModel>();

            services.AddSingleton<AccountingService>(); //services
            services.AddSingleton<MisaService>();
            services.AddSingleton<Sync2Service>();
            services.AddSingleton<MisaUltis>();
            services.AddSingleton<Ihoadon>();
            services.AddSingleton<ExcelHelper>();


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            services.AddTransient<SettingViewModel>(); //transient

            services.AddSingleton<MainWindow>(x => new MainWindow()
            {
                DataContext = x.GetRequiredService<MainViewModel>()
            });

            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<Func<Type, ObservableObject>>(serviceProvider => viewModelType => (ObservableObject)serviceProvider.GetRequiredService(viewModelType));

            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            MainViewModel mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
            mainViewModel.NavigationService.Navigate<SyncPurchaseViewModel>();
            mainWindow.Show();

            base.OnStartup(e);
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }
    }

}
