﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ConfigListCabaamount
{
    public Guid ConfigListCabaamountId { get; set; }

    public int? Reftype { get; set; }

    public string MasterTableName { get; set; } = null!;

    public string? DetailTableName { get; set; }

    public string? MasterCondition { get; set; }

    public string? DetailCondition { get; set; }

    public string? DebitAccount { get; set; }

    public string? CreditAccount { get; set; }

    public string? AmountOc { get; set; }

    public string? Amount { get; set; }
}