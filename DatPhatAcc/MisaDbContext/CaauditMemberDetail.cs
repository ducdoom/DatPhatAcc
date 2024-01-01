﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng chi tiết các thành viên tham gia kiểm kê
/// </summary>
public partial class CaauditMemberDetail
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
    /// Họ và tên
    /// </summary>
    public string? AccountObjectName { get; set; }

    /// <summary>
    /// Chức vụ
    /// </summary>
    public string? Position { get; set; }

    /// <summary>
    /// Đại diện
    /// </summary>
    public string? Representative { get; set; }

    public int SortOrder { get; set; }

    public virtual Caaudit Ref { get; set; } = null!;
}