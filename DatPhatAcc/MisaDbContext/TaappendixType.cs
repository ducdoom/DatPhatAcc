﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Danh mục Loại phụ lục tờ khai thuế
/// </summary>
public partial class TaappendixType
{
    /// <summary>
    /// ID loại phụ lục
    /// </summary>
    public Guid AppendixTypeId { get; set; }

    /// <summary>
    /// Mã phụ lục
    /// </summary>
    public string AppendixTypeCode { get; set; } = null!;

    /// <summary>
    /// Tên phụ lục
    /// </summary>
    public string? AppendixTypeName { get; set; }

    /// <summary>
    /// Tên sheet tuong ứng trên template
    /// </summary>
    public string? TemplateSheetName { get; set; }

    /// <summary>
    /// Tên bảng lưu dữ liệu chi tiết phụ lục
    /// </summary>
    public string? TableName { get; set; }

    /// <summary>
    /// Loại Tờ khai (lấy trong bảng SysRefType)
    /// </summary>
    public int? RefType { get; set; }

    /// <summary>
    /// Tên store lấy dữ liệu
    /// </summary>
    public string? ProcedureName { get; set; }

    /// <summary>
    /// Số thứ tự dòng
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// Là phụ lục hay tờ khai: 1-phụ lục, 0-tờ khai
    /// </summary>
    public bool? IsAppendix { get; set; }

    public string? ProcedureNameInvalidInvoice { get; set; }

    public virtual ICollection<TadeclarationAppendix> TadeclarationAppendices { get; set; } = new List<TadeclarationAppendix>();
}