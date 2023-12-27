﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ImportExternalColumn
{
    public Guid ImportExternalColumnId { get; set; }

    public Guid ImportExternalTableId { get; set; }

    public string TableId { get; set; }

    public string ColumnId { get; set; }

    public string ColumnName { get; set; }

    public string ColumnNameTooltip { get; set; }

    public string Description { get; set; }

    public string ColumnNameExternal { get; set; }

    public string DataType { get; set; }

    public string DefaultValue { get; set; }

    public string Validate { get; set; }

    public decimal? MinValue { get; set; }

    public decimal? MaxValue { get; set; }

    public string TableReference { get; set; }

    public string ColumnReference { get; set; }

    public bool? Shown { get; set; }

    public bool HidenSystem { get; set; }

    public bool NotNull { get; set; }

    public bool NotNullsystem { get; set; }

    public bool IsColumnKey { get; set; }

    public bool IsCheckDupplicate { get; set; }

    public bool IsCustom { get; set; }

    public bool NotRemoveCustomColumn { get; set; }

    public int SortOrder { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ExternalConfig { get; set; }

    public virtual ImportExternalTable ImportExternalTable { get; set; }
}