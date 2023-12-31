﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Thông báo điều chỉnh thông tin hóa đơn
/// </summary>
public partial class IpadjustAnnouncement
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Ngày thông báo điều chỉnh
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Số thông báo điều chỉnh
    /// </summary>
    public string RefNo { get; set; } = null!;

    /// <summary>
    /// Cơ quan thuế thông báo điều chỉnh
    /// </summary>
    public string? TaxOffice { get; set; }

    /// <summary>
    /// Trạng thái. 0: Chưa có hiệu lực; 1: Đã có hiệu lực
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// Ngày thông báo phát hành hóa đơn
    /// </summary>
    public DateTime? StatementDate { get; set; }

    /// <summary>
    /// Số thông báo phát hành hóa đơn
    /// </summary>
    public string? StatementNo { get; set; }

    /// <summary>
    /// Cơ quan thuế thông báo phát hành hóa đơn
    /// </summary>
    public string? StatementTaxOffice { get; set; }

    /// <summary>
    /// Đường dẫn tệp đính kèm thông báo phát hành
    /// </summary>
    public string? StatementFileName { get; set; }

    /// <summary>
    /// Tệp đính kèm thông báo phát hành
    /// </summary>
    public byte[]? StatementFileContent { get; set; }

    /// <summary>
    /// Có kèm các hóa đơn chuyển đi hay không?
    /// </summary>
    public bool IsAttachListOfInvoiceTransfer { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public byte[]? EditVersion { get; set; }

    public int? RefType { get; set; }

    public string? ChangeInfoContent { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual ICollection<IpadjustAnnouncementDetail> IpadjustAnnouncementDetails { get; set; } = new List<IpadjustAnnouncementDetail>();

    public virtual ICollection<IplistInvoiceAttachment> IplistInvoiceAttachments { get; set; } = new List<IplistInvoiceAttachment>();
}