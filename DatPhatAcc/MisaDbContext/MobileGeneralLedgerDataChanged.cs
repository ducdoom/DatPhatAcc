﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class MobileGeneralLedgerDataChanged
{
    public int ChangedId { get; set; }

    public DateOnly PostedDate { get; set; }

    public int SyncStatus { get; set; }

    public int? ReportYear { get; set; }

    public int? ReportMonth { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }
}