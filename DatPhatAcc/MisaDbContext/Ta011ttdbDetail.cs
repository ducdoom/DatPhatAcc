﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Phụ lục 01-1/TTDB: Bảng kê bán ra
/// </summary>
public partial class Ta011ttdbDetail
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
    /// RefID của chứng từ
    /// </summary>
    public Guid? VoucherRefId { get; set; }

    /// <summary>
    /// RefDetailID của chứng từ
    /// </summary>
    public Guid? VoucherRefDetailId { get; set; }

    /// <summary>
    /// RefType của chứng từ (bổ sung thêm cho mục đích DrillDown)
    /// </summary>
    public int? VoucherRefType { get; set; }

    /// <summary>
    /// Chi nhánh của chứng từ gốc
    /// </summary>
    public Guid? VoucherBranchId { get; set; }

    /// <summary>
    /// Ký hiệu hóa đơn
    /// </summary>
    public string? InvSeries { get; set; }

    /// <summary>
    /// Số hóa đơn
    /// </summary>
    public string? InvNo { get; set; }

    /// <summary>
    /// Ngày phát hành
    /// </summary>
    public DateTime? InvDate { get; set; }

    /// <summary>
    /// Người mua
    /// </summary>
    public string? AccountObjectName { get; set; }

    /// <summary>
    /// Tên hàng hóa, dịch vụ
    /// </summary>
    public string? InventoryItemName { get; set; }

    /// <summary>
    /// Tên nhóm HHDV
    /// </summary>
    public string? InventoryItemCategoryName { get; set; }

    /// <summary>
    /// Số lượng
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Đơn giá
    /// </summary>
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// Doanh số chưa thuế
    /// </summary>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Số thứ tự
    /// </summary>
    public int SortOrder { get; set; }

    public string? InventoryItemCategoryCode { get; set; }

    public string? Unit { get; set; }

    public virtual TadeclarationAppendix Appendix { get; set; } = null!;
}