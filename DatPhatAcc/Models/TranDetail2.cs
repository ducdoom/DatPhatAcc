using CommunityToolkit.Mvvm.ComponentModel;
using DatPhatAcc.MisaDbContext;
using System.Collections.ObjectModel;

namespace DatPhatAcc.Models
{
    public partial class TranDetail2: ObservableObject
    {
        public TranDetail2()
        {
            
        }
        [ObservableProperty]
        private ObservableCollection< InventoryItemSummary> inventoryItems = new();

        [ObservableProperty]
        private InventoryItemSummary selectedInventoryItem = new();
    }
}
