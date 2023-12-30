﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Danh sách các khoảng thời gian theo dõi Nợ
/// </summary>
public partial class PudebtPeriod
{
    public Guid DebtPeriodId { get; set; }

    public string? DebtPeriodName { get; set; }

    /// <summary>
    /// 0: Trước hạn; 1 quá hạn
    /// </summary>
    public int? DebtPeriodType { get; set; }

    /// <summary>
    /// Từ ngày
    /// </summary>
    public int? FromDay { get; set; }

    public int? ToDay { get; set; }

    public int? SortOrder { get; set; }

    /// <summary>
    /// True: Item không cho sửa, xóa
    /// </summary>
    public bool? IsReadOnly { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ReportId { get; set; }
}