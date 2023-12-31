﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng nhóm HHDV chịu thuế TTĐB
/// </summary>
public partial class InventoryItemCategorySpecialTax
{
    /// <summary>
    /// PK nhóm thuế TTĐB
    /// </summary>
    public Guid InventoryCategorySpecialTaxId { get; set; }

    /// <summary>
    /// Mã nhóm HH chịu thuế TTĐB
    /// </summary>
    public string InventoryCategorySpecialTaxCode { get; set; } = null!;

    /// <summary>
    /// Tên nhóm HH chịu thuế TTĐB
    /// </summary>
    public string InventoryCategorySpecialTaxName { get; set; } = null!;

    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// Thuế suất thuế TTĐB
    /// </summary>
    public decimal TaxRate { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

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
    public int Grade { get; set; }

    /// <summary>
    /// Thuộc hệ thống. VD: Vật tư, Hàng hóa, Dịch vụ được thiết lập là IsSystem=TRUE.
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

    public string? SubsectionCode { get; set; }

    public string? SubsectionName { get; set; }

    public virtual ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();
}