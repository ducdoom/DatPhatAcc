﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class PasalarySheetTemplate
{
    public Guid LayoutId { get; set; }

    public string LayoutName { get; set; } = null!;

    public int RefType { get; set; }

    public string? RefTypeName { get; set; }

    public Guid? UserId { get; set; }

    public bool? IsPublic { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsSystem { get; set; }

    public string? LayoutFile { get; set; }

    public virtual ICollection<PasalarySheetColumn> PasalarySheetColumns { get; set; } = new List<PasalarySheetColumn>();
}