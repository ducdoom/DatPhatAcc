﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ImportItem
{
    public Guid ImportItemId { get; set; }

    public int RefType { get; set; }

    public int VoucherType { get; set; }

    public string? TableMaster { get; set; }

    public string? Description { get; set; }

    public string? TemplateFileName { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<ImportTable> ImportTables { get; set; } = new List<ImportTable>();
}