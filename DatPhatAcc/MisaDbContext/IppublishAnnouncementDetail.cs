﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết thông báo phát hành hóa đơn
/// </summary>
public partial class IppublishAnnouncementDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Mẫu hóa đơn khởi tạo được chọn
    /// </summary>
    public Guid? IptemplateId { get; set; }

    /// <summary>
    /// Loại hóa đơn: 1.Hóa đơn giá trị gia tăng; 2.Hóa đơn bán hàng; 3.Phiếu xuất kho kiêm vận chuyển hàng hóa nội bộ; 4.Phiếu xuất kho gửi bán hàng đại lý; 5.Hóa đơn xuất khấu; 6.Hóa đơn bán hàng (dành cho tổ chức, cá nhân trong khu phi thuế quan)
    /// </summary>
    public int InvTypeId { get; set; }

    /// <summary>
    /// Mẫu số hóa đơn
    /// </summary>
    public string? InvTemplateNo { get; set; }

    /// <summary>
    /// Ký hiệu
    /// </summary>
    public string InvSeries { get; set; } = null!;

    /// <summary>
    /// Số lượng
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Từ số
    /// </summary>
    public string FromNo { get; set; } = null!;

    /// <summary>
    /// Đến sô
    /// </summary>
    public string ToNo { get; set; } = null!;

    /// <summary>
    /// Ngày bắt đầu sử dụng
    /// </summary>
    public DateTime? UsingStartedDate { get; set; }

    /// <summary>
    /// Doanh nghiệp in/Công ty cung cấp phần mềm in hóa đơn
    /// </summary>
    public string? VendorName { get; set; }

    /// <summary>
    /// Mã số thuế Doanh nghiệp in/Công ty cung cấp phần mềm in hóa đơn
    /// </summary>
    public string? VendorTaxCode { get; set; }

    /// <summary>
    /// Số hợp đồng tự in/cung cấp phần mềm
    /// </summary>
    public string? ContractCode { get; set; }

    /// <summary>
    /// Ngày hợp đồng tự in/cung cấp phần mềm
    /// </summary>
    public DateTime? ContractDate { get; set; }

    public int? SortOrder { get; set; }

    public virtual ICollection<IppublishAnnouncementDetailAllocation> IppublishAnnouncementDetailAllocations { get; set; } = new List<IppublishAnnouncementDetailAllocation>();

    public virtual Iptemplate? Iptemplate { get; set; }

    public virtual IppublishAnnouncement Ref { get; set; } = null!;
}