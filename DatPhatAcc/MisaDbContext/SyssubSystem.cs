﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng danh sách phân hệ
/// </summary>
public partial class SyssubSystem
{
    /// <summary>
    /// PK = giá trị trên enum EnumSubSystem
    /// </summary>
    public int SubSystemId { get; set; }

    /// <summary>
    /// Mã phân hệ ( = tên enum trên EnumSubSystem)
    /// </summary>
    public string SubSystemCode { get; set; }

    /// <summary>
    /// Tên phân hệ
    /// </summary>
    public string SubSystemName { get; set; }

    /// <summary>
    /// Thứ tự hiển thị trên giao diện &quot;ghi sổ/bỏ ghi theo lô&quot;
    /// </summary>
    public int SorOrder { get; set; }

    /// <summary>
    /// Mô tả
    /// </summary>
    public string Description { get; set; }

    public virtual ICollection<SyssubSystemRefType> SyssubSystemRefTypes { get; set; } = new List<SyssubSystemRefType>();
}