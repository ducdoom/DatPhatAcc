﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SysreportCopyConfigDetail
{
    public int ConfigDetailId { get; set; }

    public string ReportId { get; set; }

    public int? NoOfCopy { get; set; }

    public string NameOfCopy { get; set; }

    public int TypeOfCopies { get; set; }

    public string Ccpurpose { get; set; }

    public string Cccolor { get; set; }

    public byte[] Ccbackground { get; set; }

    public byte[] Cclogo { get; set; }

    public string LocalPathBackground { get; set; }

    public string LocalPathLogo { get; set; }

    public string EnglishNameOfCopy { get; set; }

    public string CcpurposeEnglish { get; set; }

    public bool IsConvertTemplate { get; set; }
}