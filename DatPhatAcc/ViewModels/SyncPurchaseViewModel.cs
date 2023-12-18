using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Models.DTO;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncPurchaseViewModel : ObservableObject
    {
        private ShareViewModel _shareViewModel;
        private AccountingService accountingService = new();


        public SyncPurchaseViewModel(ShareViewModel shareViewModel)
        {
            _shareViewModel = shareViewModel;
            Init();
        }

        private async void Init()
        {
            LoadCustomersAsync().SafeFireAndForget();
            Task loadTransTypesTask = LoadTransTypesAsync();
            Task loadListVatsTask = LoadListVatsAsync();

            await loadTransTypesTask;
            SelectedTransTypes = TransTypes.First(trantype => trantype.TransCode.Equals("01"));

            await loadListVatsTask;
            SelectedListVat = ListVats.First(listVat => listVat.VatValue.Equals(10));
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
        private ObservableCollection<TransType> transTypes = new();
        [ObservableProperty]
        private TransType selectedTransTypes = new();

        [ObservableProperty]
        private ObservableCollection<TransactionOverview> transactionOverviews = new();
        [ObservableProperty]
        private ObservableCollection<TransactionOverview> selectedTransactionOverviews = new();

        [ObservableProperty]
        private ObservableCollection<TransDetailDTO> transDetailDTOs = new();


        [ObservableProperty]
        private ObservableCollection<TempTransDetailDTO> tempTransDetailDTOs = new();
        [ObservableProperty]
        private TransDetailDTO selectedTransDetailDTO = new();

        [ObservableProperty]
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

        private async Task LoadListVatsAsync()
        {
            var listVats = await accountingService.GetListVatsAsync();
            ListVats = new ObservableCollection<ListVat>(listVats);
        }

        [RelayCommand]
        private async Task SearchTransactionOverview()
        {
            var transactionOverviews = await accountingService.SearchTransactionOverview(FromDate, ToDate, SelectedCustomers, SelectedTransTypes);
            TransactionOverviews = new ObservableCollection<TransactionOverview>(transactionOverviews);
        }

        [RelayCommand]
        private async Task GetTranDetail()
        {
            var transDetailDTOs = await accountingService.GetTransDetailDTOsAsync(SelectedTransactionOverviews, SelectedListVat);
            TransDetailDTOs = new ObservableCollection<TransDetailDTO>(transDetailDTOs);
        }

        private void SetAllVarTranDetails(ListVat listVat)
        {
            foreach (var transDetailDTO in TransDetailDTOs)
            {
                transDetailDTO.VatValue = listVat.VatValue;
                transDetailDTO.TotalPriceVat = transDetailDTO.TotalPrice * (1m + listVat.VatValue / 100m);
            }
        }

        [RelayCommand]
        private void AddTransDetailToTemp(TransDetailDTO transDetailDTO)
        {
            TempTransDetailDTO newTransDetail = new();
            //copy value from TransDetailDTO to TempTransDetailDTO
            newTransDetail.GoodId = transDetailDTO.GoodId;
            newTransDetail.ShortName = transDetailDTO.ShortName;
            newTransDetail.Quantity = transDetailDTO.Quantity;
            newTransDetail.Price = transDetailDTO.Price;
            newTransDetail.VatValue = transDetailDTO.VatValue;
            newTransDetail.TotalPrice = transDetailDTO.TotalPrice;
            newTransDetail.TotalPriceVat = transDetailDTO.TotalPriceVat;

            TempTransDetailDTOs.Add(newTransDetail);
        }

        [RelayCommand]
        private void AddAllTransDetailToTemp(TransDetailDTO transDetailDTO)
        {
            foreach (var transDetail in TransDetailDTOs)
            {
                AddTransDetailToTemp(transDetail);
            }
        }

        [RelayCommand]
        private void RemoveTransDetailFromTemp(TempTransDetailDTO tempTransDetailDTO)
        {
            TempTransDetailDTOs.Remove(tempTransDetailDTO);
        }

        [RelayCommand]
        private void RemoveAllTransDetailFromTemp(TransDetailDTO transDetailDTO)
        {
            TempTransDetailDTOs.Clear();
        }

        [RelayCommand]
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

        [RelayCommand]
        private void CreatePurchaseImportExcelFile()
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

            MisaHelper.MisaHelper misaHelper = new();
            misaHelper.Purchase.PurchaseImportData.TransactionDate = new DateTime(2024, 1, 1);
            misaHelper.Purchase.PurchaseImportData.InvoiceNumber = "0";

            //misaHelper.Purchase.PurchaseImportData.ImportProducts = new List<MisaHelper.Models.ImportProduct>();
            foreach (TempTransDetailDTO product in TempTransDetailDTOs)
            {
                misaHelper.Purchase.PurchaseImportData.ImportProducts.Add(new MisaHelper.Models.ImportProduct
                {
                    ProductId = product.GoodId,
                    Quantity = (double)product.Quantity,
                    Price = (double)product.Price,
                    TotalPrice = (double)product.TotalPrice,
                    VatRate = (double)product.VatValue,
                    VatAmount = (double)product.VatAmount
                });
            }

            string templateFilePath = "Resources\\MisaExcelTemplates\\Mua_hang_qua_kho_VND.xlsx";
            if (!System.IO.File.Exists(templateFilePath))
            {
                MessageBox.Show("Không tìm thấy file excel template");
                return;
            }

            bool success = misaHelper.Purchase.CreatePurchaseImportExcelFile(templateFilePath, saveFilePath);
            if (success)
                MessageBox.Show("Tạo file excel thành công", "Thông báo");

        }

    }
}
