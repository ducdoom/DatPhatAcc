using DatPhatAcc.Models;
using OfficeOpenXml;
using System.Diagnostics;

namespace DatPhatAcc.Helpers
{
    public class ExcelHelper
    {
        public async Task<IEnumerable<Invoice>> ReadExcelFile(string fileName)
        {
            ExcelPackage excelPackage = new(new System.IO.FileInfo(fileName));
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.First();

            bool checkIfIsCorrectFile = CheckIfIsCorrectFile(worksheet);
            if (!checkIfIsCorrectFile)
            {
                return Enumerable.Empty<Invoice>();
            }

            int startRow = 7;
            int lastRow = worksheet.Dimension.End.Row;
            int lastColumn = worksheet.Dimension.End.Column;

            Dictionary<string, int> headerDictionary = worksheet.CreateHeaderDictionary(6);

            Debug.WriteLine($"lastColumn: {lastColumn}");
            List<Invoice> invoices = new();

            for (int rowNumber = startRow; rowNumber <= lastRow; rowNumber++)
            {
                
                Invoice invoice = new()
                {
                    InvoiceTemplateCode = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.InvoiceTemplateCode]].GetValue<string>(),
                    InvoiceCode = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.InvoiceCode]].GetValue<string>(),
                    InvoiceNumber = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.InvoiceNumber]].GetValue<string>(),
                    InvoiceDateString = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.InvoiceDate]].GetValue<string>(),
                    SellerTaxCode = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.SellerTaxCode]].GetValue<string>(),
                    SellerName = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.SellerName]].GetValue<string>(),
                    SellerAddress = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.SellerAddress]].GetValue<string>(),
                    TotalTaxAmount = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.TotalTaxAmount]].GetValue<double>(),
                    TotalDiscountAmount = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.TotalDiscountAmount]].GetValue<double>(),
                    TotalFeeAmount = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.TotalFeeAmount]].GetValue<double>(),
                    TotalAmountVAT = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.TotalAmount]].GetValue<double>(),
                    CurrencyUnit = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.CurrencyUnit]].GetValue<string>(),
                    InvoiceStatus = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.InvoiceStatus]].GetValue<string>(),
                    InvoiceCheckResult = worksheet.Cells[rowNumber, headerDictionary[TCTInvoiceColumnName.InvoiceCheckResult]].GetValue<string>(),

                };

                invoices.Add(invoice);
            }

            return invoices;

        }

        private bool CheckIfIsCorrectFile(ExcelWorksheet worksheet)
        {
            int rowNumber = 6;

            if ((bool)!worksheet.Cells["a" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.STT)) return false;
            if ((bool)!worksheet.Cells["b" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.InvoiceTemplateCode)) return false;
            if ((bool)!worksheet.Cells["c" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.InvoiceCode)) return false;
            if ((bool)!worksheet.Cells["d" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.InvoiceNumber)) return false;
            if ((bool)!worksheet.Cells["e" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.InvoiceDate)) return false;
            if ((bool)!worksheet.Cells["f" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.SellerTaxCode)) return false;
            if ((bool)!worksheet.Cells["g" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.SellerName)) return false;
            if ((bool)!worksheet.Cells["h" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.SellerAddress)) return false;
            if ((bool)!worksheet.Cells["i" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.TotalAmountWithoutTax)) return false;
            if ((bool)!worksheet.Cells["j" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.TotalTaxAmount)) return false;
            if ((bool)!worksheet.Cells["k" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.TotalDiscountAmount)) return false;
            if ((bool)!worksheet.Cells["l" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.TotalFeeAmount)) return false;
            if ((bool)!worksheet.Cells["m" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.TotalAmount)) return false;
            if ((bool)!worksheet.Cells["n" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.CurrencyUnit)) return false;
            if ((bool)!worksheet.Cells["o" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.ExchangeRate)) return false;
            if ((bool)!worksheet.Cells["p" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.InvoiceStatus)) return false;
            if ((bool)!worksheet.Cells["q" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.InvoiceCheckResult)) return false;

            return true;
        }
    }
}
