﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu trữ các thông tin chung của tờ khai
/// </summary>
public partial class TadeclarationGeneral
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Mã thông tin chung
    /// </summary>
    public string ItemCode { get; set; } = null!;

    /// <summary>
    /// Tên thông tin chung
    /// </summary>
    public string? ItemName { get; set; }

    /// <summary>
    /// Kiểu dữ liệu (Theo Enum kiểu dữ liệu chung của chương trình):EnumDataType
    /// </summary>
    public int? DataType { get; set; }

    /// <summary>
    /// Giá trị của thông tin
    /// </summary>
    public string? Value { get; set; }

    public virtual Tadeclaration Ref { get; set; } = null!;
}