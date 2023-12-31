﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class FrreportDetail
{
    public Guid ReportDetailId { get; set; }

    public Guid? RefId { get; set; }

    public string? ReportType { get; set; }

    public Guid? ItemId { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemNameEnglish { get; set; }

    public int? ItemIndex { get; set; }

    public string? Description { get; set; }

    public int? FormulaType { get; set; }

    public string? FormulaFrontEnd { get; set; }

    public decimal? Amount { get; set; }

    public decimal? PrevAmount { get; set; }

    public bool? Hidden { get; set; }

    public bool? IsBold { get; set; }

    public bool? IsItalic { get; set; }

    public int? SortOrder { get; set; }

    public int? Category { get; set; }

    public string? Formula { get; set; }

    public decimal? OtherPrevAmount { get; set; }

    public decimal? OtherAmount { get; set; }

    public string? ItemNameChinese { get; set; }

    public string? ItemNameKorean { get; set; }

    public virtual FrreportList? Ref { get; set; }
}