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
        [NotifyPropertyChangedFor(nameof(InventoryItemCode))]
        [NotifyPropertyChangedFor(nameof(InventoryItemName))]
        [NotifyPropertyChangedFor(nameof(UnitName))]
        [NotifyPropertyChangedFor(nameof(StockCode))]
        [NotifyPropertyChangedFor(nameof(ClosingQuantity))]
        [NotifyPropertyChangedFor(nameof(CostPriceUnit))]
        [NotifyPropertyChangedFor(nameof(Quantity))]
        [NotifyPropertyChangedFor(nameof(Price))]
        [NotifyPropertyChangedFor(nameof(TotalAmount))]
        [NotifyPropertyChangedFor(nameof(VatRate))]
        [NotifyPropertyChangedFor(nameof(VatAmount))]
        [NotifyPropertyChangedFor(nameof(TotalAmountVat))]
        private InventoryItemSummary selectedInventoryItem = new();


        public string InventoryItemCode => SelectedInventoryItem.InventoryItemCode;
        public string InventoryItemName => SelectedInventoryItem.InventoryItemName;

        public string UnitName => SelectedInventoryItem.UnitName;
        public string StockCode => SelectedInventoryItem.StockCode;
        public decimal ClosingQuantity => SelectedInventoryItem.ClosingQuantity;
        public decimal CostPriceUnit => SelectedInventoryItem.CostPriceUnit;

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
