﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết chi nộp thuế TNCN
/// </summary>
public partial class CapaymentDetailPersonalIncomeTax
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
    /// ID nhân viên
    /// </summary>
    public Guid EmployeeId { get; set; }

    /// <summary>
    /// Đơn vị
    /// </summary>
    public Guid OrganizationUnitId { get; set; }

    /// <summary>
    /// Số phải nộp
    /// </summary>
    public decimal PayableAmount { get; set; }

    /// <summary>
    /// Số nộp lần này
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp
    /// </summary>
    public int? SortOrder { get; set; }

    public virtual OrganizationUnit OrganizationUnit { get; set; }

    public virtual Capayment Ref { get; set; }
}