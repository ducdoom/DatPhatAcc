﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Loại hóa đơn
/// </summary>
public partial class InvType
{
    /// <summary>
    /// PK
    /// </summary>
    public int InvTypeId { get; set; }

    /// <summary>
    /// Tên loại hóa đơn
    /// </summary>
    public string InvTypeCode { get; set; } = null!;

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string InvTypeName { get; set; } = null!;

    /// <summary>
    /// Tiền tố mẫu số hóa đơn
    /// </summary>
    public string? InvoiceTemplatePrefix { get; set; }

    /// <summary>
    /// 0=Loại hóa đơn bán hàng;1=Loại hóa đơn xuất chuyển kho
    /// </summary>
    public int InvoiceType { get; set; }

    public bool Inactive { get; set; }

    public bool IsSystem { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<IpcancelAnnouncementDetail> IpcancelAnnouncementDetails { get; set; } = new List<IpcancelAnnouncementDetail>();

    public virtual ICollection<IplbdannouncementDetail> IplbdannouncementDetails { get; set; } = new List<IplbdannouncementDetail>();
}