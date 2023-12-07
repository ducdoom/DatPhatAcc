using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Models.DTO;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using System.Collections.ObjectModel;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncPurchaseViewModel : ObservableObject
    {
        private ShareViewModel _shareViewModel;
        private AccountingDbContext.ACCOUNTINGContext _aCCOUNTINGContext = new();
        private AccountingService accountingService = new();

        public SyncPurchaseViewModel(ShareViewModel shareViewModel)
        {
            _shareViewModel = shareViewModel;
            LoadCustomersAsync().SafeFireAndForget();
        }

        [ObservableProperty]
        private ObservableCollection<CustomerDTO> customers = new();
        [ObservableProperty]
        private ObservableCollection<CustomerDTO> selectedCustomers = new();

        [ObservableProperty]
        private DateTime fromDate = DateTime.Now;
        [ObservableProperty]
        private DateTime toDate = DateTime.Now;

        [ObservableProperty]
        private ObservableCollection<TransactionOverview> transactionOverviews = new();

        private async Task LoadCustomersAsync()
        {
            var customerList = await accountingService.GetCustomers();
            Customers = new ObservableCollection<CustomerDTO>(customerList);
        }

        [RelayCommand]
        private async Task SearchTransactionOverview()
        {
            var transactionOverviews = await accountingService.SearchPurchaseTransactionOverview(FromDate, ToDate, SelectedCustomers);
            TransactionOverviews = new ObservableCollection<TransactionOverview>(transactionOverviews);
        }
    }
}
