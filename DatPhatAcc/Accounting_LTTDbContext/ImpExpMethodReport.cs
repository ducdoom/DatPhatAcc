﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class ImpExpMethodReport
{
    /// <summary>
    /// Key Mã phương thức nhập xuất
    /// </summary>
    public Guid ImpExpMethodId { get; set; }

    /// <summary>
    /// Mã report
    /// </summary>
    public Guid ReportId { get; set; }

    /// <summary>
    /// Viết tắt report
    /// </summary>
    public string ReportAlias { get; set; }

    /// <summary>
    /// Tên Report
    /// </summary>
    public string ReportName { get; set; }
}