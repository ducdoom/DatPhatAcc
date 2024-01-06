using MisaHelper.Models;
using OfficeOpenXml;

namespace MisaHelper
{
    public class ImportExcel
    {
        public ImportExcel()
        {

        }

        public bool CreateFileImportMisaVTHH(IEnumerable<Models.MisaVTHH> misaVTHHs, string saveFile)
        {
            try
            {
                FileInfo file = new("ExcelTemplates\\Mau_danh_muc_vat_tu_hang_hoa_VND.xlsx");
                ExcelPackage excelPackage = new(file);

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                int startRow = 2;
                foreach (MisaVTHH misaVTHH in misaVTHHs)
                {
                    worksheet.Cells["A" + startRow].Value = misaVTHH.ProductId;
                    worksheet.Cells["B" + startRow].Value = misaVTHH.ProductName;
                    worksheet.Cells["D" + startRow].Value = misaVTHH.Unit;
                    worksheet.Cells["H" + startRow].Value = misaVTHH.TK_KHO;
                    worksheet.Cells["I" + startRow].Value = misaVTHH.TK_DOANHTHU;
                    worksheet.Cells["J" + startRow].Value = misaVTHH.TK_CHI_PHI;

                    startRow++;
                }

                excelPackage.SaveAs(saveFile);
                return true;
            }
            catch(System.Exception ex)
            {                
                throw ex;
            }
        }

        public bool CreateFileImportBanHang(IEnumerable<Models.MisaVTHH> misaVTHHs, string saveFile)
        {
            try
            {
                FileInfo file = new("ExcelTemplates\\Ban_hang_VND.xlsx");
                using ExcelPackage excelPackage = new(file);

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
                int startRow = 2;
                foreach (MisaVTHH misaVTHH in misaVTHHs)
                {
                    worksheet.Cells["G" + startRow].Value = 1;// đã lập hóa đơn
                    worksheet.Cells["H" + startRow].Value = DateTime.Now;// ngày hạch toán
                    worksheet.Cells["I" + startRow].Value = DateTime.Now;// ngày hạch toán
                    worksheet.Cells["J" + startRow].Value = $"BH{DateTime.Now:yyyyMMddHHmmss}";// ngày hạch toán
                    worksheet.Cells["K" + startRow].Value = $"XK{DateTime.Now:yyyyMMddHHmmss}";// ngày hạch toán
                    worksheet.Cells["L" + startRow].Value = "Xuất kho bán hàng theo hóa đơn";// lý do xuất
                    worksheet.Cells["M" + startRow].Value = $"HD{DateTime.Now:yyyyMMddHHmmss}";// số hóa đơn
                    worksheet.Cells["N" + startRow].Value = DateTime.Now;// ngày hóa đơn
                    worksheet.Cells["V" + startRow].Value = misaVTHH.ProductId;// mã hàng
                    worksheet.Cells["Y" + startRow].Value = "131";// TK Nợ
                    worksheet.Cells["Z" + startRow].Value = "5111";// TK Có
                    //worksheet.Cells["AB" + startRow].Value = misaVTHH;// Số lượng

                    startRow++;
                }

                excelPackage.SaveAs(saveFile);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
