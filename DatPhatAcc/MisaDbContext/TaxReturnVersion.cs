﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class TaxReturnVersion
{
    public string TaxReturnId { get; set; } = null!;

    public string? TaxReturnName { get; set; }

    public string? TaxReturnVersionOfficial { get; set; }

    public string? TaxReturnVersionAdditional { get; set; }

    public string? SmeversionOfficial { get; set; }

    public string? SmeversionAdditional { get; set; }

    public DateTime? ModifiedDate { get; set; }
}