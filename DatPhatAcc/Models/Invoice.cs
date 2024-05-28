using System.Globalization;
using System.Text.RegularExpressions;

namespace DatPhatAcc.Models
{
    public class Invoice
    {
        public int RowNumber { get; set; } = 0;
        public string InvoiceTemplateCode { get; set; } = string.Empty;
        public string InvoiceCode { get; set; } = string.Empty;
        public string InvoiceSeries => string.Concat(InvoiceTemplateCode, InvoiceCode);
        public string InvoiceSeriesManual
        {
            get
            {
                return InvoiceSeries;
            }
            set
            {
                if (IsValidFormat(value))
                {
                    //2C24TQP
                    InvoiceTemplateCode = value.Substring(0, 1); // 2
                    InvoiceCode = value.Substring(1, 6); // C24TQP
                }
                else
                {
                    InvoiceTemplateCode = string.Empty;
                    InvoiceCode = string.Empty;
                }
            }
        }
        public string InvoiceNumber { get; set; } = string.Empty;
        public string InvoiceDateString { get; set; } = string.Empty;

        public DateTime InvoiceDate => DateTime.ParseExact(InvoiceDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        public string SellerTaxCode { get; set; } = string.Empty;
        public string SellerName { get; set; } = string.Empty;
        public string SellerAddress { get; set; } = string.Empty;
        public double TotalAmountWithoutTax => TotalAmountVAT - TotalTaxAmount;
        public double TotalTaxAmount { get; set; } = 0;
        public double TotalDiscountAmount { get; set; } = 0;
        public double TotalFeeAmount { get; set; } = 0;
        public double TotalAmountVAT { get; set; } = 0;
        public string CurrencyUnit { get; set; } = string.Empty;
        public string InvoiceStatus { get; set; } = string.Empty;
        public string InvoiceCheckResult { get; set; } = string.Empty;

        public int InvoiceCount { get; set; } = 0;
        public bool Checked { get; set; } = false;

        private bool IsValidFormat(string input)
        {
            string pattern = @"^\d[A-Z]\d{2}[A-Z][A-Z]{2}$";
            return Regex.IsMatch(input, pattern);
        }
    }
}
