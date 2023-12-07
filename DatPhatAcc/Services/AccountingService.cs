﻿using DatPhatAcc.AccountingDbContext;
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

        public async Task<IEnumerable<TransactionOverview>> SearchTransactionOverview(DateTime fromDate, DateTime toDate, IEnumerable<CustomerDTO> customerDTOs, TransType transType)
        {
            int fromTranDate = Convert.ToInt32(fromDate.ToTranDate());
            int toTranDate = Convert.ToInt32(toDate.ToTranDate());

            using ACCOUNTINGContext accountingContext = new();
            var transactionOverviews = await accountingContext.Transactions.Where(
                 x => Convert.ToInt32(x.TransDate) >= fromTranDate
                 && Convert.ToInt32(x.TransDate) <= toTranDate
                 && (customerDTOs.Select(x => x.CustomerId).Contains(x.ImportId) || customerDTOs.Select(x => x.CustomerId).Contains(x.ExportId))
                 && x.TransCode.Equals(transType.TransCode)
                 && x.Status.Equals("1")
                 )
                 .Select(x => new TransactionOverview
                 {
                     TransactionId = x.TransactionId,
                     TransCode = x.TransCode,
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

        public async Task<IEnumerable<ListVat>> GetListVatsAsync()
        {
            using ACCOUNTINGContext accountingContext = new();
            return await accountingContext.ListVats.ToArrayAsync();
        }

        public async Task<IEnumerable<TransDetailDTO>> GetTransDetailDTOsAsync(IEnumerable<TransactionOverview> transactionOverviews, int vatValue)
        {
            using ACCOUNTINGContext accountingContext = new();

            TransactionOverview transaction = transactionOverviews.First();


            var transDetails = await accountingContext.TransDetails
                .Where(x => transactionOverviews.Select(x => x.TransactionId).Contains(x.TransactionId))
                .Join(accountingContext.Goods, transDetail => transDetail.GoodId, good => good.GoodId,
                (transDetail, good) => new TransDetailDTO()
                {
                    TransactionId = transDetail.TransactionId,
                    GoodId = transDetail.GoodId,
                    ShortName = good.ShortName,
                    Quantity = transDetail.Quantity ?? 0,
                    VatValue = vatValue,
                    TotalPriceVat = (transaction.TransCode.Equals("01") ? transDetail.TotalImpPriceVat : transDetail.TotalExpPriceVat) ?? 0
                })
                .ToArrayAsync();
            return transDetails;
        }
    }
}
