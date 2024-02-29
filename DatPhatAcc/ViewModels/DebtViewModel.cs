using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Services;

namespace DatPhatAcc.ViewModels
{
    public partial class DebtViewModel : ObservableObject
    {
        private Services.AccountingService accountingService;
        public DebtViewModel(AccountingService accountingService)
        {
            this.accountingService = accountingService;
        }

        [ObservableProperty]
        private DateTime fromDateMisa = DateTime.Now;
        [ObservableProperty]
        private DateTime toDateMisa = DateTime.Now;

        [RelayCommand]
        private async Task GetStored()
        {
            await accountingService.DetailByOneAccount(new DateTime(2024, 01, 01), DateTime.Now, "331", "005197");
        }
    }
}
