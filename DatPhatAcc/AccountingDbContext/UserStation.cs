﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class UserStation
{
    public string UserId { get; set; } = null!;

    public string StationId { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual User User { get; set; } = null!;
}