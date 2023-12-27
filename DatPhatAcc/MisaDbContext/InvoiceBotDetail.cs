﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class InvoiceBotDetail
{
    public Guid InvoiceDetailId { get; set; }

    public string Id { get; set; }

    public int LineNumber { get; set; }

    public string ItemCode { get; set; }

    public string ItemName { get; set; }

    public string UnitName { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal AmountWithoutVat { get; set; }

    public decimal? VatRate { get; set; }

    public decimal VatAmount { get; set; }

    public decimal DiscountRate { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal Amount { get; set; }

    public bool IsPromotion { get; set; }

    public decimal AmountOc { get; set; }

    public decimal DiscountAmountOc { get; set; }

    public decimal VatAmountOc { get; set; }

    public decimal AmountWithoutVatOc { get; set; }

    public decimal? TaxReductionAmount { get; set; }

    public decimal? TaxReductionAmountOc { get; set; }

    public decimal? VatrateOther { get; set; }

    public string LotNo { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public bool IsTradeDiscount { get; set; }

    public int? Kind { get; set; }

    public virtual InvoiceBot IdNavigation { get; set; }
}