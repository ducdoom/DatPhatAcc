﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Ta01Tbvmtdetail
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
    /// ID phụ lục
    /// </summary>
    public Guid AppendixId { get; set; }

    /// <summary>
    /// Số thứ tự
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// Tên hàng hóa
    /// </summary>
    public string? InventoryItemName { get; set; }

    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// Số lượng
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Mức thuế
    /// </summary>
    public decimal TaxAmountLevel { get; set; }

    /// <summary>
    /// Thuế BVMT phải nộp trong kỳ
    /// </summary>
    public decimal TaxAmount { get; set; }

    /// <summary>
    /// Nhóm I, II, III
    /// </summary>
    public string GroupName { get; set; } = null!;

    public virtual Tadeclaration Ref { get; set; } = null!;
}