﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// chi tiết định mức nguyên vật liệu
/// </summary>
public partial class InventoryItemDetailNorm
{
    /// <summary>
    /// PK Vật tư
    /// </summary>
    public Guid InventoryItemDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid InventoryItemId { get; set; }

    /// <summary>
    /// Mã nguyên vật liệu (Các VTHH có tính chất là VTHH)
    /// </summary>
    public Guid MaterialId { get; set; }

    /// <summary>
    /// Tên nguyên vật liệu
    /// </summary>
    public string? MaterialName { get; set; }

    /// <summary>
    /// Đơn giá
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Thành tiền
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Số thứ tự
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// Số lượng
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public Guid? UnitId { get; set; }

    public virtual InventoryItem InventoryItem { get; set; } = null!;

    public virtual Unit? Unit { get; set; }
}