using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Helpers;
using DatPhatAcc.Models;
using DatPhatAcc.Services;
using DatPhatAcc.ViewModels.Shared;
using Microsoft.Win32;
using OfficeOpenXml;
using System.Collections.ObjectModel;
using System.Windows;

namespace DatPhatAcc.ViewModels
{
    public partial class ReportInventoryViewModel : ObservableObject
    {
        private readonly MisaService misaService;
        private readonly SettingViewModel settingViewModel;
        public ReportInventoryViewModel(MisaService misaService, SettingViewModel settingViewModel)
        {
            this.misaService = misaService;
            this.settingViewModel = settingViewModel;
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

        [RelayCommand]
        private async Task ExportExcel()
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = $"XNT{DateTime.Now:yyyy-MM-dd}.xlsx";
            if (saveFileDialog.ShowDialog() == false)
            {
                return;
            }

            string saveFile = saveFileDialog.FileName;

            ExcelPackage excelPackage = new();
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

            worksheet.Cells["A1"].Value = "Mã kho";
            worksheet.Cells["B1"].Value = "Mã hàng";
            worksheet.Cells["C1"].Value = "Tên hàng";
            worksheet.Cells["D1"].Value = "Đơn vị tính";
            worksheet.Cells["E1"].Value = "Số lượng tồn";
            worksheet.Cells["F1"].Value = "Giá bán chưa VAT";

            var branchInterestRate = settingViewModel.BranchInterestRates;

            int startRow = 2;
            worksheet.Column(5).Style.Numberformat.Format = "#,##0";
            worksheet.Column(6).Style.Numberformat.Format = "#,##0";

            foreach (InventoryItemSummary item in InventoryItemSummaries)
            {
                string branchId = ThanhCongAccountingHelper.GetBranchFromGoodId(item.InventoryItemCode);
                decimal interestValue = 10;
                Models.BranchInterestRate? interestRate = branchInterestRate.FirstOrDefault(x => x.BranchId.Equals(branchId));
                if (interestRate != null)
                {
                    interestValue = interestRate.RetailInterestRate;
                }

                worksheet.Cells["A" + startRow].Value = item.StockCode;
                worksheet.Cells["B" + startRow].Value = item.InventoryItemCode;
                worksheet.Cells["C" + startRow].Value = item.InventoryItemName;
                worksheet.Cells["D" + startRow].Value = item.UnitName;
                worksheet.Cells["E" + startRow].Value = item.ClosingQuantity;
                worksheet.Cells["F" + startRow].Value = item.CostPriceUnit * (1 + interestValue / 100);

                startRow++;
            }

            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
            await excelPackage.SaveAsAsync(saveFile);

            MessageBox.Show(Application.Current.MainWindow, "Xuất file thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
