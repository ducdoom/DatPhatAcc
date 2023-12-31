﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class TaestimatedEnterpriseIncomeDefault
{
    public Guid ItemId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public string ItemIndex { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public bool Hidden { get; set; }

    public bool IsBold { get; set; }

    public bool IsItalic { get; set; }

    public bool AllowEdit { get; set; }

    public bool? AllowDbnull { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ItemNameEnglish { get; set; }

    public string? ItemNameChinese { get; set; }

    public string? ItemNameKorean { get; set; }

    public int SortOrder { get; set; }
}