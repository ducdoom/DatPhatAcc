using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DatPhatAcc2.ViewModels;

namespace DatPhatAcc2.Views;
/// <summary>
/// Interaction logic for CheckInvoicePage.xaml
/// </summary>
public partial class CheckInvoicePage : Page
{

    public CheckInvoicePage(CheckInvoiceViewModel vm)
    {
        InitializeComponent();
        DataContext = vm;
    }
}
