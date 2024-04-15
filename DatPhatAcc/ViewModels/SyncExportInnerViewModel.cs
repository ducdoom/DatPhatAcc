using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Helpers;
using DatPhatAcc.Models;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using DevExpress.Pdf.Native.BouncyCastle.X509;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncExportInnerViewModel : ObservableObject
    {
        private readonly Sync2Service sync2Service;
        private readonly ShareViewModel shareViewModel;
        private readonly SettingViewModel settingViewModel;
        private readonly MisaUltis misaUltis;
        private readonly MisaService misaService;

        public SyncExportInnerViewModel(
            Sync2Service sync2Service, 
            ShareViewModel shareViewModel, 
            SettingViewModel settingViewModel, 
            MisaUltis misaUltis,
            MisaService misaService)
        {
            this.sync2Service = sync2Service;
            this.shareViewModel = shareViewModel;
            this.settingViewModel = settingViewModel;
            this.misaUltis = misaUltis;
            this.misaService = misaService;

            Init();
        }

        private void Init()
        {
            InitCustomers().SafeFireAndForget();
            ListVats = shareViewModel.ListVats;
            SelectedListVat = ListVats.First(listVat => listVat.VatValue.Equals(10));

            SyncTransactionTypes = shareViewModel.SyncTransactionTypes;
            SelectedSyncTransactionType = SyncTransactionTypes.First();

            SelectedtranDetail2s.CollectionChanged += SelectedtranDetail2s_CollectionChanged;
            TranDetail2s.CollectionChanged += TranDetail2s_CollectionChanged;
        }

        #region Events
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
            CreateImportExcelBanHangCommand.NotifyCanExecuteChanged();
            AddNewTranDetail2Command.NotifyCanExecuteChanged();
        }

        #endregion

        #region Properties

        [ObservableProperty]
        private DateTime fromDate = DateTime.Now;
        [ObservableProperty]
        private DateTime toDate = DateTime.Now;

        [ObservableProperty]
        private ObservableCollection<AccountingDbContext.ListVat> listVats = new();
        [ObservableProperty]
        private AccountingDbContext.ListVat selectedListVat = new();

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

        [ObservableProperty]
        private ObservableCollection<SyncTransactionType> syncTransactionTypes = new();
        [ObservableProperty]
        private SyncTransactionType selectedSyncTransactionType = new();

        [ObservableProperty]
        private Visibility isRetailTransaction = Visibility.Visible;
        [ObservableProperty]
        private Visibility isInnerTransaction = Visibility.Visible;

        [ObservableProperty]
        private string transactionIds = string.Empty;

        private ObservableCollection<Models.InventoryItemSummary> inventoryItemSummarieSource = new();

        #endregion

        #region Event
        partial void OnSelectedListVatChanged(AccountingDbContext.ListVat value)
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

        partial void OnSelectedSyncTransactionTypeChanged(SyncTransactionType value)
        {
            if (value.TransactionTypeId.Equals("1"))
            {
                IsRetailTransaction = Visibility.Visible;
                IsInnerTransaction = Visibility.Collapsed;
            }
            else
            {
                IsRetailTransaction = Visibility.Collapsed;
                IsInnerTransaction = Visibility.Visible;
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
        private async Task UpdateLastestInventoryItemBalance()
        {
            await Task.Delay(0);

            var inventoryItemSummary = await misaService.GetInventoryItemSummaryBalance(DateTime.Now, DateTime.Now);
            inventoryItemSummarieSource = new ObservableCollection<Models.InventoryItemSummary>(inventoryItemSummary);
            AddNewTranDetail2Command.NotifyCanExecuteChanged();
            
        }

        [RelayCommand]
        private async Task Search()
        {
            if (SelectedSyncTransactionType.TransactionTypeId.Equals("1"))
            {
                await GetRetailTranDetail();
            }
            if (SelectedSyncTransactionType.TransactionTypeId.Equals("2"))
            {
                await GetExportInnerTranDetail();
            }
        }

        private async Task GetRetailTranDetail()
        {
            TranDetail2s.Clear();

            List<TranDetail2> retailTrans = new();
            await Task.Run(async () =>
            {
                retailTrans = (List<TranDetail2>)await sync2Service.GetRetailTranDetailv2(FromDate, ToDate, SelectedListVat, TransactionIds.Trim());
            });
            TranDetail2s = new ObservableCollection<TranDetail2>(retailTrans);

            //SetAllVatValue();
        }

        private void SetAllVatValue()
        {
            foreach (var item in TranDetail2s)
            {
                item.VatRate = SelectedListVat.VatValue;
            }
        }

        private async Task GetExportInnerTranDetail()
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
                //Models.BranchInterestRate? interestRate = branchInterestRate.FirstOrDefault(x => x.BranchId.Equals(branchId));

                //if InventoryItemCode start with branchInterestRate then get interest rate
                foreach (var branch in branchInterestRate)
                {
                    if (item.InventoryItemCode.StartsWith(branch.BranchId))
                    {
                        interestValue = SelectedSyncTransactionType.TransactionTypeId.Equals("1") ? branch.RetailInterestRate : branch.WholeSaleInterestRate;
                        break;
                    }
                }

                //if (interestRate != null)
                //{
                //    if (SelectedSyncTransactionType.TransactionTypeId.Equals("1"))
                //    {
                //        interestValue = interestRate.RetailInterestRate;
                //    }
                //    if (SelectedSyncTransactionType.TransactionTypeId.Equals("2"))
                //    {
                //        interestValue = interestRate.WholeSaleInterestRate;
                //    }
                //}

                item.Price = item.CostPriceUnit * (1 + interestValue / 100);
            }
        }


        private bool CanIncreaseQuantity()
        {
            bool containData = SelectedtranDetail2s.Any();
            if (!containData)
            {
                return false;
            }

            decimal currentTotalAmount = SelectedtranDetail2s.Sum(x => x.TotalAmount);
            return containData && currentTotalAmount < DesireAmount;
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
                    if (currentTotalAmount >= DesireAmount)
                    {
                        break;
                    }
                }
            }
        }

        private bool CanCreateImportExcelBanHang() => SelectedtranDetail2s.Any();
        [RelayCommand(CanExecute = nameof(CanCreateImportExcelBanHang))]
        private async Task CreateImportExcelBanHang()
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == false)
            {
                return;
            }

            string fileName = saveFileDialog.FileName;

            bool success = await misaUltis.ImportExcel.CreateFileImportBanHang3(SelectedtranDetail2s, fileName, SelectedSyncTransactionType);
            if (success)
            {
                MessageBox.Show("Tạo file import bán hàng thành công", "Thông báo");
            }
        }

        private bool CanAddNewTranDetail2() => inventoryItemSummarieSource.Any();

        [RelayCommand(CanExecute =nameof(CanAddNewTranDetail2))]
        private void AddNewTranDetail2()
        {
            TranDetail2 tranDetail2 = new TranDetail2();
            tranDetail2.InventoryItems = inventoryItemSummarieSource;
            TranDetail2s.Add(tranDetail2);
           
        }
        #endregion
    }
}
