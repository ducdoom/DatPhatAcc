using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace DatPhatAcc2.ViewModels;

public partial class ShellViewModel : ObservableObject
{
    private readonly NavigationService navigationService;

    public ShellViewModel(NavigationService navigationService)
    {
        this.navigationService = navigationService;
    }

    [RelayCommand]
    private void NavigateToReport()
    {
        navigationService.Navigate(new Uri("ReportInventorySummaryPage.xaml", UriKind.Relative));
    }
}
