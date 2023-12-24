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
                using ExcelPackage excelPackage = new(file);

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
            catch
            {
                return false;            
            }
        }
    }
}
