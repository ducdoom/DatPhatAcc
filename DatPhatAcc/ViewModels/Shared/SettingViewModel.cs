using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace DatPhatAcc.ViewModels.Shared
{
    public partial class SettingViewModel : ObservableObject
    {
        private readonly AccountingService accountingService;
        private Models.DbContext.BranchInterestRateDbContext branchInterestRateDbContext;

        private Services.DatPhatCustomApp datPhatCustomApp;

        public SettingViewModel(AccountingService accountingService, DatPhatCustomApp datPhatCustomApp)
        {
            this.accountingService = accountingService;
            this.datPhatCustomApp = datPhatCustomApp;
            branchInterestRateDbContext = new();
            Init().ConfigureAwait(false);
        }

        private async Task Init()
        {
           await LoadInterestRateFromLarkBase();
        }

        [ObservableProperty]
        private ObservableCollection<Models.BranchInterestRate> branchInterestRates = new();

        [RelayCommand]
        private async Task LoadBranchList()
        {
            var branchInterestRates = await branchInterestRateDbContext.BranchInterestRate.OrderBy(x => x.BranchId).ToArrayAsync().ConfigureAwait(false);
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

        [RelayCommand]
        private async Task SaveSettings()
        {
            int rows = await branchInterestRateDbContext.SaveChangesAsync().ConfigureAwait(false);
            Debug.WriteLine($"SaveSettings: {rows}");
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        [RelayCommand]
        private async Task LoadInterestRateFromLarkBase()
        {
            List<Models.BranchInterestRate> list = await datPhatCustomApp.GetInteresRateList();
            BranchInterestRates = new(list);
        }

    }
}
