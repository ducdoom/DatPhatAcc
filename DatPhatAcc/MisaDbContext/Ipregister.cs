﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng đăng ký sử dụng hóa đơn
/// </summary>
public partial class Ipregister
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Ngày đăng ký
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Số đăng ký
    /// </summary>
    public string RefNo { get; set; }

    /// <summary>
    /// Diễn giải (Về việc)
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Người ký
    /// </summary>
    public string Signer { get; set; }

    /// <summary>
    /// Tình trạng: 0: Chưa có hiệu lực; 1: Đã có hiệu lực
    /// </summary>
    public byte? Status { get; set; }

    /// <summary>
    /// Đường dẫn file đính kèm
    /// </summary>
    public string AttachFileName { get; set; }

    /// <summary>
    /// File đính kèm
    /// </summary>
    public byte[] AttachFileContent { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; }

    public string ModifiedBy { get; set; }

    public byte[] EditVersion { get; set; }

    public int? RefType { get; set; }

    public virtual OrganizationUnit Branch { get; set; }

    public virtual ICollection<IpregisterDetail> IpregisterDetails { get; set; } = new List<IpregisterDetail>();
}