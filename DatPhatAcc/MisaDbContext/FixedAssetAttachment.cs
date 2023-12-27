﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng chứa các đính kèm TSCĐ
/// </summary>
public partial class FixedAssetAttachment
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid FixedAssetDetailId { get; set; }

    /// <summary>
    /// FK Tài sản cố định
    /// </summary>
    public Guid FixedAssetId { get; set; }

    /// <summary>
    /// Tên tài liệu
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Độ lớn
    /// </summary>
    public int FileSize { get; set; }

    /// <summary>
    /// Nội dung tệp
    /// </summary>
    public byte[] FileContent { get; set; }

    /// <summary>
    /// Thứ tự
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Ghi chú
    /// </summary>
    public string Description { get; set; }

    public string FileExtention { get; set; }

    public virtual FixedAsset FixedAsset { get; set; }
}