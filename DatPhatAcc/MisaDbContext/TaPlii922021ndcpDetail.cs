﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class TaPlii922021ndcpDetail
{
    public Guid RefDetailId { get; set; }

    public Guid RefId { get; set; }

    public Guid AppendixId { get; set; }

    public decimal TurnOverAmount { get; set; }

    public string? InventoryItemName { get; set; }

    public decimal? ExportTaxRate { get; set; }

    public decimal? TaxRate { get; set; }

    public decimal? DeductionsTaxAmount { get; set; }

    public string GroupName { get; set; } = null!;

    public int SortOrder { get; set; }

    public string? Htkkname { get; set; }

    public string? Htkkcode { get; set; }

    public virtual TadeclarationAppendix Appendix { get; set; } = null!;
}