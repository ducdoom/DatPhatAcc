﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết Loại quy cách
/// </summary>
public partial class InventoryItemDetailSerialType
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid InventoryItemDetailId { get; set; }

    /// <summary>
    /// FK: KHóa ngoại
    /// </summary>
    public Guid InventoryItemId { get; set; }

    /// <summary>
    /// Tên mã quy cách
    /// </summary>
    public string SerialTypeName { get; set; }

    /// <summary>
    /// Cho phép trùng
    /// </summary>
    public bool AllowDuplicate { get; set; }

    /// <summary>
    /// Có được chọn hay không?
    /// </summary>
    public bool Selected { get; set; }

    /// <summary>
    /// Tên hiển thị
    /// </summary>
    public string DisplayName { get; set; }

    /// <summary>
    /// Thứ tự
    /// </summary>
    public int? SortOrder { get; set; }

    public virtual InventoryItem InventoryItem { get; set; }
}