﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ConfigListTable
{
    /// <summary>
    /// Khóa
    /// </summary>
    public Guid ConfigListTableId { get; set; }

    public int Reftype { get; set; }

    /// <summary>
    /// Tên bảng chung
    /// </summary>
    public string GeneralTableName { get; set; } = null!;

    /// <summary>
    /// Mã để phân biệt các danh sách khác nhau cần sử dụng tính năng này
    /// </summary>
    public string ListCode { get; set; } = null!;

    /// <summary>
    /// Tên bảng danh sách
    /// </summary>
    public string ListTableName { get; set; } = null!;

    /// <summary>
    /// Mô tả
    /// </summary>
    public string? Description { get; set; }
}