﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Phụ lục 03-2A/TNDN: Chuyển lỗ từ hoạt động sản xuất kinh doanh
/// </summary>
public partial class Ta03tndn2adetail
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
    /// Năm phát sinh lỗ
    /// </summary>
    public int? Tayear { get; set; }

    /// <summary>
    /// Số lỗ phát sinh
    /// </summary>
    public decimal? LostAmount { get; set; }

    /// <summary>
    /// Số lỗ đã chuyển trong các kỳ trước
    /// </summary>
    public decimal? LostAmountTranfer { get; set; }

    /// <summary>
    /// Số lỗ đã chuyển trong kỳ này
    /// </summary>
    public decimal? LostAmountCurrentTranfer { get; set; }

    /// <summary>
    /// Số lỗ còn được chuyển sang các kỳ tính thuế sau
    /// </summary>
    public decimal? LostAmountRemain { get; set; }

    /// <summary>
    /// Groupname
    /// </summary>
    public string? GroupName { get; set; }

    public int? SortOrder { get; set; }

    public decimal? LostAmountNextTransfer { get; set; }

    public virtual TadeclarationAppendix Appendix { get; set; } = null!;
}