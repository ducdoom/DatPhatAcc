using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Models;
using DatPhatAcc.Services;
using System.Collections.ObjectModel;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncExportInnerViewModel : ObservableObject
    {
        private readonly AccountingService accountingService;
        private readonly MisaService misaService;

        public SyncExportInnerViewModel(AccountingService accountingService, MisaService misaService)
        {
            this.accountingService = accountingService;
            this.misaService = misaService;
            Init();
        }

        private void Init()
        {
            InitCustomers().SafeFireAndForget();
        }


        #region Properties

        [ObservableProperty]
        private DateTime fromDate = DateTime.Now;
        [ObservableProperty]
        private DateTime toDate = DateTime.Now;

        [ObservableProperty]
        private ObservableCollection<AccountingDbContext.Customer> customers = new();

        [ObservableProperty]
        private AccountingDbContext.Customer selectedCustomer = new();

        [ObservableProperty]
        private ObservableCollection<Models.TranDetail2> tranDetail2s = new();
        [ObservableProperty]
        private Models.TranDetail2 selectedTranDetail2 = new();

        [ObservableProperty]
        private ObservableCollection<Models.InventoryItemSummary> inventoryItemSummary = new();

        #endregion

        #region Commands

        [RelayCommand]
        private async Task InitCustomers()
        {
            var customers = await accountingService.GetCustomersAsync();
            Customers = new ObservableCollection<AccountingDbContext.Customer>(customers);
            SelectedCustomer = Customers.First();
        }

        [RelayCommand]
        private async Task GetTransDetaiExportInner()
        {
            //var tranDetail2 = await accountingService.GetTransDetaiExportInnerAsync(SelectedCustomer, FromDate, ToDate);
            var inventoryItemSummary = await misaService.GetInventoryItemSummaryBalance(DateTime.Now, DateTime.Now);

            InventoryItemSummary = new ObservableCollection<Models.InventoryItemSummary>(inventoryItemSummary);
        }

        #endregion
    }
}
