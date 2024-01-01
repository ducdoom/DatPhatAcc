﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SysreportTemplate
{
    public Guid ReportItemId { get; set; }

    public string ReportId { get; set; } = null!;

    public string? ReportItemIndex { get; set; }

    public string? ReportItemAlias { get; set; }

    public string? ReportItemCode { get; set; }

    public string? ReportItemName { get; set; }

    public Guid? ParentId { get; set; }

    public bool? IsParent { get; set; }

    public int? Grade { get; set; }

    public int? Part { get; set; }

    public bool? IsBold { get; set; }

    public bool? IsItalic { get; set; }

    public string? Formula { get; set; }

    public string? SortOrder { get; set; }

    public string? CustomInfo { get; set; }

    public virtual SysreportList Report { get; set; } = null!;

    public virtual ICollection<SysreportFormula> SysreportFormulas { get; set; } = new List<SysreportFormula>();
}