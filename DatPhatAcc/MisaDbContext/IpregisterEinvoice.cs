﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class IpregisterEinvoice
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
    public string RefNo { get; set; } = null!;

    /// <summary>
    /// Tên người nộp thuế
    /// </summary>
    public string? TaxPayerName { get; set; }

    /// <summary>
    /// Mã số thuế
    /// </summary>
    public string? TaxCode { get; set; }

    /// <summary>
    /// Tên người liên hệ
    /// </summary>
    public string? ContactName { get; set; }

    /// <summary>
    /// Địa chỉ người liên hệ
    /// </summary>
    public string? ContactAddress { get; set; }

    /// <summary>
    /// Email người liên hệ
    /// </summary>
    public string? ContactEmail { get; set; }

    /// <summary>
    /// Điện thoại người liên hệ
    /// </summary>
    public string? ContactTel { get; set; }

    /// <summary>
    /// Loại hóa đơn điện tử sử dụng: 1: Có mã của cơ quan thuế, 0: không có mã của cơ quan thuế
    /// </summary>
    public int? InvoiceType { get; set; }

    /// <summary>
    /// Hình thức đăng ký giao dịch: 1:  Cổng thông tin điện tử của tổng cục thuế, 0: Tổ chức cung cấp về dịch vụ hóa đơn điện tử
    /// </summary>
    public int? RegistrationMethod { get; set; }

    /// <summary>
    /// Hóa đơn giá trị gia tăng
    /// </summary>
    public bool? IsInvoiceValueAdded { get; set; }

    /// <summary>
    /// Hóa đơn bán hàng
    /// </summary>
    public bool? IsSaleInvoice { get; set; }

    /// <summary>
    /// Hóa đơn khởi tạo từ máy tính tiền
    /// </summary>
    public bool? IsInvoiceFromEcr { get; set; }

    /// <summary>
    /// Các loại hóa đơn khác
    /// </summary>
    public bool? IsOtherInvoice { get; set; }

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

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual ICollection<IpregisterEinvoiceDetail> IpregisterEinvoiceDetails { get; set; } = new List<IpregisterEinvoiceDetail>();
}