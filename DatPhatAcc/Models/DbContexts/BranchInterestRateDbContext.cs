using Microsoft.EntityFrameworkCore;

namespace DatPhatAcc.Models.DbContext
{
    public class BranchInterestRateDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<BranchInterestRate> BranchInterestRate { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = InitDataFileName();
            optionsBuilder.UseSqlite(@$"Data Source={path}");
        }

        private string InitDataFileName()
        {
            //folder c document
            string documentFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string appFolder = System.IO.Path.Combine(documentFolder, "DatPhatAcc");
            string FileName = "AppDb.db";
            string fullPath = System.IO.Path.Combine(documentFolder, appFolder, FileName);

            if (!System.IO.Directory.Exists(appFolder))
            {
                System.IO.Directory.CreateDirectory(appFolder);

                //Copy file Resources\\DB\\AppDb.db to folder DatPhatAcc
                string sourceFile = System.IO.Path.Combine("Resources", "DB", "AppDb.db");
                string destFile = fullPath;
                System.IO.File.Copy(sourceFile, destFile, true);
            }

            return fullPath;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchInterestRate>().HasKey(b => b.BranchId);
        }
    }
}
