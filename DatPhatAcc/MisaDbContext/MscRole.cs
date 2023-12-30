﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Danh sách vai trò
/// </summary>
public partial class MscRole
{
    public Guid RoleId { get; set; }

    /// <summary>
    /// Mã vai trò
    /// </summary>
    public string? RoleCode { get; set; }

    /// <summary>
    /// Tên vai trò
    /// </summary>
    public string? RoleName { get; set; }

    /// <summary>
    /// Diễn giải, mô tả về chức năng
    /// </summary>
    public string? Description { get; set; }

    public bool IsSystem { get; set; }

    public virtual ICollection<MscRolePermissionMaping> MscRolePermissionMapings { get; set; } = new List<MscRolePermissionMaping>();

    public virtual ICollection<MscUserJoinRole> MscUserJoinRoles { get; set; } = new List<MscUserJoinRole>();
}