﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SysVoucherTemplateUserDetail
{
    public Guid? LayoutId { get; set; }

    public Guid? UserId { get; set; }

    public int? State { get; set; }

    public virtual SysvoucherTemplate Layout { get; set; }
}