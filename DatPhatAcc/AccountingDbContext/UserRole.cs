﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class UserRole
{
    public string UserId { get; set; }

    public string RoleId { get; set; }

    public string SyncTime { get; set; }

    public virtual Role Role { get; set; }

    public virtual User User { get; set; }
}