﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Danh mục Biểu thuế tài nguyên
/// </summary>
public partial class ResourcesTaxTable
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid ResourcesTaxTableId { get; set; }

    /// <summary>
    /// Mã biểu thuế
    /// </summary>
    public string ResourcesTaxTableCode { get; set; }

    /// <summary>
    /// Tên biểu thuế
    /// </summary>
    public string ResourcesTaxTableName { get; set; }

    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public string Unit { get; set; }

    /// <summary>
    /// Thuế suất
    /// </summary>
    public decimal? TaxRate { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }

    /// <summary>
    /// Thuộc hệ thống
    /// </summary>
    public bool IsSystem { get; set; }

    /// <summary>
    /// Là mục chi cha
    /// </summary>
    public bool IsParent { get; set; }

    /// <summary>
    /// Mục chi cha
    /// </summary>
    public Guid? ParentId { get; set; }

    public string MisacodeId { get; set; }

    /// <summary>
    /// Cấp bậc
    /// </summary>
    public int? Grade { get; set; }

    public string ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Cột dùng để sort trên báo cáo. Không sử dụng trên giao diện.
    /// </summary>
    public string SortMisacodeId { get; set; }

    public decimal? Vatprice { get; set; }

    public string ResourcesTaxTableCodeSort { get; set; }

    public string SectionCode { get; set; }

    public string SubsectionCode { get; set; }

    public string BaseOn { get; set; }

    public DateTime? Vbqpdate { get; set; }
}