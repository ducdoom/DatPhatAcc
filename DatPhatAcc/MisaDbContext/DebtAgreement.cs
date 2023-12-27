﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Danh mục khế ước vay
/// </summary>
public partial class DebtAgreement
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid DebtAgreementId { get; set; }

    /// <summary>
    /// Số khế ước
    /// </summary>
    public string DebtAgreementCode { get; set; }

    /// <summary>
    /// Ngày khế ước
    /// </summary>
    public DateTime AgreementDate { get; set; }

    /// <summary>
    /// Ngày nhận nợ
    /// </summary>
    public DateTime? DebtDate { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public Guid? CurrencyId { get; set; }

    /// <summary>
    /// Số tiền
    /// </summary>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Lãi suất
    /// </summary>
    public decimal? Interest { get; set; }

    /// <summary>
    /// Lãi suất quá hạn
    /// </summary>
    public decimal? OverdueInterest { get; set; }

    /// <summary>
    /// Ngân hàng cho vay
    /// </summary>
    public Guid? BankId { get; set; }

    /// <summary>
    /// Đối tượng cho vay
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Bộ phận thực hiện
    /// </summary>
    public Guid? OrganizationUnitId { get; set; }

    /// <summary>
    /// Chu kỳ thanh toán (Tháng/lần)
    /// </summary>
    public decimal? PaymentCycle { get; set; }

    /// <summary>
    /// Số lần thanh toán
    /// </summary>
    public int? PaymentTimes { get; set; }

    /// <summary>
    /// Thời hạn vay (tháng)
    /// </summary>
    public decimal? DebtPeriod { get; set; }

    /// <summary>
    /// Ngày đáo hạn
    /// </summary>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool? Inactive { get; set; }

    public virtual AccountObject AccountObject { get; set; }

    public virtual ICollection<BadepositDetail> BadepositDetails { get; set; } = new List<BadepositDetail>();

    public virtual Bank Bank { get; set; }

    public virtual ICollection<BawithDrawDetail> BawithDrawDetails { get; set; } = new List<BawithDrawDetail>();

    public virtual ICollection<CapaymentDetail> CapaymentDetails { get; set; } = new List<CapaymentDetail>();

    public virtual ICollection<CareceiptDetail> CareceiptDetails { get; set; } = new List<CareceiptDetail>();

    public virtual OrganizationUnit OrganizationUnit { get; set; }
}