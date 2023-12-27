﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class PatimeSheetSummaryDetail
{
    public Guid RefDetailId { get; set; }

    public Guid RefId { get; set; }

    public Guid EmployeeId { get; set; }

    public Guid? OrganizationUnitId { get; set; }

    public decimal? PaidWorkingday { get; set; }

    public decimal? NonPaidWorkingday { get; set; }

    public decimal? WorkingDay { get; set; }

    public decimal? WeekendDay { get; set; }

    public decimal? Holiday { get; set; }

    public decimal? TotalOverTime { get; set; }

    public int SortOrder { get; set; }

    public decimal? WorkingDayNight { get; set; }

    public decimal? WeekendDayNight { get; set; }

    public decimal? HolidayNight { get; set; }

    public virtual AccountObject Employee { get; set; }

    public virtual OrganizationUnit OrganizationUnit { get; set; }

    public virtual ICollection<PatimeSheetSummaryDetailMatrix> PatimeSheetSummaryDetailMatrices { get; set; } = new List<PatimeSheetSummaryDetailMatrix>();

    public virtual PatimeSheetSummary Ref { get; set; }
}