﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu thông tin số lượng thực xuất, số lượng thực nhập khi bỏ ghi trên sổ thủ kho
/// </summary>
public partial class IninventoryBookDetailUnpost
{
    /// <summary>
    /// Key
    /// </summary>
    public Guid InventoryBookDetailUnPostId { get; set; }

    /// <summary>
    /// RefID của chứng từ gốc
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// RefDetailID của chứng từ gốc
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// Trạng thái ghi vào vào sổ quản trị
    /// </summary>
    public bool IsPostedManagement { get; set; }

    /// <summary>
    /// Số lượng thực thủ kho nhập kho
    /// </summary>
    public decimal ActualInwardQuantity { get; set; }

    /// <summary>
    /// Số lượng xuất kho của thủ kho xuất kho
    /// </summary>
    public decimal ActualOutwardQuantity { get; set; }

    /// <summary>
    /// Số lượng thực thủ kho nhập kho theo đơn vị tính chính
    /// </summary>
    public decimal MainActualInwardQuantity { get; set; }

    /// <summary>
    /// Số lượng xuất kho của thủ kho xuất kho theo đơn vị tính chính
    /// </summary>
    public decimal MainActualOutwardQuantity { get; set; }
}