using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Converters;
using DatPhatAcc.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace DatPhatAcc.Services
{
    public class AccountingService
    {
        //private AccountingDbContext.ACCOUNTINGContext _accountingContext;
        public AccountingService()
        {

        }

        public async Task<IEnumerable<CustomerDTO>> GetCustomers()
        {
            using ACCOUNTINGContext accountingContext = new();
            var customerList = await accountingContext.Customers
                .Select(x => new CustomerDTO
                {
                    CustomerId = x.CustomerId,
                    CustomerName = x.CustomerName,
                    TaxCode = x.Taxcode
                })
                .ToArrayAsync();

            return customerList;
        }

        public async Task<IEnumerable<TransactionOverview>> SearchPurchaseTransactionOverview(DateTime fromDate, DateTime toDate, IEnumerable<CustomerDTO> customerDTOs, TransType transType)
        {
            int fromTranDate = Convert.ToInt32(fromDate.ToTranDate());
            int toTranDate = Convert.ToInt32(toDate.ToTranDate());

            using ACCOUNTINGContext accountingContext = new();
            var transactionOverviews = await accountingContext.Transactions.Where(
                 x => Convert.ToInt32(x.TransDate) >= fromTranDate
                 && Convert.ToInt32(x.TransDate) <= toTranDate
                 && customerDTOs.Select(x => x.CustomerId).Contains(x.ExportId)
                 && x.TransCode.Equals(transType.TransCode) //import nhập hàng
                 && x.Status.Equals("1") //đã duyệt                 
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

        public async Task<IEnumerable<TransType>> GetTransTypesAsync()
        {
            using ACCOUNTINGContext accountingContext = new();
            return await accountingContext.TransTypes.ToArrayAsync();
        }
    }
}
