﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class EinvoiceSummaryReference
{
    public Guid ReferenceId { get; set; }

    public Guid EinvoiceSummaryId { get; set; }

    public Guid? SainvoicePetroleumId { get; set; }

    public Guid? SainvoiceId { get; set; }

    public virtual Sainvoice? Sainvoice { get; set; }

    public virtual SainvoicePetroleum? SainvoicePetroleum { get; set; }
}