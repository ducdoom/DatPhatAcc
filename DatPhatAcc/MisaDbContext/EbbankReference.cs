﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class EbbankReference
{
    public string BankCode { get; set; } = null!;

    public string? BankNo { get; set; }

    public string? ShortName { get; set; }

    public string? FullName { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? BankType { get; set; }
}