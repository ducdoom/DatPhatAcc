﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Services;
using System.Diagnostics;
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
        private void NavigateToHome()
        {
            NavigationService.Navigate<SyncPurchaseViewModel>();
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
    }

}
