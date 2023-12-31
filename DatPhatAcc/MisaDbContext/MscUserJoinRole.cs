﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng join giữa User và Role và Chi nhánh
/// </summary>
public partial class MscUserJoinRole
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid UserJoinRoleId { get; set; }

    /// <summary>
    /// ID của User
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// ID của Role
    /// </summary>
    public Guid? RoleId { get; set; }

    /// <summary>
    /// FK của Branch
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Mã chi nhánh (Dùng để hiển thị lên form danh sách User)
    /// </summary>
    public string? BranchCode { get; set; }

    public bool IsViewIncludeDependBranch { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual MscRole? Role { get; set; }

    public virtual MscUser? User { get; set; }
}