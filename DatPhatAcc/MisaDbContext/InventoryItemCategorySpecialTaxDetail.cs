﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class InventoryItemCategorySpecialTaxDetail
{
    public string InventoryCategorySpecialTaxCode { get; set; } = null!;

    public string InventoryCategorySpecialTaxName { get; set; } = null!;

    public string? Unit { get; set; }

    public decimal TaxRate { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }
}