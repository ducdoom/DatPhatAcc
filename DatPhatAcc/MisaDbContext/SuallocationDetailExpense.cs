﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng xác định mức chi phí Phân bổ CCDC
/// </summary>
public partial class SuallocationDetailExpense
{
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// FK - ID
    /// </summary>
    public Guid RefId { get; set; }

    public Guid SupplyId { get; set; }

    /// <summary>
    /// Tổng số tiền phân bổ
    /// </summary>
    public decimal TotalAllocationAmount { get; set; }

    /// <summary>
    /// Số tiền phân bổ CCDC đang dùng
    /// </summary>
    public decimal AllocationAmount { get; set; }

    /// <summary>
    /// Giá trị còn lại của CCDC giảm trong kỳ
    /// </summary>
    public decimal RemainingAmount { get; set; }

    public int? SortOrder { get; set; }

    public Guid? SupplyCategoryId { get; set; }

    public virtual Suallocation Ref { get; set; } = null!;

    public virtual Suincrement Supply { get; set; } = null!;
}