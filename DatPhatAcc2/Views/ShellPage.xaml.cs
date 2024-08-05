using System.Windows.Controls;
using DatPhatAcc2.ViewModels;

namespace DatPhatAcc2.Views;

/// <summary>
/// Interaction logic for ShellPage.xaml
/// </summary>
public partial class ShellPage : Page
{
    public ShellPage(ShellViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
