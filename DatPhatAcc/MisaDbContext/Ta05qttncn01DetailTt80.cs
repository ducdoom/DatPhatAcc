﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Ta05qttncn01DetailTt80
{
    public Guid RefDetailId { get; set; }

    public Guid RefId { get; set; }

    public Guid AppendixId { get; set; }

    public int Col06 { get; set; }

    public string Col07 { get; set; }

    public string Col08 { get; set; }

    public string Col09 { get; set; }

    public bool Col10 { get; set; }

    public decimal Col12 { get; set; }

    public decimal Col13 { get; set; }

    public decimal Col14 { get; set; }

    public decimal Col15 { get; set; }

    public decimal Col16 { get; set; }

    public decimal Col17 { get; set; }

    public decimal Col18 { get; set; }

    public decimal Col19 { get; set; }

    public decimal Col20 { get; set; }

    public decimal Col21 { get; set; }

    public bool IsForeigner { get; set; }

    public decimal Col22 { get; set; }

    public decimal Col23 { get; set; }

    public decimal Col24 { get; set; }

    public decimal Col25 { get; set; }

    public decimal Col26 { get; set; }

    public bool Col27 { get; set; }

    public int SortOrder { get; set; }

    public decimal FamilyCoditionDeductionAmount { get; set; }

    public decimal ReduceSelfTaxAmount { get; set; }

    public string Col09a { get; set; }

    public virtual TadeclarationAppendix Appendix { get; set; }
}