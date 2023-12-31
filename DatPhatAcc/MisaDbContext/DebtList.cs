﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Danh sách đợt thu nợ
/// </summary>
public partial class DebtList
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid DebtListId { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid BranchId { get; set; }

    /// <summary>
    /// Tên đợt thu nợ
    /// </summary>
    public string DebtListName { get; set; } = null!;

    /// <summary>
    /// Từ ngày
    /// </summary>
    public DateTime FromDate { get; set; }

    /// <summary>
    /// Đến ngày
    /// </summary>
    public DateTime ToDate { get; set; }

    /// <summary>
    /// Tổng công nợ
    /// </summary>
    public decimal TotalReceiptableAmount { get; set; }

    /// <summary>
    /// Mục tiêu thu được (%)
    /// </summary>
    public decimal TargetPercent { get; set; }

    /// <summary>
    /// Mục tiêu thu được (Số tiền)
    /// </summary>
    public decimal TargetAmount { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual OrganizationUnit Branch { get; set; } = null!;

    public virtual ICollection<DebtListDetail> DebtListDetails { get; set; } = new List<DebtListDetail>();
}