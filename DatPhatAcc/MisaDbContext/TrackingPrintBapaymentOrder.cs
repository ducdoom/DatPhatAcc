﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class TrackingPrintBapaymentOrder
{
    public Guid RefId { get; set; }

    public string ReportId { get; set; } = null!;

    public Guid? BranchId { get; set; }

    public int? PrintedTime { get; set; }

    public DateTime? FirstPrintedDate { get; set; }

    public string? FirstPrintedUser { get; set; }

    public DateTime? LastPrintedDate { get; set; }

    public string? LastPrintedUser { get; set; }
}