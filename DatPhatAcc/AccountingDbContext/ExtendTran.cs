﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class ExtendTran
{
    public string TransactionId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}