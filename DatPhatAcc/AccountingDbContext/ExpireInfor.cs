﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class ExpireInfor
{
    public int ItemId { get; set; }

    public Guid ExpireId { get; set; }

    public string TransactionId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public string? TransDate { get; set; }

    public string ExpireDate { get; set; } = null!;

    public string LotNumber { get; set; } = null!;

    public string ImportId { get; set; } = null!;

    public string ExportId { get; set; } = null!;

    public int Quantity { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? SyncTime { get; set; }
}