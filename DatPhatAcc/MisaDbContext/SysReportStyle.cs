﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SysReportStyle
{
    public int StyleId { get; set; }

    public string StyleName { get; set; }

    public byte[] StyleData { get; set; }

    public string DefaultStyleFileName { get; set; }

    public decimal? DisplayLogoRate { get; set; }

    public decimal? TopMargin { get; set; }

    public decimal? LeftMargin { get; set; }

    public decimal? BottomMargin { get; set; }

    public decimal? LicenseInfoWidth { get; set; }

    public string HieroglyphsStyleFileName { get; set; }
}