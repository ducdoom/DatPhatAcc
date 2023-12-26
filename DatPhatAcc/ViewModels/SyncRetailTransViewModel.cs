using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Models.DTO;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using System.Collections.ObjectModel;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncRetailTransViewModel : ObservableObject
    {
        private readonly AccountingService accountingService;
        private readonly ShareViewModel shareViewModel;
        public SyncRetailTransViewModel(AccountingService accountingService, ShareViewModel shareViewModel)
        {
            this.accountingService = accountingService;
            this.shareViewModel = shareViewModel;
            Init();
        }

        private void Init()
        {
            ListVats = shareViewModel.ListVats;
            SelectedListVat = ListVats.First(listVat => listVat.VatValue.Equals(10));
        }

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(GetRetailTransCommand))]
        private string transactionIds = string.Empty;

        [ObservableProperty]
        private ObservableCollection<ListVat> listVats = new();
        [ObservableProperty]
        private ListVat selectedListVat = new();

        [ObservableProperty]
        private ObservableCollection<TransDetailDTO> transDetailDTOs = new();

        partial void OnSelectedListVatChanged(ListVat value)
        {
            SetAllVatValue();
        }

        private bool CanGetRetailTrans() => !string.IsNullOrEmpty(TransactionIds);

        [RelayCommand(CanExecute = nameof(CanGetRetailTrans))]
        private async Task GetRetailTrans()
        {
            var retailTrans = await accountingService.GetRetailTrans2(TransactionIds);
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
    }
}
