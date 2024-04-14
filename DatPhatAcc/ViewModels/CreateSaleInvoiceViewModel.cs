using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Models;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace DatPhatAcc.ViewModels
{
    public partial class CreateSaleInvoiceViewModel : ObservableObject
    {
        private Services.AccountingService accountingService;
        public CreateSaleInvoiceViewModel(Services.AccountingService accountingService)
        {
            this.accountingService = accountingService;
        }

        
    }
}
