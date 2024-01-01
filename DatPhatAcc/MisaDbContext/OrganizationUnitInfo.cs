﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class OrganizationUnitInfo
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid OrganizationUnitInfoId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid? OrganizationUnitId { get; set; }

    /// <summary>
    /// Mã chỉ tiêu
    /// </summary>
    public string? ItemCode { get; set; }

    /// <summary>
    /// Tên chỉ tiêu
    /// </summary>
    public string? ItemName { get; set; }

    /// <summary>
    /// Nội dung, giá trị của chỉ tiêu
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Trạng thái In dậm của chỉ tiêu 1: In đậm; 0: không in đậm
    /// </summary>
    public bool? IsBold { get; set; }

    /// <summary>
    /// Trạng thái in nghiên của chỉ tiêu 1: In nghiên; 0 không in nghiêng
    /// </summary>
    public bool? IsItalic { get; set; }

    /// <summary>
    /// Số thứ tự của chỉ tiêu
    /// </summary>
    public int? SortOrder { get; set; }

    public virtual OrganizationUnit? OrganizationUnit { get; set; }
}