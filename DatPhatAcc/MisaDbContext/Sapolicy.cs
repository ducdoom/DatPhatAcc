﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng master chứa danh sách các chính sách giá bán hàng
/// </summary>
public partial class Sapolicy
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid SapolicyId { get; set; }

    /// <summary>
    /// Tên chính sách giá
    /// </summary>
    public string PolicyName { get; set; } = null!;

    /// <summary>
    /// Ngừng áp dụng
    /// </summary>
    public bool Inactive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    /// <summary>
    /// Mô tả chi tiết
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public string? CurrencyId { get; set; }

    public int? IndexUnitConvert { get; set; }

    /// <summary>
    /// Có thiết lập chiết khấu cho chính sách giá hay không
    /// </summary>
    public bool? IsSetDiscount { get; set; }

    public int? ProductType { get; set; }

    public int? SaleGroupType { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int? PolicyType { get; set; }

    public virtual Ccy? Currency { get; set; }

    public virtual ICollection<SapolicySaleGroup> SapolicySaleGroups { get; set; } = new List<SapolicySaleGroup>();
}