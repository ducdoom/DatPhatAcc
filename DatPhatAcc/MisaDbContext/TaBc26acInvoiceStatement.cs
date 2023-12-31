﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng master báo cáo tình hình sử dụng hóa đơn
/// </summary>
public partial class TaBc26acInvoiceStatement
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Loại chứng từ
    /// </summary>
    public int? RefType { get; set; }

    /// <summary>
    /// Mẫu số
    /// </summary>
    public string? TemplateNo { get; set; }

    /// <summary>
    /// Tháng/Quý
    /// </summary>
    public int Tavatquarter { get; set; }

    /// <summary>
    /// Năm
    /// </summary>
    public int Tavatyear { get; set; }

    /// <summary>
    /// Từ ngày
    /// </summary>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// Đến ngày
    /// </summary>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// Mã chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    /// <summary>
    /// Thông tư
    /// </summary>
    public string? Circular { get; set; }

    /// <summary>
    /// Người lập báo cáo
    /// </summary>
    public string? Reporter { get; set; }

    /// <summary>
    /// Người ký
    /// </summary>
    public string? Signer { get; set; }

    /// <summary>
    /// Ngày ký
    /// </summary>
    public DateTime? SignDate { get; set; }

    public virtual ICollection<TaBc26acInvoiceStatementDetail> TaBc26acInvoiceStatementDetails { get; set; } = new List<TaBc26acInvoiceStatementDetail>();
}