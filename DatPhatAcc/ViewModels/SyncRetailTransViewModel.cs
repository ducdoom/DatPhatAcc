using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Helpers;
using DatPhatAcc.Models.DTO;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncRetailTransViewModel : ObservableObject
    {
        private readonly AccountingService accountingService;
        private readonly ShareViewModel shareViewModel;
        private readonly MisaUltis misaUltis;
        public SyncRetailTransViewModel(AccountingService accountingService, ShareViewModel shareViewModel, MisaUltis misaUltis)
        {
            this.accountingService = accountingService;
            this.shareViewModel = shareViewModel;
            this.misaUltis = misaUltis;
            Init();
        }

        private void Init()
        {
            ListVats = shareViewModel.ListVats;
            SelectedListVat = ListVats.First(listVat => listVat.VatValue.Equals(10));
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
        [NotifyCanExecuteChangedFor(nameof(CreateImportExcelBanHangCommand))]
        private ObservableCollection<TransDetailDTO> transDetailDTOs = new();

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

        private bool CanCreateImportExcelBanHang() => TransDetailDTOs.Count > 0;

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

            bool success = await misaUltis.ImportExcel.CreateFileImportBanHang(TransDetailDTOs, fileName);
            if (success)
            {
                MessageBox.Show("Tạo file thành công", "Thông báo");
            }
        }


    }
}
