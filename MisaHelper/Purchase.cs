using MisaHelper.Models;
using OfficeOpenXml;
using OfficeOpenXml.ConditionalFormatting.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MisaHelper
{
    public class Purchase
    {
        public Purchase()
        {
            
        }

        public PurchaseImportData PurchaseImportData { get; set; } = new PurchaseImportData();
        public bool CreatePurchaseImportExcelFile(string path)
        {
            //if path exists then delete
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            //open file excel template from exceltemplate folder
            string fileName = "ExcelTemplates\\Mua_hang_qua_kho_VND.xlsx"; // Replace with your file name
            string folderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(folderPath, fileName);

            using ExcelPackage excelPackage = new(new System.IO.FileInfo(filePath));
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.First();
            //if(worksheet is null)
            //{
            //    return false;
            //}

            //if (worksheet != null)
            //{
            //    //get last row
            //    int lastRow = worksheet.Dimension.End.Row;
            //    //delete all rows in sheet except header
            //    worksheet.DeleteRow(2, lastRow - 1);

            //}
            int startRow = 2;

            foreach(var importProduct in PurchaseImportData.ImportProducts)
            {
                worksheet.Cells["E" + startRow].Value = PurchaseImportData.TransactionDate;
                worksheet.Cells["F" + startRow].Value = PurchaseImportData.TransactionDate;
                worksheet.Cells["G" + startRow].Value = PurchaseImportData.TransactionNumber;
                worksheet.Cells["K" + startRow].Value = PurchaseImportData.InvoiceNumber;
                worksheet.Cells["R" + startRow].Value = importProduct.ProductId;
                worksheet.Cells["V" + startRow].Value = PurchaseImportData.TKKho;
                worksheet.Cells["W" + startRow].Value = PurchaseImportData.TKCongNo;
                worksheet.Cells["Y" + startRow].Value = importProduct.Quantity;
                worksheet.Cells["Z" + startRow].Value = importProduct.Price;
                worksheet.Cells["AA" + startRow].Value = importProduct.TotalPrice;
                worksheet.Cells["AE" + startRow].Value = importProduct.VatRate;
                worksheet.Cells["AG" + startRow].Value = importProduct.VatAmount;
                worksheet.Cells["AI" + startRow].Value = PurchaseImportData.TKThueGTGT;

                startRow++;
            }

           

            excelPackage.SaveAs(new System.IO.FileInfo(path));
            return true;
        }
    }
}
