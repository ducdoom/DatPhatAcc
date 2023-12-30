﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Danh sách chứng từ ghi sổ
/// </summary>
public partial class GlvoucherList
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
    /// Ngày chứng từ ghi sổ
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Số chứng từ ghi sổ (Sổ tài chính)
    /// </summary>
    public string? RefNo { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? JournalMemo { get; set; }

    /// <summary>
    /// Tổng số tiền 
    /// </summary>
    public decimal TotalAmount { get; set; }

    public byte[] EditVersion { get; set; } = null!;

    /// <summary>
    /// Mã chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public int DisplayOnBook { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual ICollection<GlvoucherListDetail> GlvoucherListDetails { get; set; } = new List<GlvoucherListDetail>();
}