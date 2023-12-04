using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.ViewModels.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncPurchaseViewModel: ObservableObject
    {
        private ShareViewModel _shareViewModel;
        public SyncPurchaseViewModel(ShareViewModel shareViewModel)
        {
            _shareViewModel = shareViewModel;
            LoadCustomersAsync().SafeFireAndForget();
        }

        [ObservableProperty]
        private ObservableCollection<AccountingDbContext.Customer> customers;

        
        private async Task LoadCustomersAsync()
        {
            AccountingDbContext.ACCOUNTINGContext aCCOUNTINGContext = new();
            
            var customers = await aCCOUNTINGContext.Customers.ToArrayAsync();
            Customers = new ObservableCollection<AccountingDbContext.Customer>(customers);
        }
    }
}
