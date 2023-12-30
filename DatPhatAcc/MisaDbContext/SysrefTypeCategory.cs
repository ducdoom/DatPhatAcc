﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Nhóm loại chứng từ
/// </summary>
public partial class SysrefTypeCategory
{
    public int RefTypeCategory { get; set; }

    public string? RefTypeCategoryName { get; set; }

    public string? DefaultDebitAccountId { get; set; }

    public string? DefaultCreditAccountId { get; set; }

    /// <summary>
    /// Dùng để xác định các loại nào hiển thị lên để đánh lại số chứng từ
    /// </summary>
    public bool UseRebuildRefNo { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp
    /// </summary>
    public int SortOrder { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<SysrefTypeDetail> SysrefTypeDetails { get; set; } = new List<SysrefTypeDetail>();

    public virtual ICollection<SysrefType> SysrefTypes { get; set; } = new List<SysrefType>();
}