﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Ta03gtgtDetail
{
    public Guid RefDetailId { get; set; }

    public Guid RefId { get; set; }

    public Guid? VoucherRefId { get; set; }

    public int? VoucherRefType { get; set; }

    public DateTime? VoucherRefDate { get; set; }

    public string? VoucherRefNo { get; set; }

    public Guid? VoucherBranchId { get; set; }

    public string? InvoiceTemplate { get; set; }

    public string? InvSeries { get; set; }

    public string? InvNo { get; set; }

    public DateTime? InvDate { get; set; }

    public string? JournalMemo { get; set; }

    public Guid? AccountObjectId { get; set; }

    public string? AccountObjectName { get; set; }

    public string? AccountObjectCode { get; set; }

    public string? AccountObjectAddress { get; set; }

    public decimal Amount { get; set; }

    public bool? IsRevenue { get; set; }

    public int SortOrder { get; set; }

    public DateTime? VoucherPostedDate { get; set; }

    public Guid? InvoiceRefId { get; set; }

    public virtual Tadeclaration Ref { get; set; } = null!;
}