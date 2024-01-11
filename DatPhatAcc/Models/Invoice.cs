namespace DatPhatAcc.Models
{
    public class Invoice
    {
        public int RowNumber { get; set; } = 0;
        public string InvoiceTemplateCode { get; set; } = string.Empty;
        public string InvoiceCode { get; set; } = string.Empty;
        public string InvoiceNumber { get; set; } = string.Empty;
        public string InvoiceDate { get; set; } = string.Empty;
        public string SellerTaxCode { get; set; } = string.Empty;
        public string SellerName { get; set; } = string.Empty;
        public double TotalAmountWithoutTax { get; set; } = 0;
        public double TotalTaxAmount { get; set; } = 0;
        public double TotalDiscountAmount { get; set; } = 0;
        public double TotalFeeAmount { get; set; } = 0;
        public double TotalAmount { get; set; } = 0;
        public string CurrencyUnit { get; set; } = string.Empty;
        public string InvoiceStatus { get; set; } = string.Empty;
        public string InvoiceCheckResult { get; set; } = string.Empty;

    }
}
