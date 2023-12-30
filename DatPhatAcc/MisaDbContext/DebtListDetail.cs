﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết đợt thu nợ
/// </summary>
public partial class DebtListDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid DebtListDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid DebtListId { get; set; }

    /// <summary>
    /// Khách hàng
    /// </summary>
    public Guid AccountObjectId { get; set; }

    /// <summary>
    /// Kết quả thu nợ
    /// </summary>
    public string? ResultDebt { get; set; }

    /// <summary>
    /// Ngày hẹn trả
    /// </summary>
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    /// Ghi chú
    /// </summary>
    public string? Description { get; set; }

    public virtual AccountObject AccountObject { get; set; } = null!;

    public virtual DebtList DebtList { get; set; } = null!;
}