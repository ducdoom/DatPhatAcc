using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Helpers;
using DatPhatAcc.Models;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncExportInnerViewModel : ObservableObject
    {
        private readonly Sync2Service sync2Service;
        private readonly ShareViewModel shareViewModel;
        private readonly SettingViewModel settingViewModel;

        public SyncExportInnerViewModel(Sync2Service sync2Service, ShareViewModel shareViewModel, SettingViewModel settingViewModel)
        {
            this.sync2Service = sync2Service;
            this.shareViewModel = shareViewModel;
            this.settingViewModel = settingViewModel;

            Init();
        }

        private void Init()
        {
            InitCustomers().SafeFireAndForget();
            ListVats = shareViewModel.ListVats;
            SelectedListVat = ListVats.First(listVat => listVat.VatValue.Equals(10));

            SelectedtranDetail2s.CollectionChanged += SelectedtranDetail2s_CollectionChanged;
            TranDetail2s.CollectionChanged += TranDetail2s_CollectionChanged;
        }

        private void TranDetail2s_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyCanExecuteChangedForAllCommands();
        }

        private void SelectedtranDetail2s_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyCanExecuteChangedForAllCommands();
        }

        private void NotifyCanExecuteChangedForAllCommands()
        {
            RemoveClosingQuantityZeroCommand.NotifyCanExecuteChanged();
            AdjustQuantityCommand.NotifyCanExecuteChanged();
            ApplyInterestRateCommand.NotifyCanExecuteChanged();
            IncreaseQuantityCommand.NotifyCanExecuteChanged();
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
        private ObservableCollection<Models.TranDetail2> selectedtranDetail2s = new();
        [ObservableProperty]
        private Models.TranDetail2 selectedTranDetail2 = new();

        [ObservableProperty]
        private ObservableCollection<Models.InventoryItemSummary> inventoryItemSummary1 = new();

        [ObservableProperty]
        decimal desireAmount = 0;

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

        partial void OnTranDetail2sChanged(ObservableCollection<TranDetail2> value)
        {
            NotifyCanExecuteChangedForAllCommands();
        }

        partial void OnSelectedTranDetail2Changed(TranDetail2? oldValue, TranDetail2 newValue)
        {
            NotifyCanExecuteChangedForAllCommands();
        }

        partial void OnDesireAmountChanged(decimal value)
        {
            NotifyCanExecuteChangedForAllCommands();
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
            TranDetail2s.Clear();
            List<TranDetail2> tranDetail2List = new();
            await Task.Run(async () =>
            {
                tranDetail2List = (List<TranDetail2>)await sync2Service.GetSyncExportInnerTransactions(SelectedCustomer, FromDate, ToDate, SelectedListVat);
            });
            //var tranDetail2List = await sync2Service.GetSyncExportInnerTransactions(SelectedCustomer, FromDate, ToDate, SelectedListVat);
            TranDetail2s = new ObservableCollection<Models.TranDetail2>(tranDetail2List);
        }

        [RelayCommand]
        private void RemoveItem(TranDetail2 tranDetail2)
        {
            TranDetail2s.Remove(tranDetail2);
        }

        private bool CanEditGridData() => TranDetail2s.Any();

        [RelayCommand(CanExecute = nameof(CanEditGridData))]
        private void RemoveClosingQuantityZero()
        {
            TranDetail2s = new(TranDetail2s.Where(item => item.ClosingQuantity != 0));
        }

        [RelayCommand(CanExecute = nameof(CanEditGridData))]
        private void AdjustQuantity()
        {
            foreach (TranDetail2 item in TranDetail2s)
            {
                var newQuantity = Math.Min(item.ClosingQuantity, item.Quantity);
                if (item.Quantity != newQuantity)
                {
                    item.Quantity = newQuantity;
                }
            }
        }

        [RelayCommand(CanExecute = nameof(CanEditGridData))]
        private void ApplyInterestRate()
        {
            var branchInterestRate = settingViewModel.BranchInterestRates;

            foreach (TranDetail2 item in TranDetail2s)
            {
                if (item.Price < item.CostPriceUnit)
                {
                    item.Price = item.CostPriceUnit;
                }

                string branchId = ThanhCongAccountingHelper.GetBranchFromGoodId(item.InventoryItemCode);
                decimal interestValue = 10;
                Models.BranchInterestRate? interestRate = branchInterestRate.FirstOrDefault(x => x.BranchId.Equals(branchId));
                if (interestRate != null)
                {
                    interestValue = interestRate.RetailInterestRate;
                }

                item.Price = item.CostPriceUnit * (1 + interestValue / 100);
            }
        }

        private bool CanCreateImportExcelBanHang() => SelectedtranDetail2s.Any();
        private bool CanIncreaseQuantity()
        { 
            if(!SelectedtranDetail2s.Any())
            {
                return false;
            }

            bool containData = SelectedtranDetail2s.Any();
            decimal currentTotalAmount = SelectedtranDetail2s.Sum(x => x.TotalAmount);
            return containData && DesireAmount > currentTotalAmount;
        }

        [RelayCommand(CanExecute = nameof(CanIncreaseQuantity))]
        private void IncreaseQuantity()
        {
            decimal currentTotalAmount = SelectedtranDetail2s.Sum(x => x.TotalAmount);
            if (DesireAmount < currentTotalAmount)
            {
                return;
            }

            while (currentTotalAmount <= DesireAmount)
            {
                foreach (TranDetail2 item in SelectedtranDetail2s)
                {
                    if (item.Quantity < item.ClosingQuantity)
                    {
                        item.Quantity++;
                    }

                    currentTotalAmount = SelectedtranDetail2s.Sum(x => x.TotalAmount);
                }
            }
        }
        #endregion
    }
}
