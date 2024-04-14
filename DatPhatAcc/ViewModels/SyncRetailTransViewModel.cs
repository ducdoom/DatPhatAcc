using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Helpers;
using DatPhatAcc.Models.DTO;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using DevExpress.Mvvm.Xpf;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncRetailTransViewModel : ObservableObject
    {
        private readonly AccountingService accountingService;
        private readonly ShareViewModel shareViewModel;
        private readonly SettingViewModel settingViewModel;
        private readonly MisaUltis misaUltis;

        public SyncRetailTransViewModel(
            AccountingService accountingService,
            ShareViewModel shareViewModel,
            MisaUltis misaUltis,
            SettingViewModel settingViewModel
            )
        {
            this.accountingService = accountingService;
            this.shareViewModel = shareViewModel;
            this.misaUltis = misaUltis;
            this.settingViewModel = settingViewModel;

            Init();
        }

        private void Init()
        {
            ListVats = shareViewModel.ListVats;
            SelectedListVat = ListVats.First(listVat => listVat.VatValue.Equals(10));

            SelectedTransDetailDTOs.CollectionChanged += SelectedTransDetailDTOs_CollectionChanged;
        }

        private void SelectedTransDetailDTOs_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            CreateImportExcelBanHangCommand.NotifyCanExecuteChanged();
            IncreaseQuantityCommand.NotifyCanExecuteChanged();
        }

        #region Properties

        [ObservableProperty]
        private DateTime fromDate = DateTime.Now;
        [ObservableProperty]
        private DateTime toDate = DateTime.Now;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(GetRetailTransByIDCommand))]
        private string transactionIds = string.Empty;

        [ObservableProperty]
        private ObservableCollection<ListVat> listVats = new();
        [ObservableProperty]
        private ListVat selectedListVat = new();

        [ObservableProperty]        
        [NotifyCanExecuteChangedFor(nameof(ApplyInterestRateCommand))]
        [NotifyCanExecuteChangedFor(nameof(RemoveClosingQuantityZeroCommand))]
        [NotifyCanExecuteChangedFor(nameof(AdjustQuantityCommand))]        
        private ObservableCollection<TransDetailDTO> transDetailDTOs = new();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(CreateImportExcelBanHangCommand))]
        [NotifyCanExecuteChangedFor(nameof(IncreaseQuantityCommand))]
        private ObservableCollection<TransDetailDTO> selectedTransDetailDTOs = new();


        [ObservableProperty]
        private decimal desireAmount = 0;

        #endregion


        partial void OnSelectedListVatChanged(ListVat value)
        {
            SetAllVatValue();
        }

        private bool CanGetRetailTrans() => !string.IsNullOrEmpty(TransactionIds);

        [RelayCommand(CanExecute = nameof(CanGetRetailTrans))]
        private async Task GetRetailTransByID()
        {
            var retailTrans = await accountingService.GetRetailTransByTransactionId(TransactionIds);
            TransDetailDTOs = new ObservableCollection<TransDetailDTO>(retailTrans);
            SetAllVatValue();
        }

        private void SetAllVatValue()
        {
            foreach (var item in TransDetailDTOs)
            {
                item.VatValue = SelectedListVat.VatValue;
            }
        }

        [RelayCommand]
        private async Task GetRetailTransByDate()
        {
            var retailTrans = await accountingService.GetRetailTransByDate(FromDate, ToDate);
            TransDetailDTOs = new ObservableCollection<TransDetailDTO>(retailTrans);
            SetAllVatValue();
        }

        private bool CanCreateImportExcelBanHang() => SelectedTransDetailDTOs.Count > 0;

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

            bool success = await misaUltis.ImportExcel.CreateFileImportBanHang(SelectedTransDetailDTOs, fileName);
            if (success)
            {
                MessageBox.Show("Tạo file import bán hàng thành công", "Thông báo");
            }
        }


        private bool CanEditGridData() => TransDetailDTOs.Count > 0;

        [RelayCommand(CanExecute = nameof(CanEditGridData))]
        private void ApplyInterestRate()
        {
            var branchInterestRate = settingViewModel.BranchInterestRates;

            foreach (TransDetailDTO item in TransDetailDTOs)
            {
                if (item.Price < item.CostPriceUnit)
                {
                    item.Price = item.CostPriceUnit;
                }

                string branchId = ThanhCongAccountingHelper.GetBranchFromGoodId(item.GoodId);
                decimal interestValue = 10;
                Models.BranchInterestRate? interestRate = branchInterestRate.FirstOrDefault(x => x.BranchId.Equals(branchId));
                if (interestRate != null)
                {
                    interestValue = interestRate.RetailInterestRate;
                }

                item.Price = item.CostPriceUnit * (1 + interestValue / 100);
            }
        }

        [RelayCommand(CanExecute = nameof(CanEditGridData))]
        private void RemoveClosingQuantityZero()
        {
            TransDetailDTOs = new(TransDetailDTOs.Where(item => item.ClosingQuantity != 0));
        }

        [RelayCommand(CanExecute = nameof(CanEditGridData))]
        private void AdjustQuantity()
        {
            foreach (TransDetailDTO item in TransDetailDTOs)
            {
                var newQuantity = Math.Min(item.ClosingQuantity, item.Quantity);
                if (item.Quantity != newQuantity)
                {
                    item.Quantity = newQuantity;
                }
            }
        }

        [RelayCommand(CanExecute =nameof(CanCreateImportExcelBanHang))]
        private void IncreaseQuantity()
        {
            decimal currentTotalAmount = SelectedTransDetailDTOs.Sum(x => x.TotalPrice);
            if (DesireAmount < currentTotalAmount)
            {
                return;
            }

            while (currentTotalAmount <= DesireAmount)
            {
                foreach (TransDetailDTO item in SelectedTransDetailDTOs)
                {                    
                    if (item.Quantity < item.ClosingQuantity)
                    {
                        item.Quantity++;
                    }

                    currentTotalAmount = SelectedTransDetailDTOs.Sum(x => x.TotalPrice);
                    if(currentTotalAmount >= DesireAmount)
                    {
                        return;
                    }
                }
            }
        }

        [RelayCommand]
        private void RemoveItem(TransDetailDTO transDetailDTO)
        {
            TransDetailDTOs.Remove(transDetailDTO);
        }

        [RelayCommand]
        private void AddNewRow()
        {

        }





    }
}
