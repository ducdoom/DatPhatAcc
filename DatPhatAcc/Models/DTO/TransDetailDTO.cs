using CommunityToolkit.Mvvm.ComponentModel;
using DatPhatAcc.AccountingDbContext;
using System.Collections.ObjectModel;

namespace DatPhatAcc.Models.DTO
{
   
    public class TransDetailDTO: ObservableObject
    {
        private decimal _price;
        private decimal _totalPrice;

        //public string TransactionId { get; set; } = string.Empty;
        public string GoodId { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;

        private int _quantity = 0;
        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                _totalPrice = _quantity * _price; // When Quantity changes, update TotalPrice
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalPrice));              
            }
        }

        public decimal Price
        {
            get => _quantity > 0 ? _totalPrice / _quantity : 0; // Calculate Price based on TotalPrice and Quantity
            set
            {
                _price = value;
                _totalPrice = _quantity * _price; // When Price changes, update TotalPrice
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalPrice));
            }
        }


        private int _vatValue = 0;
        public int VatValue
        {
            get => _vatValue;
            set
            {
                _vatValue = value;
                OnPropertyChanged();
            }
        }

        private decimal _totalPriceVat = decimal.Zero;
        public decimal TotalPriceVat
        {
            get => _totalPriceVat;
            set 
            {
                _totalPriceVat = value;
                _totalPrice = _totalPriceVat / (1m + _vatValue / 100m); // When TotalPriceVat changes, update TotalPrice
                _price = _quantity > 0 ? _totalPrice / _quantity : 0; // When TotalPriceVat changes, update Price
                OnPropertyChanged();
                OnPropertyChanged(nameof(TotalPrice));
                OnPropertyChanged(nameof(Price));
            }
            
        }

        public decimal TotalPrice
        {
            get => _totalPrice;
            set
            {
                _totalPrice = value;
                _price = _quantity > 0 ? _totalPrice / _quantity : 0; // When TotalPrice changes, update Price
                OnPropertyChanged();
                OnPropertyChanged(nameof(Price));
            }
        }
    }
}
