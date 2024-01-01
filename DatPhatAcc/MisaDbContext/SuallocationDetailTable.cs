﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng phân bổ chi phí CCDC
/// </summary>
public partial class SuallocationDetailTable
{
    public Guid RefDetailId { get; set; }

    public Guid RefId { get; set; }

    /// <summary>
    /// ID của CCDC
    /// </summary>
    public Guid SupplyId { get; set; }

    /// <summary>
    /// Chi phí phân bổ (Tổng giá trị phân bổ của 1 CCDC)
    /// </summary>
    public decimal TotalAllocationAmount { get; set; }

    /// <summary>
    /// Đối tượng phân bổ
    /// </summary>
    public Guid? AllocationObjectId { get; set; }

    /// <summary>
    /// Tỷ lệ phân bổ (%)
    /// </summary>
    public decimal AllocationRate { get; set; }

    /// <summary>
    /// Số tiền phân bổ cho từng đối tượng phân bổ
    /// </summary>
    public decimal AllocationAmount { get; set; }

    /// <summary>
    /// TK chi phí
    /// </summary>
    public string? CostAccount { get; set; }

    /// <summary>
    /// Sắp xếp
    /// </summary>
    public int SortOrder { get; set; }

    public Guid? ExpenseItemId { get; set; }

    public bool IsDetailBreak { get; set; }

    public virtual Account? CostAccountNavigation { get; set; }

    public virtual ExpenseItem? ExpenseItem { get; set; }

    public virtual Suallocation Ref { get; set; } = null!;

    public virtual Suincrement Supply { get; set; } = null!;
}