﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class TrackingPrintInvoice
{
    public Guid RefId { get; set; }

    public int InvTypeId { get; set; }

    public string InvNo { get; set; }

    public string InvTemplateNo { get; set; }

    public string InvSeries { get; set; }

    public Guid? BranchId { get; set; }

    public int? PrintedTime { get; set; }

    public DateTime? FirstPrintedDate { get; set; }

    public string FirstPrintedUser { get; set; }

    public DateTime? LastPrintedDate { get; set; }

    public string LastPrintedUser { get; set; }

    public DateTime? InvDate { get; set; }
}