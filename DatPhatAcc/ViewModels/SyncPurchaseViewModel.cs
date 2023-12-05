using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using DatPhatAcc.Models.DTO;
using DatPhatAcc.ViewModels.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncPurchaseViewModel : ObservableObject
    {
        private ShareViewModel _shareViewModel;
        public SyncPurchaseViewModel(ShareViewModel shareViewModel)
        {
            _shareViewModel = shareViewModel;
            LoadCustomersAsync().SafeFireAndForget();
        }

        [ObservableProperty]
        private ObservableCollection<CustomerDTO> customers = new();


        private async Task LoadCustomersAsync()
        {
            AccountingDbContext.ACCOUNTINGContext aCCOUNTINGContext = new();

            var customerList = await aCCOUNTINGContext.Customers
                .Select(x => new CustomerDTO
                {
                    CustomerId = x.CustomerId,
                    CustomerName = x.CustomerName,
                    TaxCode = x.Taxcode
                })
                .ToArrayAsync();
            Customers = new ObservableCollection<CustomerDTO>(customerList);
        }
    }
}
