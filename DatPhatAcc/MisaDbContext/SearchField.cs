﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SearchField
{
    public string FieldName { get; set; } = null!;

    public string? Description { get; set; }

    public int? FieldType { get; set; }

    public string? Command { get; set; }

    public int? CommandType { get; set; }

    public int? SortOrder { get; set; }

    public string? DefaultOperator { get; set; }

    public string? Comment { get; set; }

    public string? TableName { get; set; }

    public string? DictionaryType { get; set; }

    public string? ColumnLayout { get; set; }

    public bool? ShowLayout { get; set; }
}