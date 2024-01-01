﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng master chứng từ tính khấu hao TSCD
/// </summary>
public partial class Fadepreciation
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Loại chứng từ
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Ngày chứng từ
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Ngày hoạch toán
    /// </summary>
    public DateTime PostedDate { get; set; }

    /// <summary>
    /// Số chứng từ
    /// </summary>
    public string RefNo { get; set; } = null!;

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? JournalMemo { get; set; }

    /// <summary>
    /// Tháng khấu hao
    /// </summary>
    public int Month { get; set; }

    /// <summary>
    /// Năm khấu hao
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Số tiền quy đổi
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Ghi vào sổ tài chính
    /// </summary>
    public bool IsPostedFinance { get; set; }

    /// <summary>
    /// 0: Phân bổ ở Sổ tài chính; 1: Phân bổ ở Sổ quản trị
    /// </summary>
    public int DisplayOnBook { get; set; }

    /// <summary>
    /// Phiên bản sửa
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
    /// Ghi vào sổ quản trị
    /// </summary>
    public bool IsPostedManagement { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual ICollection<FadepreciationDetailAllocation> FadepreciationDetailAllocations { get; set; } = new List<FadepreciationDetailAllocation>();

    public virtual ICollection<FadepreciationDetailPost> FadepreciationDetailPosts { get; set; } = new List<FadepreciationDetailPost>();

    public virtual ICollection<FadepreciationDetail> FadepreciationDetails { get; set; } = new List<FadepreciationDetail>();
}