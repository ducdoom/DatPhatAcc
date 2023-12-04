using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Services
{
    public class AccountingService
    {
        private AccountingDbContext.ACCOUNTINGContext _accountingContext;
        public AccountingService()
        {
            _accountingContext = new(); 
        }

        public async Task<List<AccountingDbContext.Customer>> GetCustomers()
        {
            return await _accountingContext.Customers
                
                .ToListAsync();
        }


    }
}
