﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ImportOpeningInventoryEntry
{
    public Guid RefId { get; set; }

    public int RefType { get; set; }

    public DateTime PostedDate { get; set; }

    public string? RefNo { get; set; }

    public Guid? InventoryItemId { get; set; }

    public string? InventoryItemCode { get; set; }

    public Guid? StockId { get; set; }

    public string? StockCode { get; set; }

    public Guid? UnitId { get; set; }

    public string? UnitName { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? LotNo { get; set; }

    public Guid? MainUnitId { get; set; }

    public string? MainUnitName { get; set; }

    public decimal? MainQuantity { get; set; }

    public decimal? MainUnitPrice { get; set; }

    public decimal? MainConvertRate { get; set; }

    public string? ExchangeRateOperator { get; set; }

    public Guid? BranchId { get; set; }

    public string? BranchCode { get; set; }

    public int? DisplayOnBook { get; set; }

    public int? RefOrder { get; set; }

    public int? SortOrder { get; set; }

    public bool IsPostedInventoryBook { get; set; }

    public DateTime? InventoryPostedDate { get; set; }

    public int? InventoryResaleTypeId { get; set; }

    public DateTime? InrefOrder { get; set; }

    public string? InventoryItemName { get; set; }

    public decimal PanelLengthQuantity { get; set; }

    public decimal PanelWidthQuantity { get; set; }

    public decimal PanelHeightQuantity { get; set; }

    public decimal PanelRadiusQuantity { get; set; }

    public decimal PanelQuantity { get; set; }
}