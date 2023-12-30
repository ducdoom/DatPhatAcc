﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết đăng ký sử dụng hóa đơn
/// </summary>
public partial class IpregisterDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid RefId { get; set; }

    public Guid IptemplateId { get; set; }

    /// <summary>
    /// Mục đích sửa dụng
    /// </summary>
    public string? UsingPurpose { get; set; }

    public virtual Iptemplate Iptemplate { get; set; } = null!;

    public virtual Ipregister Ref { get; set; } = null!;
}