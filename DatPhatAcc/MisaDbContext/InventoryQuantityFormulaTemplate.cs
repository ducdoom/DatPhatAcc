﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class InventoryQuantityFormulaTemplate
{
    /// <summary>
    /// PK
    /// </summary>
    public int FormulaId { get; set; }

    /// <summary>
    /// Tên công thức
    /// </summary>
    public string? FormulaName { get; set; }

    /// <summary>
    /// Công thức mẫu
    /// </summary>
    public string? Formula { get; set; }

    /// <summary>
    /// Sắp xếp
    /// </summary>
    public int? SortOrder { get; set; }

    public virtual ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();
}