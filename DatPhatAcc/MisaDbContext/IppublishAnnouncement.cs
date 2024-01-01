﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Thông báo phát hành hóa đơn
/// </summary>
public partial class IppublishAnnouncement
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Ngày lập
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Số
    /// </summary>
    public string RefNo { get; set; } = null!;

    public int? RefType { get; set; }

    /// <summary>
    /// Cơ quan thuế tiếp nhận thông báo
    /// </summary>
    public string? TaxOffice { get; set; }

    /// <summary>
    /// Trạng thái. 0: Chưa có hiệu lực; 1: Đã có hiệu lực
    /// </summary>
    public byte? Status { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    /// <summary>
    /// Ghi nhận phiên bản sửa chứng từ
    /// </summary>
    public byte[]? EditVersion { get; set; }

    public Guid? RefIdcloud { get; set; }

    public int? IppublishType { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual ICollection<IppublishAnnouncementDetail> IppublishAnnouncementDetails { get; set; } = new List<IppublishAnnouncementDetail>();
}