namespace DatPhatAcc.Models.DTO
{
    public class CustomerDTO
    {
        public bool IsSelected { get; set; } = false;
        public string CustomerId { get; set; } = string.Empty;
        public string TaxCode { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
    }
}
