﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class GlvoucherDetailRevenueAllocation
{
    public Guid RefDetailId { get; set; }

    public Guid RefId { get; set; }

    public Guid PreReceiptRevenueId { get; set; }

    public decimal TotalAllocationAmount { get; set; }

    public Guid? AllocationObjectId { get; set; }

    public int? AllocationObjectType { get; set; }

    public decimal AllocationRate { get; set; }

    public decimal AllocationAmount { get; set; }

    public string? AllocationAccount { get; set; }

    public int SortOrder { get; set; }

    public virtual Account? AllocationAccountNavigation { get; set; }

    public virtual PreReceiptRevenue PreReceiptRevenue { get; set; } = null!;

    public virtual Glvoucher Ref { get; set; } = null!;
}