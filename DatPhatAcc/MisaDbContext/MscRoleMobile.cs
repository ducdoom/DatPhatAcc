﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class MscRoleMobile
{
    public Guid RoleId { get; set; }

    public string RoleCode { get; set; }

    public string RoleName { get; set; }

    public string Description { get; set; }

    public bool IsSystem { get; set; }

    public virtual ICollection<MscRolePermissionMapingMobile> MscRolePermissionMapingMobiles { get; set; } = new List<MscRolePermissionMapingMobile>();

    public virtual ICollection<MscUserJoinRoleMobile> MscUserJoinRoleMobiles { get; set; } = new List<MscUserJoinRoleMobile>();
}