using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Models;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using System.Collections.ObjectModel;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncExportInnerViewModel : ObservableObject
    {
        private readonly Sync2Service sync2Service;
        private readonly ShareViewModel shareViewModel;

        public SyncExportInnerViewModel(Sync2Service sync2Service, ShareViewModel shareViewModel)
        {
            this.sync2Service = sync2Service;
            this.shareViewModel = shareViewModel;
            Init();
        }

        private void Init()
        {
            InitCustomers().SafeFireAndForget();
            ListVats = shareViewModel.ListVats;
            SelectedListVat = ListVats.First(listVat => listVat.VatValue.Equals(10));
        }


        #region Properties

        [ObservableProperty]
        private DateTime fromDate = DateTime.Now;
        [ObservableProperty]
        private DateTime toDate = DateTime.Now;

        [ObservableProperty]
        private ObservableCollection<ListVat> listVats = new();
        [ObservableProperty]
        private ListVat selectedListVat = new();

        [ObservableProperty]
        private ObservableCollection<AccountingDbContext.Customer> customers = new();

        [ObservableProperty]
        private AccountingDbContext.Customer selectedCustomer = new();

        [ObservableProperty]
        private ObservableCollection<Models.TranDetail2> tranDetail2s = new();
        [ObservableProperty]
        private Models.TranDetail2 selectedTranDetail2 = new();

        [ObservableProperty]
        private ObservableCollection<Models.InventoryItemSummary> inventoryItemSummary1 = new();

        #endregion

        #region Event
        partial void OnSelectedListVatChanged(ListVat value)
        {
            if (!TranDetail2s.Any()) return;

            foreach (TranDetail2 item in TranDetail2s)
            {
                item.VatRate = value.VatValue;
            }
        }
        #endregion

        #region Commands

        [RelayCommand]
        private async Task InitCustomers()
        {
            var customers = await sync2Service.AccountingService.GetCustomersAsync();
            Customers = new ObservableCollection<AccountingDbContext.Customer>(customers);
            SelectedCustomer = Customers.First();
        }

        [RelayCommand]
        private async Task GetTransDetaiExportInner()
        {
            InventoryItemSummary1 = new(await sync2Service.MisaService.GetInventoryItemSummaryBalance(DateTime.Now, DateTime.Now));
            var tranDetail2List = await sync2Service.GetSyncExportInnerTransactions(SelectedCustomer, FromDate, ToDate, SelectedListVat);
            TranDetail2s = new ObservableCollection<Models.TranDetail2>(tranDetail2List);
        }

        #endregion
    }
}
