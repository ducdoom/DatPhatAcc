﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng detail chứa thông tin tab Chứng từ thanh toán, công nợ trên Đánh giá lại TK ngoại tệ
/// </summary>
public partial class GlvoucherDetailDebtPayment
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
    /// RefID của chứng từ gốc
    /// </summary>
    public Guid VoucherRefId { get; set; }

    /// <summary>
    /// RefType của chứng từ gốc
    /// </summary>
    public int VoucherRefType { get; set; }

    /// <summary>
    /// RefDate của chứng từ gốc
    /// </summary>
    public DateTime VoucherRefDate { get; set; }

    /// <summary>
    /// PostedDate của chứng từ gốc
    /// </summary>
    public DateTime VoucherPostedDate { get; set; }

    /// <summary>
    /// RefNoFiance của chứng từ gốc
    /// </summary>
    public string VoucherRefNoFinance { get; set; }

    /// <summary>
    /// RefNoManagement của chứng từ gốc
    /// </summary>
    public string VoucherRefNoManagement { get; set; }

    /// <summary>
    /// Diễn giải master của chứng từ gốc
    /// </summary>
    public string VoucherJounalMemo { get; set; }

    /// <summary>
    /// Tài khoản Công nợ trên chứng từ gốc
    /// </summary>
    public string VoucherAccountNumber { get; set; }

    /// <summary>
    /// Đối tượng
    /// </summary>
    public Guid? VoucherAccountObjectId { get; set; }

    /// <summary>
    /// Tỷ giá trên chứng từ gốc
    /// </summary>
    public decimal VoucherExchangeRate { get; set; }

    /// <summary>
    /// Tỷ giá đánh giá lại gần nhất
    /// </summary>
    public decimal LastExchangeRate { get; set; }

    /// <summary>
    /// Số chưa đối trừ nguyên tệ
    /// </summary>
    public decimal ReamainingAmountOc { get; set; }

    /// <summary>
    /// Số chưa đối trừ Quy đổi
    /// </summary>
    public decimal ReamainingAmount { get; set; }

    /// <summary>
    /// Số tiền đánh giá lại
    /// </summary>
    public decimal ReValueAmount { get; set; }

    /// <summary>
    /// Chênh lệch đánh giá lại
    /// </summary>
    public decimal DiffAmount { get; set; }

    public string VoucherInvNo { get; set; }

    public bool? IsDebtVoucher { get; set; }

    public DateTime? VoucherInvDate { get; set; }

    public decimal? RevalueExchangeRate { get; set; }

    public virtual Glvoucher Ref { get; set; }
}