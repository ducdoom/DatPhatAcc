﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class ReportCategory
{
    public Guid ReportId { get; set; }

    /// <summary>
    /// Viết tắt
    /// </summary>
    public string? ReportAlias { get; set; }

    /// <summary>
    /// Tên Report
    /// </summary>
    public string? ReportName { get; set; }

    public string? ReportPath { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}