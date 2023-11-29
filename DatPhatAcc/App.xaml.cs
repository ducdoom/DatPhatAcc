using CommunityToolkit.Mvvm.ComponentModel;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

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
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<SettingViewModel>();

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
            mainWindow.Show();
            base.OnStartup(e);
        }
    }

}
