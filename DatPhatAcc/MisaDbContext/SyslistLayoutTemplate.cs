﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Mẫu layout của Danh sách danh mục, chứng từ
/// </summary>
public partial class SyslistLayoutTemplate
{
    /// <summary>
    /// PK mã layout
    /// </summary>
    public Guid LayoutId { get; set; }

    /// <summary>
    /// ID của người dùng. Nếu NULLthì là mẫu ngầm định
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// Mã danh mục, danh sách chứng từ
    /// </summary>
    public string? SubSystemCode { get; set; }

    /// <summary>
    /// Cấu hình của grid list
    /// </summary>
    public string TemplateConfig { get; set; } = null!;

    /// <summary>
    /// Tên layout, dùng cho danh sách Hợp đồng bán
    /// </summary>
    public string? LayoutName { get; set; }

    /// <summary>
    /// Mô tả layout, dùng cho quản lý mẫu Hợp đồng bán
    /// </summary>
    public string? Description { get; set; }

    public bool? IsPublic { get; set; }

    public virtual ICollection<SyslayoutMemorized> SyslayoutMemorizeds { get; set; } = new List<SyslayoutMemorized>();
}