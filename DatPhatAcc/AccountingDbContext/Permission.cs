﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class Permission
{
    public string UserId { get; set; }

    public string FormId { get; set; }

    public string ControlId { get; set; }

    public string ZoneId { get; set; }

    public string SyncTime { get; set; }

    public virtual Control Control { get; set; }

    public virtual Form Form { get; set; }

    public virtual User User { get; set; }

    public virtual Zone Zone { get; set; }
}