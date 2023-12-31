﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết tờ khai thuế 01/TTĐB
/// </summary>
public partial class Ta01ttdbDetail
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
    /// PK
    /// </summary>
    public Guid AppendixId { get; set; }

    /// <summary>
    /// Số thứ tự
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Mã chỉ tiều
    /// </summary>
    public string? ItemCode { get; set; }

    /// <summary>
    /// Tên chỉ tiêu
    /// </summary>
    public string? ItemName { get; set; }

    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// Sản lượng tiêu thụ
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Doanh số bán (chưa có thuế GTGT)
    /// </summary>
    public decimal? TurnOverAmount { get; set; }

    /// <summary>
    /// Giá tính thuế TTĐB
    /// </summary>
    public decimal? SpecialTaxTurnOverAmount { get; set; }

    /// <summary>
    /// Thuế suất (%)
    /// </summary>
    public decimal? TaxRate { get; set; }

    /// <summary>
    /// Thuế TTĐB được khấu trừ
    /// </summary>
    public decimal? SpecialTaxDeductionAmount { get; set; }

    /// <summary>
    /// Thuế TTĐB phải nộp
    /// </summary>
    public decimal? SpecialTaxAmount { get; set; }

    /// <summary>
    /// Nhóm
    /// </summary>
    public string? GroupName { get; set; }

    public decimal? OffsetTaxAmount { get; set; }

    public decimal? RemainingSpecialTaxAmount { get; set; }

    public virtual TadeclarationAppendix Appendix { get; set; } = null!;
}