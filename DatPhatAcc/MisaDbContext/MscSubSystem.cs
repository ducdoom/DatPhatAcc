﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng chứa danh sách các phân hệ
/// </summary>
public partial class MscSubSystem
{
    /// <summary>
    /// Mã phân hệ
    /// </summary>
    public string SubSystemCode { get; set; } = null!;

    /// <summary>
    /// Tên phân hệ
    /// </summary>
    public string? SubSystemName { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Mã phân hệ cha: dùng để view cây phân hệ
    /// </summary>
    public string? ParentSubSystemCode { get; set; }

    /// <summary>
    /// Dùng để Order các phân hệ trên cây phân hệ cho đẹp
    /// </summary>
    public int? SortOrder { get; set; }

    public int? SystemType { get; set; }

    public string? SubSystemSerial { get; set; }

    public virtual ICollection<MscRegisPermisionForSubSystem> MscRegisPermisionForSubSystems { get; set; } = new List<MscRegisPermisionForSubSystem>();

    public virtual ICollection<MscRolePermissionMaping> MscRolePermissionMapings { get; set; } = new List<MscRolePermissionMaping>();
}