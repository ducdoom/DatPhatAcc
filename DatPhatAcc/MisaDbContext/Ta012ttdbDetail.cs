﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Phụ lục 01-2/TTDB: Bảng kê mua vào
/// </summary>
public partial class Ta012ttdbDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// FK - RefID của tờ khai thuế
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// ID phụ lục
    /// </summary>
    public Guid AppendixId { get; set; }

    /// <summary>
    /// Ký hiệu hóa đơn
    /// </summary>
    public string InvSeries { get; set; }

    /// <summary>
    /// Số hóa đơn
    /// </summary>
    public string InvNo { get; set; }

    /// <summary>
    /// Ngày phát hành
    /// </summary>
    public DateTime? InvDate { get; set; }

    /// <summary>
    /// Tên nguyên liệu đã nộp thuế TTDB
    /// </summary>
    public string InventoryItemName { get; set; }

    /// <summary>
    /// Số lượng đơn vị nguyên liệu mua vào/Số lượng
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Thuế TTĐB đã nộp
    /// </summary>
    public decimal? SpecialTaxAmount { get; set; }

    /// <summary>
    /// Thuế TTDB trên 1 đơn vị nguyên liệu mua vào
    /// </summary>
    public decimal? SpecialTaxAmountOnUnit { get; set; }

    /// <summary>
    /// Số thuế TTĐB đã được khấu trừ
    /// </summary>
    public decimal? DeductTaxAmount { get; set; }

    /// <summary>
    /// Số thuế TTDB chưa được khấu trừ đến kỳ này
    /// </summary>
    public decimal? RemainingTaxAmount { get; set; }

    /// <summary>
    /// Tên mặt hàng
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// Lượng nguyên liệu/1 đơn vị SP tiêu thụ
    /// </summary>
    public decimal? QuantityOnUnit { get; set; }

    /// <summary>
    /// Nhóm I hay nhóm II
    /// </summary>
    public string GroupName { get; set; }

    /// <summary>
    /// Số thứ tự
    /// </summary>
    public int? SortOrder { get; set; }

    public decimal? TotalDeductSpecialTaxAmount { get; set; }

    public virtual TadeclarationAppendix Appendix { get; set; }
}