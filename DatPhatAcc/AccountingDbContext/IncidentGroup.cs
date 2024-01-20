﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class IncidentGroup
{
    /// <summary>
    /// Mã ID chi phí
    /// </summary>
    public Guid IncidentGroupId { get; set; }

    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// Mã ID Chi Phí Cha
    /// </summary>
    public Guid? ParentIncidentGroupId { get; set; }

    /// <summary>
    /// Kí Hiệu viết tắt mã chi phí
    /// </summary>
    public string? IncidentGroupSign { get; set; }

    /// <summary>
    /// Tên chi phí
    /// </summary>
    public string? IncidentGroupName { get; set; }

    /// <summary>
    /// Mô tả chi phí
    /// </summary>
    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}