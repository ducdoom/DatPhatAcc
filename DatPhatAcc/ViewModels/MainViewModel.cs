using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using System.Windows;

namespace DatPhatAcc.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            SimpleTcpServer server = new SimpleTcpServer("127.0.0.1", 8080);
            server.Listen();
        }

        [ObservableProperty]
        private INavigationService navigationService;


        [RelayCommand]
        private void ExitApp()
        {
            Application.Current.Shutdown();
        }

        [RelayCommand]
        private void NavigateToSyncPurchaseView()
        {
            NavigationService.Navigate<SyncPurchaseViewModel>();
        }

        [RelayCommand]
        private void NavigateToSyncRetailTransView()
        {
            NavigationService.Navigate<SyncRetailTransViewModel>();
        }

        [RelayCommand]
        private void NavigateToReportInventoryView()
        {
            NavigationService.Navigate<ReportInventoryViewModel>();
        }

        [RelayCommand]
        private void NavigateToSettingView()
        {
            NavigationService.Navigate<SettingViewModel>();
        }

        [RelayCommand]
        private void NavigateToOutwardView()
        {
            NavigationService.Navigate<OutwardViewModel>();
        }

        [RelayCommand]
        private void NavigateToSyncExportInnerView()
        {
            NavigationService.Navigate<SyncExportInnerViewModel>();
        }

        [RelayCommand]
        private void NavigateToTCTInvoiceView()
        {
            NavigationService.Navigate<TCTInvoiceViewModel>();
        }

        [RelayCommand]
        private void NavigateToUpdateLogView()
        {
            NavigationService.Navigate<UpdateLogViewModel>();
        }

        [RelayCommand]
        private void NavigateToDebtView()
        {
            NavigationService.Navigate<DebtViewModel>();
        }

        [RelayCommand]
        private void NavigateToAutmationView()
        {
            NavigationService.Navigate<AutomationViewModel>();
        }

    }

}
