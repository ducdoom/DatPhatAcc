using DatPhatAcc.Models;
using OfficeOpenXml;

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
            List<Invoice> invoices = new();

            for (int rowNumber = startRow; rowNumber <= lastRow; rowNumber++)
            {
                Invoice invoice = new()
                {
                    InvoiceTemplateCode = worksheet.Cells["b" + rowNumber].GetValue<string>() ?? string.Empty,
                    InvoiceCode = worksheet.Cells["c" + rowNumber].GetValue<string>() ?? string.Empty,
                    InvoiceNumber = worksheet.Cells["d" + rowNumber].GetValue<string>() ?? string.Empty,
                    InvoiceDateString = worksheet.Cells["e" + rowNumber].GetValue<string>() ?? string.Empty,
                    SellerTaxCode = worksheet.Cells["f" + rowNumber].GetValue<string>() ?? string.Empty,
                    SellerName = worksheet.Cells["g" + rowNumber].GetValue<string>() ?? string.Empty,
                    //TotalAmountWithoutTax = worksheet.Cells["h" + rowNumber].GetValue<double>(),
                    TotalTaxAmount = worksheet.Cells["i" + rowNumber].GetValue<double>(),
                    TotalDiscountAmount = worksheet.Cells["j" + rowNumber].GetValue<double>(),
                    TotalFeeAmount = worksheet.Cells["k" + rowNumber].GetValue<double>(),
                    TotalAmountVAT = worksheet.Cells["l" + rowNumber].GetValue<double>(),
                    CurrencyUnit = worksheet.Cells["m" + rowNumber].GetValue<string>() ?? string.Empty,
                    InvoiceStatus = worksheet.Cells["n" + rowNumber].GetValue<string>() ?? string.Empty,
                    InvoiceCheckResult = worksheet.Cells["o" + rowNumber].GetValue<string>() ?? string.Empty
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
            if ((bool)!worksheet.Cells["h" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.TotalAmountWithoutTax)) return false;
            if ((bool)!worksheet.Cells["i" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.TotalTaxAmount)) return false;
            if ((bool)!worksheet.Cells["j" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.TotalDiscountAmount)) return false;
            if ((bool)!worksheet.Cells["k" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.TotalFeeAmount)) return false;
            if ((bool)!worksheet.Cells["l" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.TotalAmount)) return false;
            if ((bool)!worksheet.Cells["m" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.CurrencyUnit)) return false;
            if ((bool)!worksheet.Cells["n" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.InvoiceStatus)) return false;
            if ((bool)!worksheet.Cells["o" + rowNumber].Value?.ToString().Equals(TCTInvoiceColumnName.InvoiceCheckResult)) return false;

            return true;
        }
    }
}
