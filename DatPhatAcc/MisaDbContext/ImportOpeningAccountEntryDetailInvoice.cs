﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ImportOpeningAccountEntryDetailInvoice
{
    public Guid RefDetailId { get; set; }

    public Guid? RefId { get; set; }

    public DateTime? InvDate { get; set; }

    public string? InvNo { get; set; }

    public DateTime? DueDate { get; set; }

    public Guid? EmployeeId { get; set; }

    public string? EmployeeCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal InvoiceAmountOc { get; set; }

    public decimal InvoiceAmount { get; set; }

    public decimal AmountOc { get; set; }

    public decimal Amount { get; set; }

    public int SortOrder { get; set; }

    public bool IsAutoGenerate { get; set; }

    public decimal PayAmountOc { get; set; }

    public decimal PayAmount { get; set; }

    public virtual ImportOpeningAccountEntry? Ref { get; set; }
}