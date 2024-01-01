﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu trữ Công nợ đầu kỳ theo hóa đơn
/// </summary>
public partial class OpeningAccountEntryDetailInvoice
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
    /// Ngày hóa đơn
    /// </summary>
    public DateTime? InvDate { get; set; }

    /// <summary>
    /// Số hóa đơn
    /// </summary>
    public string? InvNo { get; set; }

    /// <summary>
    /// Hạn thanh toán
    /// </summary>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// ID nhân viên
    /// </summary>
    public Guid? EmployeeId { get; set; }

    /// <summary>
    /// Tỷ giá
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// Giá trị hóa đơn
    /// </summary>
    public decimal InvoiceAmountOc { get; set; }

    /// <summary>
    /// Giá trị hóa đơn QĐ
    /// </summary>
    public decimal InvoiceAmount { get; set; }

    /// <summary>
    /// Số còn phải thu/Số còn phải trả
    /// </summary>
    public decimal AmountOc { get; set; }

    /// <summary>
    /// Số còn phải thu/Số còn phải trả QĐ
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp dòng
    /// </summary>
    public int? SortOrder { get; set; }

    public bool? IsAutoGenerate { get; set; }

    public decimal PayAmountOc { get; set; }

    public decimal PayAmount { get; set; }

    public virtual AccountObject? Employee { get; set; }

    public virtual OpeningAccountEntry Ref { get; set; } = null!;
}