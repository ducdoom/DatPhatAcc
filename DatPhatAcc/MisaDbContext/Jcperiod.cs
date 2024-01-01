﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Kỳ tính giá thành
/// </summary>
public partial class Jcperiod
{
    /// <summary>
    /// PK - Mã kỳ tính giá thành
    /// </summary>
    public Guid JcperiodId { get; set; }

    /// <summary>
    /// Loại. 0=Giản đơn; 1=Hệ số/Tỷ lệ; 2=Phân bước; 3=Công trình; 4=Đơn hàng; 5=Hợp đồng
    /// </summary>
    public int JcperiodType { get; set; }

    /// <summary>
    /// Từ ngày
    /// </summary>
    public DateTime FromDate { get; set; }

    /// <summary>
    /// Đến ngày
    /// </summary>
    public DateTime ToDate { get; set; }

    /// <summary>
    /// Tên kỳ tính giá thành
    /// </summary>
    public string JcperiodName { get; set; } = null!;

    /// <summary>
    /// Mã chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public int DisplayOnBook { get; set; }

    public bool IsDetailExpenseItem { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual ICollection<Jcaccepted> Jcaccepteds { get; set; } = new List<Jcaccepted>();

    public virtual ICollection<JccostAllocationConfig> JccostAllocationConfigs { get; set; } = new List<JccostAllocationConfig>();

    public virtual ICollection<JccostVoucher> JccostVouchers { get; set; } = new List<JccostVoucher>();

    public virtual ICollection<JcexpenseTranfer> JcexpenseTranfers { get; set; } = new List<JcexpenseTranfer>();

    public virtual ICollection<JcperiodDetail> JcperiodDetails { get; set; } = new List<JcperiodDetail>();
}