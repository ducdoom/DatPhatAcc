﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class AttribRange
{
    public string AttribCode { get; set; }

    public string AttribValue { get; set; }

    public string Condition { get; set; }

    public string AttribDisplay { get; set; }

    public string SyncTime { get; set; }

    public virtual Attrib AttribCodeNavigation { get; set; }
}