﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class Attrib
{
    public string AttribCode { get; set; }

    public string AttribName { get; set; }

    public string AttribUnitId { get; set; }

    public string SynStatus { get; set; }

    public string SyncTime { get; set; }

    public virtual ICollection<AttribGood> AttribGoods { get; set; } = new List<AttribGood>();

    public virtual ICollection<AttribRange> AttribRanges { get; set; } = new List<AttribRange>();
}