using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Helpers;
using DatPhatAcc.Models;
using DatPhatAcc.Models.DTO;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows;
using ListVat = DatPhatAcc.AccountingDbContext.ListVat;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncPurchaseViewModel : ObservableObject
    {
        private readonly ShareViewModel shareViewModel;
        private readonly AccountingService accountingService;
        private readonly MisaUltis misaUltis;


        public SyncPurchaseViewModel(AccountingService accountingService, ShareViewModel shareViewModel, MisaUltis misaUltis)
        {
            this.accountingService = accountingService;
            this.shareViewModel = shareViewModel;
            this.misaUltis = misaUltis;
            Init();
        }

        private async void Init()
        {
            LoadCustomersAsync().SafeFireAndForget();
            Task loadTransTypesTask = LoadTransTypesAsync();

            await loadTransTypesTask;
            SelectedTransTypes = TransTypes.First(trantype => trantype.TransCode.Equals("01"));

            LoadListVats();
            SelectedListVat = ListVats.First(listVat => listVat.VatValue.Equals(10));

            //event collection changed
            SelectedCustomers.CollectionChanged += SelectedCustomers_CollectionChanged;
            TempTransDetailDTOs.CollectionChanged += TempTransDetailDTOs_CollectionChanged;
            SelectedTransactionOverviews.CollectionChanged += SelectedTransactionOverviews_CollectionChanged;
            TransDetailDTOs.CollectionChanged += TransDetailDTOs_CollectionChanged;
        }
        #region Event Collection Changed

        private void TransDetailDTOs_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            AddAllTransDetailToTempCommand.NotifyCanExecuteChanged();
        }

        private void SelectedTransactionOverviews_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            GetTranDetailCommand.NotifyCanExecuteChanged();
        }

        private void SelectedCustomers_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            SearchTransactionOverviewCommand.NotifyCanExecuteChanged();
        }

        private void TempTransDetailDTOs_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ReCalculateTotalPriceCommand.NotifyCanExecuteChanged();
            CreateImportGoodsExcelFileCommand.NotifyCanExecuteChanged();
            CreatePurchaseImportExcelFileCommand.NotifyCanExecuteChanged();
            RemoveAllTransDetailFromTempCommand.NotifyCanExecuteChanged();
        }
        #endregion

        #region Properties
        [ObservableProperty]
        private ObservableCollection<CustomerDTO> customers = new();
        [ObservableProperty]
        private ObservableCollection<CustomerDTO> selectedCustomers = new();

        [ObservableProperty]
        private DateTime fromDate = DateTime.Now;
        [ObservableProperty]
        private DateTime toDate = DateTime.Now;


        [ObservableProperty]
        private ObservableCollection<TransType> transTypes = new();
        [ObservableProperty]
        private TransType selectedTransTypes = new();

        [ObservableProperty]
        private ObservableCollection<TransactionOverview> transactionOverviews = new();
        [ObservableProperty]
        private ObservableCollection<TransactionOverview> selectedTransactionOverviews = new();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AddAllTransDetailToTempCommand))]
        private ObservableCollection<TransDetailDTO> transDetailDTOs = new();


        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CreateImportGoodsExcelFileCommand))]
        [NotifyCanExecuteChangedFor(nameof(CreatePurchaseImportExcelFileCommand))]
        private ObservableCollection<TempTransDetailDTO> tempTransDetailDTOs = new();

        [ObservableProperty]
        private TransDetailDTO selectedTransDetailDTO = new();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ReCalculateTotalPriceCommand))]
        private decimal invoiceTotalAmount = 0m;

        [ObservableProperty]
        private ObservableCollection<ListVat> listVats = new();

        private ListVat selectedListVat = new();
        public ListVat SelectedListVat
        {
            get => selectedListVat;
            set
            {
                selectedListVat = value;
                OnPropertyChanged();
                SetAllVarTranDetails(value);
            }
        }
        #endregion

        #region Commands
        [RelayCommand(CanExecute = nameof(CanSearchTransactionOverview))]
        private async Task SearchTransactionOverview()
        {
            var transactionOverviews = await accountingService.SearchTransactionOverview(FromDate, ToDate, SelectedCustomers, SelectedTransTypes);
            TransactionOverviews = new ObservableCollection<TransactionOverview>(transactionOverviews);
        }
        private bool CanSearchTransactionOverview()
        {
            return SelectedCustomers.Count > 0;
        }

        [RelayCommand(CanExecute = nameof(CanGetTranDetail))]
        private async Task GetTranDetail()
        {
            var transDetailDTOs = await accountingService.GetTransDetailDTOsAsync(SelectedTransactionOverviews, SelectedListVat);
            TransDetailDTOs = new ObservableCollection<TransDetailDTO>(transDetailDTOs);
        }
        private bool CanGetTranDetail()
        {
            return SelectedTransactionOverviews.Count > 0;
        }

        [RelayCommand]
        private void AddTransDetailToTemp(TransDetailDTO transDetailDTO)
        {
            TempTransDetailDTO newTransDetail = new()
            {
                //copy value from TransDetailDTO to TempTransDetailDTO
                GoodId = transDetailDTO.GoodId,
                ShortName = transDetailDTO.ShortName,
                Quantity = transDetailDTO.Quantity,
                Price = transDetailDTO.Price,
                VatValue = transDetailDTO.VatValue,
                TotalPrice = transDetailDTO.TotalPrice,
                TotalPriceVat = transDetailDTO.TotalPriceVat
            };

            TempTransDetailDTOs.Add(newTransDetail);
        }

        [RelayCommand(CanExecute = nameof(CanAddAllTransDetailToTemp))]
        private void AddAllTransDetailToTemp(TransDetailDTO transDetailDTO)
        {
            foreach (var transDetail in TransDetailDTOs)
            {
                AddTransDetailToTemp(transDetail);
            }
        }

        private bool CanAddAllTransDetailToTemp()
        {
            return TransDetailDTOs.Count > 0;
        }

        [RelayCommand]
        private void RemoveTransDetailFromTemp(TempTransDetailDTO tempTransDetailDTO)
        {
            TempTransDetailDTOs.Remove(tempTransDetailDTO);
        }

        [RelayCommand(CanExecute = nameof(CanRemoveAllTransDetailFromTemp))]
        private void RemoveAllTransDetailFromTemp(TransDetailDTO transDetailDTO)
        {
            TempTransDetailDTOs.Clear();
        }

        private bool CanRemoveAllTransDetailFromTemp()
        {
            return TempTransDetailDTOs.Count > 0;
        }

        [RelayCommand(CanExecute = nameof(CanRecalculateTotalPrice))]
        private void ReCalculateTotalPrice()
        {
            if (TempTransDetailDTOs.Count == 0) return;
            //check if invoice total amount is not digit then return
            //if (!decimal.TryParse(InvoiceTotalAmount.ToString(), out decimal invoiceTotalAmount)) return;


            decimal sum = TempTransDetailDTOs.Sum(x => x.TotalPrice);
            decimal rate = InvoiceTotalAmount / sum;

            foreach (var transDetail in TempTransDetailDTOs)
            {
                transDetail.TotalPrice *= rate;
            }
        }

        private bool CanRecalculateTotalPrice()
        {
            return InvoiceTotalAmount > 0m && TempTransDetailDTOs.Count > 0;
        }

        [RelayCommand(CanExecute = nameof(CanCreateImportExcelFile))]
        private async Task CreatePurchaseImportExcelFile()
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

            string saveFilePath = saveFileDialog.FileName;

            bool success = await misaUltis.ImportExcel.CreateFileImportPurchase(TempTransDetailDTOs, saveFilePath);
            if (success)
            {
                MessageBox.Show("Tạo file excel thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Tạo file excel thất bại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CanCreateImportExcelFile()
        {
            return TempTransDetailDTOs.Count > 0;
        }

        [RelayCommand(CanExecute = nameof(CanCreateImportExcelFile))]
        private async Task CreateImportGoodsExcelFile()
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

            string saveFilePath = saveFileDialog.FileName;

            ACCOUNTINGContext accountingContext = new();

            var newInventoryItems = TempTransDetailDTOs
                .Join(accountingContext.Goods, temp => temp.GoodId, good => good.GoodId, (temp, good) => new NewInventoryItem
                {
                    ProductId = temp.GoodId,
                    ProductName = good.ShortName ?? string.Empty,
                    UnitId = good.UnitId ?? string.Empty
                })
                .Join(accountingContext.Units, newII => newII.UnitId, unit => unit.UnitId, (item, unit) => new NewInventoryItem
                {
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    UnitId = item.UnitId,
                    UnitName = unit.UnitName ?? string.Empty,
                });

            Helpers.MisaUltis misaUltis = new();

            bool success = false;
            try
            {
                success = await misaUltis.ImportExcel.CreateFileImportNewInventoryItem(newInventoryItems, saveFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (success)
            {
                MessageBox.Show("Tạo file excel thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Tạo file excel thất bại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        #endregion

        private async Task LoadCustomersAsync()
        {
            var customerList = await accountingService.GetCustomers();
            Customers = new ObservableCollection<CustomerDTO>(customerList);
        }

        private async Task LoadTransTypesAsync()
        {
            var transTypes = await accountingService.GetTransTypesAsync();
            TransTypes = new ObservableCollection<TransType>(transTypes);
        }

        private void LoadListVats()
        {
            //var listVats = await accountingService.GetListVatsAsync();
            ListVats = shareViewModel.ListVats;
        }

        private void SetAllVarTranDetails(ListVat listVat)
        {
            foreach (var transDetailDTO in TransDetailDTOs)
            {
                transDetailDTO.VatValue = listVat.VatValue;
                transDetailDTO.TotalPriceVat = transDetailDTO.TotalPrice * (1m + listVat.VatValue / 100m);
            }
        }



    }
}
