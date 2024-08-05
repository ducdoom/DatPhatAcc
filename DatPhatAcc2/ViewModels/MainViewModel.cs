using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc2.Services;

namespace DatPhatAcc2.ViewModels;
public partial class MainViewModel : ObservableObject
{
    public MainViewModel(NavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    [ObservableProperty]
    private NavigationService navigationService;


    [RelayCommand]
    private void NavigateToReportInventorySummaryPage()
    {
        NavigationService.Navigate<ViewModels.ReportInventorySummaryViewModel>();
    }
}
