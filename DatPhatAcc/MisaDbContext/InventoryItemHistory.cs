﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class InventoryItemHistory
{
    public Guid InventoryItemHistoryId { get; set; }

    public Guid InventoryItemId { get; set; }

    public Guid StockId { get; set; }

    public Guid BranchId { get; set; }

    public bool IsPostToManagementBook { get; set; }

    public decimal MainQuantity { get; set; }

    public decimal Amount { get; set; }

    public Guid OutwardRefId { get; set; }

    public int OutwardRefType { get; set; }

    public Guid OutwardRefDetailId { get; set; }

    public DateTime OutwardPostedDate { get; set; }

    public DateTime OutwardRefOrder { get; set; }

    public decimal OutwardMainUnitPrice { get; set; }

    public decimal MainOutwardQuantity { get; set; }

    public decimal OutwardAmount { get; set; }

    public Guid InwardRefId { get; set; }

    public DateTime InwardPostedDate { get; set; }

    public int InwardRefType { get; set; }

    public Guid InwardRefDetailId { get; set; }

    public DateTime InwardRefOrder { get; set; }

    public decimal InwardMainUnitPrice { get; set; }

    public decimal InwardMainQuantityBalance { get; set; }

    public decimal InwardAmountBalance { get; set; }

    public Guid? AdjustOutwardRefDetailId { get; set; }

    public int? InreportType { get; set; }

    public bool? IsUnUpdateOutwardPrice { get; set; }

    public bool? IsPosted { get; set; }

    public bool IsAdjust { get; set; }
}