﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Lưu 1 số thông tin của các tờ khai
/// </summary>
public partial class TadeclarationConfig
{
    /// <summary>
    /// Loại tờ khai
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Tên tờ khai
    /// </summary>
    public string RefTypeName { get; set; } = null!;

    /// <summary>
    /// Tên của file Excel mẫu
    /// </summary>
    public string TemplateFileName { get; set; } = null!;

    /// <summary>
    /// Mẫu số
    /// </summary>
    public string? TemplateNo { get; set; }

    /// <summary>
    /// Tên tờ khai
    /// </summary>
    public string? DeclarationName { get; set; }

    /// <summary>
    /// Tên form tham số
    /// </summary>
    public string? SetupFormName { get; set; }

    /// <summary>
    /// Loại form tham số: 0: không show form tham số khi ở trạng thái sửa, 1: có show form tham số ở cả trạng thái sửa và thêm mới - 2: Không show luôn form tham số
    /// </summary>
    public int? IsShowSetupFormWhenEdit { get; set; }

    /// <summary>
    /// Tên menu gọi form thêm mới tương ứng
    /// </summary>
    public string? MenuName { get; set; }
}