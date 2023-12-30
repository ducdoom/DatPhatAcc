﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class LoanProfileListItem
{
    public Guid KeyId { get; set; }

    public Guid ItemId { get; set; }

    /// <summary>
    /// Tên chỉ tiêu cần lấy
    /// </summary>
    public string? ItemName { get; set; }

    /// <summary>
    /// Số TT
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Ghi chú
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Loại nhập liệu
    /// </summary>
    public string? DataInputType { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    public Guid LoanProfileId { get; set; }

    /// <summary>
    /// Số thứ tự
    /// </summary>
    public string? RowNumber { get; set; }

    public int ItemType { get; set; }

    public virtual LoanProfile LoanProfile { get; set; } = null!;
}