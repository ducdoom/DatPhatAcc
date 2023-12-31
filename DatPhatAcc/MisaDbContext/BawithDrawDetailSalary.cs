﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết trả lương nhân viên
/// </summary>
public partial class BawithDrawDetailSalary
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
    /// Số tài khoản ngân hàng
    /// </summary>
    public string? BankAccountNumber { get; set; }

    /// <summary>
    /// Đơn vị
    /// </summary>
    public Guid OrganizationUnitId { get; set; }

    /// <summary>
    /// Số còn phải trả
    /// </summary>
    public decimal PayableAmount { get; set; }

    /// <summary>
    /// Số trả
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Thứ tự dòng
    /// </summary>
    public int SortOrder { get; set; }

    public string? BankName { get; set; }

    public virtual AccountObject Employee { get; set; } = null!;

    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    public virtual BawithDraw Ref { get; set; } = null!;
}