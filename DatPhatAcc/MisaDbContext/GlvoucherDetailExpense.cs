﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng xác định chi phí của chứng từ: Phân bổ chi phí trả trước
/// </summary>
public partial class GlvoucherDetailExpense
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// ID chi phí trả trước
    /// </summary>
    public Guid PrepaidExpensesId { get; set; }

    /// <summary>
    /// Số tiền
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Số tiền chưa phân bổ
    /// </summary>
    public decimal RemainingAmount { get; set; }

    /// <summary>
    /// Số tiền phân bổ trong kỳ
    /// </summary>
    public decimal AllocationAmount { get; set; }

    public virtual PrepaidExpense PrepaidExpenses { get; set; } = null!;

    public virtual Glvoucher Ref { get; set; } = null!;
}