﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng master Lưu trữ các hóa đơn giữ chỗ để dành chi tiết
/// </summary>
public partial class EiplaceHolderInvoiceDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Loại hóa đơn: 1.Hóa đơn giá trị gia tăng; 2.Hóa đơn bán hàng; 3.Phiếu xuất kho kiêm vận chuyển hàng hóa nội bộ; 4.Phiếu xuất kho gửi bán hàng đại lý; 5.Hóa đơn xuất khấu; 6.Hóa đơn bán hàng (dành cho tổ chức, cá nhân trong khu phi thuế quan)
    /// </summary>
    public int InvTypeId { get; set; }

    /// <summary>
    /// Mẫu số hóa đơn
    /// </summary>
    public string InvTemplateNo { get; set; } = null!;

    /// <summary>
    /// Ký hiệu
    /// </summary>
    public string InvSeries { get; set; } = null!;

    /// <summary>
    /// Số hóa đơn
    /// </summary>
    public string InvNo { get; set; } = null!;

    /// <summary>
    /// Ngày hóa đơn
    /// </summary>
    public DateTime InvDate { get; set; }

    /// <summary>
    /// PK
    /// </summary>
    public Guid? InvoiceRefId { get; set; }

    public bool? IsBranchIssued { get; set; }

    public Guid BranchId { get; set; }

    public virtual EiplaceHolderInvoice Ref { get; set; } = null!;
}