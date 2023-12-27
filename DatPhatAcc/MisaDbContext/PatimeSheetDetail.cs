﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết bảng chấm công chi tiết
/// </summary>
public partial class PatimeSheetDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// ID của bảng chấm công
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// ID nhân viên
    /// </summary>
    public Guid EmployeeId { get; set; }

    /// <summary>
    /// ID cơ cấu tổ chức
    /// </summary>
    public Guid? OrganizationUnitId { get; set; }

    public string Day1 { get; set; }

    public string Day2 { get; set; }

    public string Day3 { get; set; }

    public string Day4 { get; set; }

    public string Day5 { get; set; }

    public string Day6 { get; set; }

    public string Day7 { get; set; }

    public string Day8 { get; set; }

    public string Day9 { get; set; }

    public string Day10 { get; set; }

    public string Day11 { get; set; }

    public string Day12 { get; set; }

    public string Day13 { get; set; }

    public string Day14 { get; set; }

    public string Day15 { get; set; }

    public string Day16 { get; set; }

    public string Day17 { get; set; }

    public string Day18 { get; set; }

    public string Day19 { get; set; }

    public string Day20 { get; set; }

    public string Day21 { get; set; }

    public string Day22 { get; set; }

    public string Day23 { get; set; }

    public string Day24 { get; set; }

    public string Day25 { get; set; }

    public string Day26 { get; set; }

    public string Day27 { get; set; }

    public string Day28 { get; set; }

    public string Day29 { get; set; }

    public string Day30 { get; set; }

    public string Day31 { get; set; }

    /// <summary>
    /// Số công hưởng 100% lương
    /// </summary>
    public decimal? PaidWorkingday { get; set; }

    /// <summary>
    /// Số công KHÔNG hưởng 100%  lương
    /// </summary>
    public decimal? NonPaidWorkingday { get; set; }

    /// <summary>
    /// Số thứ tự
    /// </summary>
    public int SortOrder { get; set; }

    public decimal WorkingDay { get; set; }

    public decimal WeekendDay { get; set; }

    public decimal Holiday { get; set; }

    public decimal WorkingDayNight { get; set; }

    public decimal WeekendDayNight { get; set; }

    public decimal HolidayNight { get; set; }

    public decimal TotalOverTime { get; set; }

    public virtual AccountObject Employee { get; set; }

    public virtual OrganizationUnit OrganizationUnit { get; set; }

    public virtual PatimeSheet Ref { get; set; }
}