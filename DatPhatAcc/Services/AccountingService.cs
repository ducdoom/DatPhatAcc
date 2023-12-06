using DatPhatAcc.Converters;
using DatPhatAcc.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace DatPhatAcc.Services
{
    public class AccountingService
    {
        private AccountingDbContext.ACCOUNTINGContext _accountingContext;
        public AccountingService()
        {
            _accountingContext = new();
        }

        public async Task<IEnumerable<CustomerDTO>> GetCustomers()
        {
            var customerList = await _accountingContext.Customers
                .Select(x => new CustomerDTO
                {
                    CustomerId = x.CustomerId,
                    CustomerName = x.CustomerName,
                    TaxCode = x.Taxcode
                })
                .ToArrayAsync();

            return customerList;
        }

        public async Task<IEnumerable<TransactionOverview>> SearchTransactionOverview(DateTime fromDate, DateTime toDate)
        {
            int fromTranDate = Convert.ToInt32(fromDate.ToTranDate());
            int toTranDate = Convert.ToInt32(toDate.ToTranDate());

            var transactionOverviews = await _accountingContext.Transactions.Where(
                 x => Convert.ToInt32(x.TransDate) >= fromTranDate
                 && Convert.ToInt32(x.TransDate) <= toTranDate
                 )
                 .Select(x => new TransactionOverview
                 {
                     TransactionId = x.TransactionId,
                     TranDate = x.TransDate,
                     TotalPriceVat = x.TotalPriceVat
                 })
                 .OrderBy(x => x.TranDate)
                 .ToArrayAsync();

            return transactionOverviews;
        }


    }
}
