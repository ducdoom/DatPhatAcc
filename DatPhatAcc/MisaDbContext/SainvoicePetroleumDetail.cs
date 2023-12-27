﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SainvoicePetroleumDetail
{
    public Guid RefDetailId { get; set; }

    public Guid? RefId { get; set; }

    public int SortOrder { get; set; }

    public Guid? InventoryItemId { get; set; }

    public string Description { get; set; }

    public Guid? UnitId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal UnitPriceAfterTax { get; set; }

    public decimal AmountOc { get; set; }

    public decimal Amount { get; set; }

    public decimal AmountAfterTax { get; set; }

    public decimal DiscountRate { get; set; }

    public decimal DiscountAmountOc { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal? Vatrate { get; set; }

    public decimal? VatrateOther { get; set; }

    public decimal VatamountOc { get; set; }

    public decimal Vatamount { get; set; }

    public int? TacareerGroupId { get; set; }

    public Guid? MainUnitId { get; set; }

    public decimal MainUnitPrice { get; set; }

    public decimal MainConvertRate { get; set; }

    public decimal MainQuantity { get; set; }

    public string ExchangeRateOperator { get; set; }

    public Guid? PurchasePurposeId { get; set; }

    public string LotNo { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public bool NotInVatdeclaration { get; set; }

    public Guid? SavoucherRefId { get; set; }

    public Guid? SavoucherRefDetailId { get; set; }

    public string CustomField1 { get; set; }

    public string CustomField2 { get; set; }

    public string CustomField3 { get; set; }

    public string CustomField4 { get; set; }

    public string CustomField5 { get; set; }

    public string CustomField6 { get; set; }

    public string CustomField7 { get; set; }

    public string CustomField8 { get; set; }

    public string CustomField9 { get; set; }

    public string CustomField10 { get; set; }

    public virtual InventoryItem InventoryItem { get; set; }

    public virtual SainvoicePetroleum Ref { get; set; }

    public virtual TacareerGroup TacareerGroup { get; set; }

    public virtual Unit Unit { get; set; }
}