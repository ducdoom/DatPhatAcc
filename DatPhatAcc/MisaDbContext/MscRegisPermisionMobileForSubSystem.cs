﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class MscRegisPermisionMobileForSubSystem
{
    public Guid Id { get; set; }

    public string? SubSystemCode { get; set; }

    public string? PermissionId { get; set; }

    public virtual MscPermission? Permission { get; set; }

    public virtual MscSubSystemMobile? SubSystemCodeNavigation { get; set; }
}