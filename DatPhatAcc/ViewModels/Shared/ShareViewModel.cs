using CommunityToolkit.Mvvm.ComponentModel;
using DatPhatAcc.AccountingDbContext;
using System.Collections.ObjectModel;

namespace DatPhatAcc.ViewModels.Shared
{
    public partial class ShareViewModel : ObservableObject
    {
      
        public ShareViewModel(SettingViewModel settingViewModel)
        {
        
            Init();

        }

        [ObservableProperty]
        private ObservableCollection<ListVat> listVats = new();

        private void Init()
        {
            ObservableCollection<ListVat> listVats = new()
            {
                new ListVat {VatId = "1", VatValue = 0,  VatName = "0" },
                new ListVat {VatId = "2", VatValue = 5,  VatName = "5" },
                new ListVat {VatId = "3", VatValue = 8, VatName = "8" },
                new ListVat {VatId = "4", VatValue = 10, VatName = "10" },
                new ListVat {VatId = "5", VatValue = 0, VatName = "K" },
            };

            ListVats = new ObservableCollection<ListVat>(listVats);
        }
    }
}
