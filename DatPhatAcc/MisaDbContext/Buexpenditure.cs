﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Buexpenditure
{
    public Guid RefId { get; set; }

    public int Year { get; set; }

    public Guid? OrganizationUnitId { get; set; }

    public bool IsDetailByOrganizationUnit { get; set; }

    public decimal TotalAmount { get; set; }

    public Guid BranchId { get; set; }

    public bool IsCreateByYear { get; set; }

    public bool IsRevenue { get; set; }

    public bool IsExpense { get; set; }

    public int RevenueType { get; set; }

    public decimal AmountByRevenue { get; set; }

    public decimal AmountByExpense { get; set; }

    public decimal AmountByProfit { get; set; }

    public decimal TaxAmount { get; set; }

    public virtual OrganizationUnit Branch { get; set; } = null!;

    public virtual ICollection<BuexpenditureDetail> BuexpenditureDetails { get; set; } = new List<BuexpenditureDetail>();

    public virtual OrganizationUnit? OrganizationUnit { get; set; }
}