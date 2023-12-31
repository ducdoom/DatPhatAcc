﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ManageSize
{
    public Guid ManageSizeId { get; set; }

    /// <summary>
    /// ID chứng từ
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// ID dòng chi tiết của chứng từ
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// Loại chứng từ
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Mã VTHH
    /// </summary>
    public Guid InventoryItemId { get; set; }

    /// <summary>
    /// Chiều dài
    /// </summary>
    public decimal PanelLengthQuantity { get; set; }

    /// <summary>
    /// Chiều rộng
    /// </summary>
    public decimal PanelWidthQuantity { get; set; }

    /// <summary>
    /// Chiều cao
    /// </summary>
    public decimal PanelHeightQuantity { get; set; }

    /// <summary>
    /// Bán kính
    /// </summary>
    public decimal PanelRadiusQuantity { get; set; }

    /// <summary>
    /// Lượng
    /// </summary>
    public decimal PanelQuantity { get; set; }

    /// <summary>
    /// Số lượng nhập
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Mã kho
    /// </summary>
    public Guid? StockId { get; set; }

    public decimal InwardPanelQuantity { get; set; }

    public decimal OutwardPanelQuantity { get; set; }
}