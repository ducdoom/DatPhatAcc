using System.Globalization;

namespace DatPhatAcc.Models
{
    public class Invoice
    {
        public int RowNumber { get; set; } = 0;
        public string InvoiceTemplateCode { get; set; } = string.Empty;
        public string InvoiceCode { get; set; } = string.Empty;
        public string InvoiceSeries => string.Concat(InvoiceTemplateCode, InvoiceCode);
        public string InvoiceNumber { get; set; } = string.Empty;
        public string InvoiceDateString { get; set; } = string.Empty;

        public DateTime InvoiceDate => DateTime.ParseExact(InvoiceDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        public string SellerTaxCode { get; set; } = string.Empty;
        public string SellerName { get; set; } = string.Empty;
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

    }
}
