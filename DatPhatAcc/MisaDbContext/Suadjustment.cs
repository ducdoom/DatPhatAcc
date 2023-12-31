﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Điều chỉnh CCDC
/// </summary>
public partial class Suadjustment
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Loại chứng từ (Lấy từ bảng RefType)
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Ngày chứng từ
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Số chứng từ
    /// </summary>
    public string RefNo { get; set; } = null!;

    /// <summary>
    /// Lý do điều chỉnh
    /// </summary>
    public string? JournalMemo { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Ghi vào sổ quản trị
    /// </summary>
    public bool IsPostedManagement { get; set; }

    /// <summary>
    /// 0=Sổ tài chinh;1=Sổ quản trị
    /// </summary>
    public int DisplayOnBook { get; set; }

    /// <summary>
    /// EditVersion
    /// </summary>
    public byte[]? EditVersion { get; set; }

    /// <summary>
    /// Số thứ tự nhập chứng từ
    /// </summary>
    public int RefOrder { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    /// <summary>
    /// Ghi vào sổ tài chính
    /// </summary>
    public bool IsPostedFinance { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual ICollection<SuadjustmentDetailVoucher> SuadjustmentDetailVouchers { get; set; } = new List<SuadjustmentDetailVoucher>();

    public virtual ICollection<SuadjustmentDetail> SuadjustmentDetails { get; set; } = new List<SuadjustmentDetail>();
}