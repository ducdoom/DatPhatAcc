﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng chi tiết Đơn giá mua của VTHH
/// </summary>
public partial class InventoryItemPurchaseUnitPrice
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
    /// Loại tiền
    /// </summary>
    public string? CurrencyId { get; set; }

    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// Đơn giá mua
    /// </summary>
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// Thứ tự
    /// </summary>
    public int? SortOrder { get; set; }

    public virtual Ccy? Currency { get; set; }

    public virtual InventoryItem InventoryItem { get; set; } = null!;

    public virtual Unit? Unit { get; set; }
}