﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ReportConfigToPrint
{
    public Guid Id { get; set; }

    public string? ReportFile { get; set; }

    public string? InvNo { get; set; }

    public string? InvSeries { get; set; }

    public int PrintNumber { get; set; }

    public string? UserName { get; set; }

    public DateTime? LastPrint { get; set; }
}