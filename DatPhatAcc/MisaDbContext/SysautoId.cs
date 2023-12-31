﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu cấu hình tự tăng của Số chứng từ
/// </summary>
public partial class SysautoId
{
    public Guid AutoId { get; set; }

    /// <summary>
    /// PK
    /// </summary>
    public int RefTypeCategory { get; set; }

    /// <summary>
    /// Tên loại chứng từ
    /// </summary>
    public string? RefTypeCategoryName { get; set; }

    /// <summary>
    /// Tiền tố
    /// </summary>
    public string? Prefix { get; set; }

    /// <summary>
    /// Giá trị
    /// </summary>
    public decimal Value { get; set; }

    /// <summary>
    /// Độ dài
    /// </summary>
    public int LengthOfValue { get; set; }

    /// <summary>
    /// Hậu tố
    /// </summary>
    public string? Suffix { get; set; }

    /// <summary>
    /// Chi nhánh. Các thiết lập mặc định mang đi thì BranchID = NULL
    /// </summary>
    public Guid? BranchId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    /// <summary>
    /// 0=Sổ tài chính; 1=Sổ quản trị; 2=Tự tăng trên cả 2 sổ
    /// </summary>
    public int? DisplayOnBook { get; set; }
}