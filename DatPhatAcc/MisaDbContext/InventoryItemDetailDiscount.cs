﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng chi tiết chiết khấu theo từng mặt hàng theo  số lượng
/// </summary>
public partial class InventoryItemDetailDiscount
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
    /// Từ số lượng
    /// </summary>
    public decimal FromQuantity { get; set; }

    /// <summary>
    /// Đến số lượng
    /// </summary>
    public decimal ToQuantity { get; set; }

    /// <summary>
    /// Tỷ lệ % chiết khấu
    /// </summary>
    public decimal DiscountRate { get; set; }

    /// <summary>
    /// Số tiền chiết khấu
    /// </summary>
    public decimal DiscountAmount { get; set; }

    /// <summary>
    /// Số thứ tự
    /// </summary>
    public int SortOrder { get; set; }

    public virtual InventoryItem InventoryItem { get; set; } = null!;
}