﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng kê sử dụng chứng từ
/// </summary>
public partial class PavoucherUsage
{
    public Guid RefId { get; set; }

    /// <summary>
    /// ID chi nhánh
    /// </summary>
    public Guid BranchId { get; set; }

    /// <summary>
    /// Loại chứng từ
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Tên bảng kê
    /// </summary>
    public string? DeclarationName { get; set; }

    /// <summary>
    /// Kỳ bảng kê
    /// </summary>
    public string? DeclarationTerm { get; set; }

    /// <summary>
    /// Từ ngày
    /// </summary>
    public DateTime FromDate { get; set; }

    /// <summary>
    /// Đến ngày
    /// </summary>
    public DateTime ToDate { get; set; }

    public byte[] Editversion { get; set; } = null!;

    /// <summary>
    /// Tổ chức chi trả thu nhập
    /// </summary>
    public string? OrganizationPay { get; set; }

    /// <summary>
    /// Mã số thuế
    /// </summary>
    public string? TaxCode { get; set; }

    /// <summary>
    /// Địa chỉ
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Số điện thoại
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Người đại diện pháp luật
    /// </summary>
    public string LegalRepresentative { get; set; } = null!;

    /// <summary>
    /// Ngày ký
    /// </summary>
    public DateTime SignDate { get; set; }

    /// <summary>
    /// Tổng số tiền thuế
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Ngày tạo
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Người tạo
    /// </summary>
    public string? CreatedBy { get; set; }

    /// <summary>
    /// Ngày sửa
    /// </summary>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Người sửa
    /// </summary>
    public string? ModifiedBy { get; set; }

    public virtual ICollection<PavoucherUsageDetail> PavoucherUsageDetails { get; set; } = new List<PavoucherUsageDetail>();
}