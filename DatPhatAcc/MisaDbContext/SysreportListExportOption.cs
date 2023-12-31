﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Tùy chỉnh xuất khẩu báo cáo
/// </summary>
public partial class SysreportListExportOption
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid ExportOptionId { get; set; }

    /// <summary>
    /// ReportID, liên kết dạng 1-1
    /// </summary>
    public string ReportId { get; set; } = null!;

    /// <summary>
    /// BranchID = NULL là tùy chọn mặc định. Chi nhánh nào chưa thiết lập thì theo thằng mặc định này
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Tiêu đề người ký là: Người lập
    /// </summary>
    public string? ReporterTitle { get; set; }

    /// <summary>
    /// Tên người ký là: Người lập
    /// </summary>
    public string? ReporterName { get; set; }

    /// <summary>
    /// Hiển thị tên người ký là: Giám đốc
    /// </summary>
    public bool? IsShowDirectorSign { get; set; }

    /// <summary>
    /// Hiển thị tên người ký là: Kế toán trường
    /// </summary>
    public bool? IsShowChiefAccountantSign { get; set; }

    /// <summary>
    /// Hiển thị tên người ký là: Thủ kho
    /// </summary>
    public bool? IsShowStockeeperSign { get; set; }

    /// <summary>
    /// Hiển thị tên người ký là: Thủ kho
    /// </summary>
    public bool? IsShowCashierSign { get; set; }

    /// <summary>
    /// Hiển thị tên người ký là: Thủ quỹ
    /// </summary>
    public bool? IsShowReporterSign { get; set; }

    /// <summary>
    /// Lặp lại tiêu đề cột ở các trang sau (PDF, Word)
    /// </summary>
    public bool? IsRepeatedColumnHeader { get; set; }

    public bool? IsShowProductInfo { get; set; }

    public bool? IsPrintNewPageForGroup { get; set; }

    public string? PrintNewPageToGroupName { get; set; }

    public int? PageSize { get; set; }

    public bool? IsPrintLineNumber { get; set; }

    public bool? IsSumToNextPage { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual SysreportList Report { get; set; } = null!;
}