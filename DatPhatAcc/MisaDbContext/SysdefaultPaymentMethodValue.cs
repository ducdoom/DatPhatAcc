﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng chứa giá trị phương thức thanh toán mặc định khi thêm mới
/// </summary>
public partial class SysdefaultPaymentMethodValue
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid DefaultId { get; set; }

    /// <summary>
    /// Mã ngầm định. Sẽ lưu trữ tên bảng hoặc tên form có dữ liệu cần lưu ngầm định
    /// </summary>
    public string DefaultCode { get; set; } = null!;

    /// <summary>
    /// Danh sách các RefType áp dụng, phân tách bởi dấu &quot;,&quot; (Đối với các form chứng từ có RefType)
    /// </summary>
    public string? RefTypeList { get; set; }

    /// <summary>
    /// Danh sách các key sẽ lưu lại giá trị, phân tách bởi dấu &quot;,&quot;
    /// </summary>
    public string KeyList { get; set; } = null!;

    /// <summary>
    /// Các giá trị ngầm định. Lưu trữ theo định dạng JSON: Key, Value
    /// </summary>
    public string? DefaultValue { get; set; }

    /// <summary>
    /// Ngầm định theo người dùng. Nếu là NULL thì là dòng config của hệ thống
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// Sổ lưu trữ. NULL: Mặc định; 0=Sổ tài chính; 1=Sổ quản trị; 2=Cho các loại ko theo sổ
    /// </summary>
    public int? DisplayOnBook { get; set; }
}