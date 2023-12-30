﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu trữ cấu hình Tiêu thức phân bổ chi phí chung
/// </summary>
public partial class JccostAllocationConfig
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// FK - ID kỳ tính giá thành
    /// </summary>
    public Guid JcperiodId { get; set; }

    /// <summary>
    /// Tiêu thức phân bổ chi phí chung. 0=NVL TT; 1=Nhân công TT; 2=CP TT
    /// </summary>
    public int AllocationMethod { get; set; }

    /// <summary>
    /// 0=Sổ tài chinh;1=Sổ quản trị
    /// </summary>
    public int DisplayOnBook { get; set; }

    public virtual Jcperiod Jcperiod { get; set; } = null!;
}