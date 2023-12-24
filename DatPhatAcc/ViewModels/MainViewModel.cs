﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Services;
using System.Windows;

namespace DatPhatAcc.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        [ObservableProperty]
        private INavigationService navigationService;


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
        private void NavigateToSetting()
        {
            NavigationService.Navigate<SettingViewModel>();
        }

        [RelayCommand]
        private void ExitApp()
        {
            Application.Current.Shutdown();
        }

        [RelayCommand]
        private void RestartApp()
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }

}
