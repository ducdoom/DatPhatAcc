﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class Rmpermission
{
    public string RoleId { get; set; }

    public string MenuId { get; set; }

    public string ZoneId { get; set; }

    public string SyncTime { get; set; }

    public virtual Menu Menu { get; set; }

    public virtual Role Role { get; set; }

    public virtual Zone Zone { get; set; }
}