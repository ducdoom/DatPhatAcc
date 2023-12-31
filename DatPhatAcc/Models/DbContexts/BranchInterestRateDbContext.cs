using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Models.DbContext
{
    public class BranchInterestRateDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<BranchInterestRate> BranchInterestRate { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Resources\\DB\\AppDb.db";
            optionsBuilder.UseSqlite(@$"Data Source={path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchInterestRate>().HasKey(b => b.BranchId);
        }
    }
}
