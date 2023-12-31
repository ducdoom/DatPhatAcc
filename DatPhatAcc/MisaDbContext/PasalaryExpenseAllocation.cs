﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Master phân bổ chi phí lương
/// </summary>
public partial class PasalaryExpenseAllocation
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Kiểu phân bổ. 0 = Phân bổ theo nhân viên; 1 = Phân bổ theo đơn vị
    /// </summary>
    public int AllocationType { get; set; }

    /// <summary>
    /// ID bảng lương
    /// </summary>
    public Guid PasalarySheetRefId { get; set; }

    /// <summary>
    /// Hiển thị chi tiết các khoản lương, bảo hiểm
    /// </summary>
    public bool IsDisplayDetailSalaryInsurance { get; set; }

    public virtual ICollection<PasalaryExpenseAllocationDetail> PasalaryExpenseAllocationDetails { get; set; } = new List<PasalaryExpenseAllocationDetail>();

    public virtual PasalarySheet PasalarySheetRef { get; set; } = null!;
}