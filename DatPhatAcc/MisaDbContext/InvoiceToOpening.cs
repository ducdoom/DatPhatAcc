﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class InvoiceToOpening
{
    public Guid? VoucherRefId { get; set; }

    public Guid? BranchId { get; set; }

    public int? VoucherRefType { get; set; }

    public string AccountNumber { get; set; } = null!;

    public string? CurrencyId { get; set; }

    public Guid AccountObjectId { get; set; }

    public string? InvNo { get; set; }

    public DateTime? InvDate { get; set; }

    public decimal? AmountOc { get; set; }

    public decimal? Amount { get; set; }

    public Guid? OpnrefId { get; set; }

    public Guid? OpninvoiceId { get; set; }

    public int? DisplayOnBook { get; set; }

    public bool? IsDebtVoucher { get; set; }

    public bool? DetailByInvoice { get; set; }
}