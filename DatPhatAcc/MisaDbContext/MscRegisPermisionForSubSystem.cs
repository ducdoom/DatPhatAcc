﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng này đăng ký các quyền có thể sử dụng bởi 1 phân hệ
/// </summary>
public partial class MscRegisPermisionForSubSystem
{
    public Guid Id { get; set; }

    /// <summary>
    /// Mã phân hệ
    /// </summary>
    public string? SubSystemCode { get; set; }

    /// <summary>
    /// Bảng này để đăng ký các phân hệ dùng đến quyền nào
    /// </summary>
    public string? PermissionId { get; set; }

    public virtual MscPermission? Permission { get; set; }

    public virtual MscSubSystem? SubSystemCodeNavigation { get; set; }
}