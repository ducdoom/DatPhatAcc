﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu các caption tiếng việt cho từng báo cáo
/// </summary>
public partial class ReportColumnCaption
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// ReportID
    /// </summary>
    public string? ReportId { get; set; }

    /// <summary>
    /// Tên cột
    /// </summary>
    public string? ColumnName { get; set; }

    /// <summary>
    /// Caption của cột
    /// </summary>
    public string? ColumnCaption { get; set; }

    /// <summary>
    /// Độ rộng của cột
    /// </summary>
    public int? ColumnWidth { get; set; }

    public bool? IsHidden { get; set; }

    /// <summary>
    /// Title của báo cáo
    /// </summary>
    public string? ReportTitle { get; set; }
}