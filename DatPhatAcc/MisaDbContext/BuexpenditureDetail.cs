﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class BuexpenditureDetail
{
    public Guid RefDetailId { get; set; }

    public Guid RefId { get; set; }

    public Guid? ExpenseItemId { get; set; }

    public decimal AmountMonth { get; set; }

    public decimal AmountMonth1 { get; set; }

    public decimal AmountMonth2 { get; set; }

    public decimal AmountMonth3 { get; set; }

    public decimal AmountMonth4 { get; set; }

    public decimal AmountMonth5 { get; set; }

    public decimal AmountMonth6 { get; set; }

    public decimal AmountMonth7 { get; set; }

    public decimal AmountMonth8 { get; set; }

    public decimal AmountMonth9 { get; set; }

    public decimal AmountMonth10 { get; set; }

    public decimal AmountMonth11 { get; set; }

    public decimal AmountMonth12 { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? InventoryCategoryId { get; set; }

    public Guid? ItemId { get; set; }

    public string ItemCode { get; set; }

    public string ItemName { get; set; }

    public int? ItemIndex { get; set; }

    public Guid? ParentId { get; set; }

    public int? Grade { get; set; }

    public bool? IsParent { get; set; }

    public virtual Buexpenditure Ref { get; set; }
}