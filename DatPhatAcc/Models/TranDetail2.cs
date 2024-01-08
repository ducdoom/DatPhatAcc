using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace DatPhatAcc.Models
{
    public partial class TranDetail2 : ObservableObject
    {
        public TranDetail2()
        {

        }

        [ObservableProperty]
        private ObservableCollection<InventoryItemSummary> inventoryItems = new();

        [ObservableProperty]
        private InventoryItemSummary selectedInventoryItem = new();

        [ObservableProperty]
        public string inventoryItemCode = string.Empty;
        [ObservableProperty]
        public string inventoryItemName = string.Empty;
        [ObservableProperty]
        public string unitName = string.Empty;
        [ObservableProperty]
        public string stockCode = string.Empty;
        [ObservableProperty]
        public decimal closingQuantity = 0;
        [ObservableProperty]
        public decimal costPriceUnit = 0;


        #region Events
        partial void OnSelectedInventoryItemChanged(InventoryItemSummary value)
        {
            InventoryItemCode = value.InventoryItemCode;
            InventoryItemName = value.InventoryItemName;
            UnitName = value.UnitName;
            StockCode = value.StockCode;
            ClosingQuantity = value.ClosingQuantity;
            CostPriceUnit = value.CostPriceUnit;
        }
        #endregion

        private decimal _quantity = 0;
        private decimal _price = 0;
        private decimal _totalAmount = 0;
        private decimal _vatRate = 0;
        private decimal _vatAmount = 0;
        private decimal _totalAmountVat = 0;

        public decimal Quantity
        {
            get => _quantity;
            set
            {
                SetProperty(ref _quantity, value);
                SetProperty(ref _totalAmount, _quantity * _price, nameof(TotalAmount)); // When Quantity changes, update TotalPrice
            }
        }

        public decimal Price
        {
            get => _quantity > 0 ? _totalAmount / _quantity : 0; // Calculate Price based on TotalPrice and Quantity
            set
            {
                SetProperty(ref _price, value);
                SetProperty(ref _totalAmount, _quantity * _price, nameof(TotalAmount)); // When Price changes, update TotalPrice
            }
        }

        public decimal TotalAmount
        {
            get => _totalAmount;
            set
            {
                SetProperty(ref _totalAmount, value);
                SetProperty(ref _price, _quantity > 0 ? _totalAmount / _quantity : 0, nameof(Price));
            }
        }

        public decimal TotalAmountVat
        {
            get => _totalAmountVat;
            set
            {
                SetProperty(ref _totalAmountVat, value);
                SetProperty(ref _totalAmount, _totalAmountVat / (1 + _vatRate / 100), nameof(TotalAmount));
                SetProperty(ref _price, _quantity > 0 ? _totalAmount / _quantity : 0, nameof(Price));
            }
        }

        public decimal VatRate
        {
            get => _vatRate;
            set
            {
                SetProperty(ref _vatRate, value);
                SetProperty(ref _totalAmount, _totalAmountVat / (1 + _vatRate / 100), nameof(TotalAmount));
                SetProperty(ref _price, _quantity > 0 ? _totalAmount / _quantity : 0, nameof(Price));
            }
        }

        public decimal VatAmount
        {
            get => _vatAmount;
            set
            {
                SetProperty(ref _vatAmount, _totalAmount * _vatRate / 100);
            }
        }



    }
}
