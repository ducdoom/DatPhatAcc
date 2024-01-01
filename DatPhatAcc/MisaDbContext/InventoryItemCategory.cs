﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Nhóm VTHH
/// </summary>
public partial class InventoryItemCategory
{
    /// <summary>
    /// PK Loại vật tư
    /// </summary>
    public Guid InventoryCategoryId { get; set; }

    /// <summary>
    /// Mã cha
    /// </summary>
    public Guid? ParentId { get; set; }

    public string? MisacodeId { get; set; }

    /// <summary>
    /// Là cha
    /// </summary>
    public bool IsParent { get; set; }

    /// <summary>
    /// Cấp bậc
    /// </summary>
    public int? Grade { get; set; }

    /// <summary>
    /// Mã loại vật tư
    /// </summary>
    public string InventoryCategoryCode { get; set; } = null!;

    /// <summary>
    /// Tên loại vật tư
    /// </summary>
    public string InventoryCategoryName { get; set; } = null!;

    /// <summary>
    /// Mô tả loại hàng hóa
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Thuộc hệ thống
    /// </summary>
    public bool IsSystem { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    /// <summary>
    /// Cột dùng để sort trên báo cáo. Không sử dụng trên giao diện.
    /// </summary>
    public string? SortMisacodeId { get; set; }
}