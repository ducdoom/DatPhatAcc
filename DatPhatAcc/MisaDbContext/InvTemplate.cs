﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class InvTemplate
{
    public Guid InvTemplateId { get; set; }

    public string InvTemplateNo { get; set; } = null!;

    public string InvTemplateName { get; set; } = null!;

    public bool IsSystem { get; set; }

    public int? SortOrder { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool Inactive { get; set; }
}