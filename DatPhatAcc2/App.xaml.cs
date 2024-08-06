using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using DatPhatAcc2.Services;
using DatPhatAcc2.ViewModels;
using DatPhatAcc2.Views;
using Microsoft.Extensions.DependencyInjection;

namespace DatPhatAcc2;
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
        services.AddSingleton<MainWindow>(x => new MainWindow()
        {
            DataContext = x.GetRequiredService<MainViewModel>()
        });

        services.AddSingleton<CheckInvoiceViewModel>();
        services.AddSingleton<CheckInvoicePage>();
        services.AddSingleton<ReportInventorySummaryViewModel>();
        services.AddSingleton<ReportInventorySummaryPage>();

        services.AddSingleton<NavigationService>();
        services.AddSingleton<Func<Type, ObservableObject>>(serviceProvider => viewModelType => (ObservableObject)serviceProvider.GetRequiredService(viewModelType));

        _serviceProvider = services.BuildServiceProvider();

    }

    protected async override void OnStartup(StartupEventArgs e)
    {
        var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
        MainViewModel mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.NavigationService.Navigate<ViewModels.ReportInventorySummaryViewModel>();
        mainWindow.Show();

        base.OnStartup(e);
    }

    private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
    {
        e.Handled = true;
    }
}

