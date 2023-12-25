using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Services;

namespace DatPhatAcc.ViewModels
{
    public partial class SyncRetailTransViewModel : ObservableObject
    {
        private readonly AccountingService accountingService;
        public SyncRetailTransViewModel(AccountingService accountingService)
        {
            this.accountingService = accountingService;
        }

        [ObservableProperty]
        private string transactionIds = string.Empty;

        [RelayCommand]
        private async Task GetRetailTrans()
        {
            await AccountingService.GetRetailTrans(TransactionIds);
        }
    }
}
