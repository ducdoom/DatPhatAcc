﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng mapping chứng từ và phân hệ (hiện đang dùng cho chức năng ghi sổ bỏ ghi theo lô và bảo trì)
/// </summary>
public partial class SyssubSystemRefType
{
    public Guid SyssubSystemRefTypeId { get; set; }

    /// <summary>
    /// id phân hệ
    /// </summary>
    public int SubSystemId { get; set; }

    /// <summary>
    /// id reftype
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Thứ tự ghi sổ trong nội bộ mỗi phân hệ (trừ kho)
    /// </summary>
    public int RefOrderInSubSystem { get; set; }

    /// <summary>
    /// Thứ tự ghi sổ trong trường hợp đích danh k quan tâm thứ tự nhập xuất
    /// </summary>
    public int RefOrderWithRealName { get; set; }

    /// <summary>
    /// Mô tả
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Tên bảng master của chứng từ, bỏ trống nghĩa là rule này có tác dụng với tất cả các chứng từ
    /// </summary>
    public string MasterTableName { get; set; }

    public bool? IsPostBatch { get; set; }

    public int InOutWardType { get; set; }

    public virtual SyssubSystem SubSystem { get; set; }
}