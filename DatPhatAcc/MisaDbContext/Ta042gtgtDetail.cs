﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Ta042gtgtDetail
{
    public Guid RefDetailId { get; set; }

    public Guid? RefId { get; set; }

    public Guid? AppendixId { get; set; }

    public string? ItemName { get; set; }

    public decimal AmountWithoutVat { get; set; }

    public decimal? Vatrate { get; set; }

    public decimal Amount { get; set; }

    public string? SortOrder { get; set; }

    public bool IsDeleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? GroupName { get; set; }

    public virtual Tadeclaration? Ref { get; set; }
}