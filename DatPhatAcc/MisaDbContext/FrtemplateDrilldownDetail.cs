﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class FrtemplateDrilldownDetail
{
    public Guid ItemId { get; set; }

    public string ReportId { get; set; } = null!;

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemNameEnglish { get; set; }

    public string? Description { get; set; }

    public int? FormulaType { get; set; }

    public string? FormulaFrontEnd { get; set; }

    public string? Formula { get; set; }

    public int? AccountingSystem { get; set; }

    public int? Category { get; set; }

    public bool? IsEdited { get; set; }

    public int? ItemIndex { get; set; }

    public string? AccountNumberSort { get; set; }

    public string? CorrespondingAccountNumberfilter { get; set; }

    public string? ColumnsAmountfilter { get; set; }

    public string? ItemNameChinese { get; set; }

    public string? ItemNameKorean { get; set; }
}