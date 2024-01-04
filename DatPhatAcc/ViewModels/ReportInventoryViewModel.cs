using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Models;
using DatPhatAcc.Services;
using System.Collections.ObjectModel;

namespace DatPhatAcc.ViewModels
{
    public partial class ReportInventoryViewModel : ObservableObject
    {
        private readonly MisaService misaService;
        public ReportInventoryViewModel(MisaService misaService)
        {
            this.misaService = misaService;
        }

        [ObservableProperty]
        private DateTime fromDate = DateTime.Now;

        [ObservableProperty]
        private DateTime toDate = DateTime.Now;

        [ObservableProperty]
        private ObservableCollection<InventoryItemSummary> inventoryItemSummaries = new();

        [RelayCommand]
        private async Task GetInventoryItemSummary()
        {
            InventoryItemSummaries.Clear();
            List<InventoryItemSummary> list = new();
            await Task.Run(async () =>
            {
                list = await misaService.GetInventoryItemSummaryBalance(FromDate, ToDate);
            });

            InventoryItemSummaries = new ObservableCollection<InventoryItemSummary>(list);

        }
    }
}
