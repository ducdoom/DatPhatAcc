﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ImportTable
{
    public Guid ImportTableId { get; set; }

    public Guid ImportItemId { get; set; }

    public string TableId { get; set; } = null!;

    public string? TableName { get; set; }

    public string? Description { get; set; }

    public string? Validate { get; set; }

    public string? ValidateCaption { get; set; }

    public int? SortOrder { get; set; }

    public bool IsTableMaster { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<ImportColumn> ImportColumns { get; set; } = new List<ImportColumn>();

    public virtual ImportItem ImportItem { get; set; } = null!;
}