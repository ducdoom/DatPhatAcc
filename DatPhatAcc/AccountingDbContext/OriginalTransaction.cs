﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class OriginalTransaction
{
    public string TransactionId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string? OrgTransType { get; set; }

    public decimal? Debt { get; set; }

    public decimal? Have { get; set; }

    public string? TransDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? SyncTime { get; set; }
}