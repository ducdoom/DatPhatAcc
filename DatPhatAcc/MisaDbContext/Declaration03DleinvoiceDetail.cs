﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Declaration03DleinvoiceDetail
{
    public Guid RefDetailId { get; set; }

    public Guid? RefId { get; set; }

    public int? SortOrder { get; set; }

    public string? LineOrderNo { get; set; }

    public bool IsGroupRow { get; set; }

    public string? GroupCode { get; set; }

    public string? InvoiceTypeName { get; set; }

    public string? InvTemplateNo { get; set; }

    public decimal? Vatrate { get; set; }

    public string? InvSeries { get; set; }

    public string? InvNo { get; set; }

    public DateOnly? InvDate { get; set; }

    public string? Buyer { get; set; }

    public string? BuyerTaxCode { get; set; }

    public decimal? RevenueAmount { get; set; }

    public decimal? Vatamount { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? VoucherRefType { get; set; }

    public Guid? VoucherRefId { get; set; }

    public virtual Declaration03Dleinvoice? Ref { get; set; }
}