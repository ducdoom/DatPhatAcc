using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Services;

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
            NavigationService.Navigate<HomeViewModel>();
        }

        [RelayCommand]
        private void NavigateToSetting()
        {
            NavigationService.Navigate<SettingViewModel>();
        }
    }

}
