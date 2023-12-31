﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết chứng từ được ghi vào sổ Thủ kho
/// </summary>
public partial class IninventoryBookDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid InventoryBookDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid? InventoryBookId { get; set; }

    /// <summary>
    /// RefDetailID của chứng từ gốc
    /// </summary>
    public Guid? RefDetailId { get; set; }

    /// <summary>
    /// Kho
    /// </summary>
    public Guid? StockId { get; set; }

    /// <summary>
    /// Lưu giá trị từ kho khi chứng từ là chuyển kho
    /// </summary>
    public Guid? FromStockId { get; set; }

    /// <summary>
    /// Lưu giá trị đến kho khi chuyển kho
    /// </summary>
    public Guid? ToStockId { get; set; }

    /// <summary>
    /// Vật tư
    /// </summary>
    public Guid? InventoryItemId { get; set; }

    /// <summary>
    /// Tên hàng
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// Số lượng nhập kho
    /// </summary>
    public decimal? InwardQuantity { get; set; }

    /// <summary>
    /// Số lượng thực thủ kho nhập kho
    /// </summary>
    public decimal? ActualInwardQuantity { get; set; }

    /// <summary>
    /// Số lượng thực thủ kho xuất kho
    /// </summary>
    public decimal? OutwardQuantity { get; set; }

    /// <summary>
    /// Số lượng xuất kho
    /// </summary>
    public decimal? ActualOutwardQuantity { get; set; }

    /// <summary>
    /// Số lô
    /// </summary>
    public string? LotNo { get; set; }

    /// <summary>
    /// Ngày hết hạn
    /// </summary>
    public DateTime? ExpiryDate { get; set; }

    /// <summary>
    /// Ghi chú
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Đơn vị tính chính
    /// </summary>
    public Guid? MainUnitId { get; set; }

    /// <summary>
    /// Đơn giá
    /// </summary>
    public decimal MainUnitPrice { get; set; }

    /// <summary>
    /// Số lượng nhập kho
    /// </summary>
    public decimal MainActualInwardQuantity { get; set; }

    /// <summary>
    /// Số lượng xuất kho
    /// </summary>
    public decimal MainActualOutwardQuantity { get; set; }

    /// <summary>
    /// Tỷ lệ chuyển đổi ra đơn vị chính
    /// </summary>
    public decimal MainConvertRate { get; set; }

    /// <summary>
    /// Toán tử quy đổi *=nhân;/=chia
    /// </summary>
    public string? ExchangeRateOperator { get; set; }

    /// <summary>
    /// Thứ tự dòng
    /// </summary>
    public int? SortOrder { get; set; }

    public virtual Stock? FromStock { get; set; }

    public virtual IninventoryBook? InventoryBook { get; set; }

    public virtual InventoryItem? InventoryItem { get; set; }

    public virtual Unit? MainUnit { get; set; }

    public virtual Stock? Stock { get; set; }

    public virtual Stock? ToStock { get; set; }

    public virtual Unit? Unit { get; set; }
}