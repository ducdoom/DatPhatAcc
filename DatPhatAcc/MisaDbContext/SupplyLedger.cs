﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SupplyLedger
{
    public int SupplyLedgerId { get; set; }

    public Guid RefId { get; set; }

    public Guid? RefDetailId { get; set; }

    public int RefType { get; set; }

    public string RefNo { get; set; } = null!;

    public DateTime RefDate { get; set; }

    public DateTime PostedDate { get; set; }

    public string? JournalMemo { get; set; }

    public string? Description { get; set; }

    public int IncrementAllocationTime { get; set; }

    public int DecrementAllocationTime { get; set; }

    public decimal IncrementQuantity { get; set; }

    public decimal DecrementQuantity { get; set; }

    public decimal IncrementAmount { get; set; }

    public decimal DecrementAmount { get; set; }

    public decimal AllocationAmount { get; set; }

    public decimal TermlyAllocationAmount { get; set; }

    public Guid? BranchId { get; set; }

    public int? SortOrder { get; set; }

    public int? RefOrder { get; set; }

    public Guid? SupplyId { get; set; }

    public string? SupplyCode { get; set; }

    public string? SupplyName { get; set; }

    public Guid? SupplyCategoryId { get; set; }

    public bool IsPostToManagementBook { get; set; }

    public bool? IsUpdateRedundant { get; set; }

    public Guid? OrganizationUnitId { get; set; }

    public int RefOrderInSubSystem { get; set; }
}