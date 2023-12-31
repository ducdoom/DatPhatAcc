﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Danh sách khách hàng trên danh mục Nhóm giá bán
/// </summary>
public partial class SasaleGroupDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid SasaleGroupDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid SasaleGroupId { get; set; }

    /// <summary>
    /// ID khách hàng
    /// </summary>
    public Guid AccountObjectId { get; set; }

    /// <summary>
    /// Số thứ tự dòng
    /// </summary>
    public int? SortOrder { get; set; }

    public virtual AccountObject AccountObject { get; set; } = null!;

    public virtual SasaleGroup SasaleGroup { get; set; } = null!;
}