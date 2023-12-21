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
        public bool CreatePurchaseImportExcelFile(string templateFilePath, string path)
        {
            //if path exists then delete
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            using ExcelPackage excelPackage = new(new System.IO.FileInfo(templateFilePath));
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.First();

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
