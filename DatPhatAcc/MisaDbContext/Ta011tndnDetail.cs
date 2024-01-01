﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết phụ lục tờ khai thuế TNDN tạm tính, mẫu PL 01-1/TNDN
/// </summary>
public partial class Ta011tndnDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// FK - RefID của tờ khai thuế
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// ID phụ lục
    /// </summary>
    public Guid AppendixId { get; set; }

    /// <summary>
    /// Số thứ tự
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// Tên doanh nghiệp, Cơ sở sản xuất
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Mã số thuế
    /// </summary>
    public string? CompanyTaxCode { get; set; }

    /// <summary>
    /// Mã cơ quan thuế cấp Cục
    /// </summary>
    public string? TaxCompanyId { get; set; }

    /// <summary>
    /// Tên cơ quan thuế cấp Cục
    /// </summary>
    public string? TaxCompanyName { get; set; }

    /// <summary>
    /// Mã cơ quan thuế quản lý trực tiêp
    /// </summary>
    public string? TaxCompanyManagementId { get; set; }

    /// <summary>
    /// Tên cơ quan thuế quản lý trực tiêp
    /// </summary>
    public string? TaxCompanyManagementName { get; set; }

    /// <summary>
    /// Tỷ lệ phân bổ
    /// </summary>
    public decimal? AllocationRate { get; set; }

    /// <summary>
    /// Số tiền phân bổ
    /// </summary>
    public decimal? AllocationAmount { get; set; }

    public virtual TadeclarationAppendix Appendix { get; set; } = null!;
}