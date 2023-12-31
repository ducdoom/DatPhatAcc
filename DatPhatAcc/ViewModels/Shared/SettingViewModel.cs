using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace DatPhatAcc.ViewModels.Shared
{
    public partial class SettingViewModel : ObservableObject
    {
        private readonly AccountingService accountingService;
        public SettingViewModel(AccountingService accountingService)
        {
            this.accountingService = accountingService;
            //Init();
        }

        private void Init()
        {
            GetBranchList().SafeFireAndForget();
        }

        [ObservableProperty]
        private ObservableCollection<Models.BranchInterestRate> branchInterestRates = new();

        private async Task GetBranchList()
        {
            Models.DbContext.BranchInterestRateDbContext dbContext = new();
            var branchInterestRates = await dbContext.BranchInterestRate.ToArrayAsync().ConfigureAwait(false);
            BranchInterestRates = new(branchInterestRates);
        }

        [RelayCommand]
        private async Task LoadBranchList()
        {
            Models.DbContext.BranchInterestRateDbContext dbContext = new();
            var branchInterestRates = await dbContext.BranchInterestRate.OrderBy(x => x.BranchId).ToArrayAsync().ConfigureAwait(false);
            BranchInterestRates = new(branchInterestRates);
        }

        private List<Models.BranchInterestRate> BranchInterestRatesDefault()
        {
            //List<Models.BranchInterestRate> list = new()
            //{               
            //    new Models.BranchInterestRate("01", "Thực Phẩm", 10, 3),
            //    new Models.BranchInterestRate("02", "Hóa Mỹ Phẩm", 10, 3),
            //    new Models.BranchInterestRate("03", "Gia Dụng", 10, 3),
            //    new Models.BranchInterestRate("04", "Đồ Chơi Và TB Học Tập", 10, 3),
            //    new Models.BranchInterestRate("05", "Bách Hóa", 10, 3),
            //    new Models.BranchInterestRate("06", "Hàng Thủ Công Mỹ Nghệ", 10, 3),
            //    new Models.BranchInterestRate("07", "Thời Trang", 10, 3),
            //    new Models.BranchInterestRate("08", "Khuyến Mại", 10, 3),
            //    new Models.BranchInterestRate("09", "Vật Tư Phụ", 10, 3),
            //    new Models.BranchInterestRate("10", "Không Dùng", 10, 3),
            //    new Models.BranchInterestRate("11", "Thực Phẩm Tươi", 10, 3),
            //    new Models.BranchInterestRate("12", "Dịch Vụ", 10, 3),
            //    new Models.BranchInterestRate("13", "Bách Hóa Ăn Nhanh", 10, 3),
            //    new Models.BranchInterestRate("14", "Bánh Kẹo Bán Buôn", 10, 3),
            //    new Models.BranchInterestRate("15", "SP Masan", 10, 3),
            //    new Models.BranchInterestRate("16", "Siêu Thị Văn Giang", 10, 3),
            //    new Models.BranchInterestRate("17", "D-SHINGING", 10, 3),
            //    new Models.BranchInterestRate("18", "Mã Riêng Siêu Thị 144 Đức Giang", 10, 3),
            //    new Models.BranchInterestRate("19", "Thực Phẩm Đã Qua Chế Biến", 10, 3),
            //    new Models.BranchInterestRate("20", "TP Chức Năng - Thuốc", 10, 3)
            //};

            List<Models.BranchInterestRate> list = new();

            return list;
        }


    }
}
