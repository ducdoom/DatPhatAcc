﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ReportFilterDetail
{
    public Guid FilterDetailId { get; set; }

    public Guid FilterId { get; set; }

    public string FieldName { get; set; }

    public int? FieldType { get; set; }

    public int? Condition { get; set; }

    public string Value1 { get; set; }

    public string Value2 { get; set; }

    public int SortOrder { get; set; }

    public virtual ReportFilter Filter { get; set; }
}