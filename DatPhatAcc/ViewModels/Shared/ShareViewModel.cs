using CommunityToolkit.Mvvm.ComponentModel;
using DatPhatAcc.AccountingDbContext;
using DatPhatAcc.Models;
using System.Collections.ObjectModel;

namespace DatPhatAcc.ViewModels.Shared
{
    public partial class ShareViewModel : ObservableObject
    {
        public enum TransactionType { Retail, Inner }
        public ShareViewModel()
        {
            Init();
        }

        [ObservableProperty]
        private ObservableCollection<ListVat> listVats = new();

        [ObservableProperty]
        private ObservableCollection<SyncTransactionType> syncTransactionTypes = new();

        private void Init()
        {
            InitListVat();
            InitSyncTransactionType();
        }

        private void InitListVat()
        {
            ObservableCollection<ListVat> listVats = new()
            {
                new ListVat { VatId = "1", VatValue = 0,  VatName = "0" },
                new ListVat { VatId = "2", VatValue = 5,  VatName = "5" },
                new ListVat { VatId = "3", VatValue = 8, VatName = "8" },
                new ListVat { VatId = "4", VatValue = 10, VatName = "10" },
                new ListVat { VatId = "5", VatValue = 0, VatName = "K" },
            };

            ListVats = listVats;
        }

        private void InitSyncTransactionType()
        {
            ObservableCollection<SyncTransactionType> transactionTypes = new()
            {
                new SyncTransactionType{ TransactionTypeId = "1", TransactionTypeName = "Xuất bán lẻ LTT" },
                new SyncTransactionType{ TransactionTypeId = "2", TransactionTypeName = "Xuất nội bộ" }
            };

            SyncTransactionTypes = transactionTypes;
        }

    }
}
