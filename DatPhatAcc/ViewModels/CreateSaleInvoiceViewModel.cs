using CommunityToolkit.Mvvm.ComponentModel;

namespace DatPhatAcc.ViewModels;

public partial class CreateSaleInvoiceViewModel : ObservableObject
{
    private Services.AccountingService accountingService;
    public CreateSaleInvoiceViewModel(Services.AccountingService accountingService)
    {
        this.accountingService = accountingService;
    }


}
