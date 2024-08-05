using System.Windows.Controls;

using DatPhat3.ViewModels;

namespace DatPhat3.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
