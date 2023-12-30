﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu trữ các chứng từ được chọn để phân bổ chi phí chung
/// </summary>
public partial class JccostVoucher
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid JccostVoucherId { get; set; }

    /// <summary>
    /// Kỳ tính giá thành
    /// </summary>
    public Guid? JcperiodId { get; set; }

    /// <summary>
    /// RefID của chứng từ
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Ngày chứng từ
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Ngày hạch toán
    /// </summary>
    public DateTime? PostedDate { get; set; }

    /// <summary>
    /// Số chứng từ Sổ tài chính
    /// </summary>
    public string? RefNo { get; set; }

    /// <summary>
    /// Loại chứng từ
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Diễn giải Lý do nộp
    /// </summary>
    public string? JournalMemo { get; set; }

    /// <summary>
    /// TK chi phí
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    /// ID khoản mục CP
    /// </summary>
    public Guid? ExpenseItemId { get; set; }

    /// <summary>
    /// Số tiền
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Số chưa phân bổ
    /// </summary>
    public decimal RemainingAmount { get; set; }

    /// <summary>
    /// Tỷ lệ phân bổ (%)
    /// </summary>
    public decimal AllocationRate { get; set; }

    /// <summary>
    /// Số tiền phân bổ
    /// </summary>
    public decimal AllocationAmount { get; set; }

    /// <summary>
    /// 0=Sổ tài chinh;1=Sổ quản trị
    /// </summary>
    public int DisplayOnBook { get; set; }

    public decimal AccountNumberTotalAmount { get; set; }

    public decimal? AccountNumberRemainingAmount { get; set; }

    public bool UnResonableCost { get; set; }

    public virtual Account? AccountNumberNavigation { get; set; }

    public virtual ExpenseItem? ExpenseItem { get; set; }

    public virtual Jcperiod? Jcperiod { get; set; }
}