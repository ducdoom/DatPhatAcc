using DatPhatAcc.Models;
using DatPhatAcc.Models.DTO;
using OfficeOpenXml;
using System.IO;
using System.Windows;

namespace DatPhatAcc.Helpers
{
    public class ImportExcel
    {
        public ImportExcel()
        {

        }

        public async Task<bool> CreateFileImportNewInventoryItem(IEnumerable<Models.NewInventoryItem> newInventoryItems, string saveFile)
        {
            try
            {
                FileInfo file = new("Resources\\MisaExcelTemplates\\Mau_danh_muc_vat_tu_hang_hoa_VND.xlsx");
                ExcelPackage excelPackage = new(file);

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                int startRow = 2;
                foreach (NewInventoryItem item in newInventoryItems)
                {
                    worksheet.Cells["A" + startRow].Value = item.ProductId;
                    worksheet.Cells["B" + startRow].Value = item.ProductName;
                    worksheet.Cells["D" + startRow].Value = item.UnitName;
                    worksheet.Cells["H" + startRow].Value = item.TK_KHO;
                    worksheet.Cells["I" + startRow].Value = item.TK_DOANHTHU;
                    worksheet.Cells["J" + startRow].Value = item.TK_CHI_PHI;

                    startRow++;
                }

                await excelPackage.SaveAsAsync(saveFile).ConfigureAwait(false);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> CreateFileImportBanHang(IEnumerable<Models.DTO.TransDetailDTO> transDetailDTOs, string saveFile)
        {
            try
            {
                FileInfo file = new("Resources\\MisaExcelTemplates\\Ban_hang_VND.xlsx");
                using ExcelPackage excelPackage = new(file);

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
                int startRow = 2;
                foreach (TransDetailDTO transDetailDTO in transDetailDTOs)
                {
                    worksheet.Cells["G" + startRow].Value = 1;// đã lập hóa đơn
                    worksheet.Cells["H" + startRow].Value = DateTime.Now;// ngày hạch toán
                    worksheet.Cells["I" + startRow].Value = DateTime.Now;// ngày hạch toán
                    worksheet.Cells["J" + startRow].Value = $"BH{DateTime.Now:yyyyMMddHHmmss}";// ngày hạch toán
                    worksheet.Cells["K" + startRow].Value = $"XK{DateTime.Now:yyyyMMddHHmmss}";// ngày hạch toán
                    worksheet.Cells["L" + startRow].Value = "Xuất kho bán hàng theo hóa đơn";// lý do xuất
                    worksheet.Cells["M" + startRow].Value = $"HD{DateTime.Now:yyyyMMddHHmmss}";// số hóa đơn
                    worksheet.Cells["N" + startRow].Value = DateTime.Now;// ngày hóa đơn
                    worksheet.Cells["V" + startRow].Value = transDetailDTO.GoodId;// mã hàng
                    worksheet.Cells["Y" + startRow].Value = "131";// TK Nợ
                    worksheet.Cells["Z" + startRow].Value = "5111";// TK Có
                    worksheet.Cells["AB" + startRow].Value = transDetailDTO.Quantity;// Số lượng
                    worksheet.Cells["AD" + startRow].Value = transDetailDTO.Price;// Đơn giá
                    worksheet.Cells["AE" + startRow].Value = transDetailDTO.TotalPrice;// Thành tiền
                    worksheet.Cells["AM" + startRow].Value = transDetailDTO.VatValue;// thuế suất
                    worksheet.Cells["AO" + startRow].Value = transDetailDTO.VatAmount;// tiền thuế
                    worksheet.Cells["AP" + startRow].Value = "33311";// tài khoản thuế đầu ra
                    worksheet.Cells["AR" + startRow].Value = transDetailDTO.StockCode;// Kho
                    worksheet.Cells["AS" + startRow].Value = "632";// tài khoản giá vốn
                    worksheet.Cells["AT" + startRow].Value = "1561";// tài khoản kho

                    startRow++;
                }

                await excelPackage.SaveAsAsync(saveFile).ConfigureAwait(false);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
                return false;
            }
        }

        public async Task<bool> CreateFileImportBanHang2(IEnumerable<TranDetail2> transDetail2s, string saveFile)
        {
            try
            {
                FileInfo file = new("Resources\\MisaExcelTemplates\\Ban_hang_VND.xlsx");
                using ExcelPackage excelPackage = new(file);

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
                int startRow = 2;
                foreach (TranDetail2 transDetail2 in transDetail2s)
                {
                    worksheet.Cells["G" + startRow].Value = 1;// đã lập hóa đơn
                    worksheet.Cells["H" + startRow].Value = DateTime.Now;// ngày hạch toán
                    worksheet.Cells["I" + startRow].Value = DateTime.Now;// ngày hạch toán
                    worksheet.Cells["J" + startRow].Value = $"BH{DateTime.Now:yyyyMMddHHmmss}";// ngày hạch toán
                    worksheet.Cells["K" + startRow].Value = $"XK{DateTime.Now:yyyyMMddHHmmss}";// ngày hạch toán
                    worksheet.Cells["L" + startRow].Value = "Xuất kho bán hàng theo hóa đơn";// lý do xuất
                    worksheet.Cells["M" + startRow].Value = $"HD{DateTime.Now:yyyyMMddHHmmss}";// số hóa đơn
                    worksheet.Cells["N" + startRow].Value = DateTime.Now;// ngày hóa đơn
                    worksheet.Cells["V" + startRow].Value = transDetail2.InventoryItemCode;// mã hàng
                    worksheet.Cells["Y" + startRow].Value = "131";// TK Nợ
                    worksheet.Cells["Z" + startRow].Value = "5111";// TK Có
                    worksheet.Cells["AB" + startRow].Value = transDetail2.Quantity;// Số lượng
                    worksheet.Cells["AD" + startRow].Value = transDetail2.Price;// Đơn giá
                    worksheet.Cells["AE" + startRow].Value = transDetail2.TotalAmount;// Thành tiền
                    worksheet.Cells["AM" + startRow].Value = transDetail2.VatRate;// thuế suất
                    worksheet.Cells["AO" + startRow].Value = transDetail2.VatAmount;// tiền thuế
                    worksheet.Cells["AP" + startRow].Value = "33311";// tài khoản thuế đầu ra
                    worksheet.Cells["AR" + startRow].Value = transDetail2.StockCode;// Kho
                    worksheet.Cells["AS" + startRow].Value = "632";// tài khoản giá vốn
                    worksheet.Cells["AT" + startRow].Value = "1561";// tài khoản kho

                    startRow++;
                }

                await excelPackage.SaveAsAsync(saveFile).ConfigureAwait(false);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
                return false;
            }
        }

    }
}
