﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ImportColumn
{
    public Guid ImportColumnId { get; set; }

    public Guid ImportTableId { get; set; }

    public string? TableId { get; set; }

    public string? ColumnId { get; set; }

    public string? Description { get; set; }

    public string? ColumnName { get; set; }

    public string? ColumnNameTooltip { get; set; }

    public string? ColumnNameExcel { get; set; }

    public string? DataType { get; set; }

    public string? DefaultValue { get; set; }

    public string? DefaultDescription { get; set; }

    public string? Validate { get; set; }

    public decimal? MinValue { get; set; }

    public decimal? MaxValue { get; set; }

    public string? TableReference { get; set; }

    public string? ColumnReference { get; set; }

    public bool? Shown { get; set; }

    public bool HidenSystem { get; set; }

    public bool? NotNull { get; set; }

    public bool? NotNullsystem { get; set; }

    public bool IsColumnKey { get; set; }

    public bool IsCheckDupplicate { get; set; }

    public bool IsDefaultConfig { get; set; }

    public int SortOrder { get; set; }

    public bool IsCustom { get; set; }

    public string? ColumnNameExcelMapping { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool NotRemoveCustomColumn { get; set; }

    public string? Note { get; set; }

    public virtual ImportTable ImportTable { get; set; } = null!;
}