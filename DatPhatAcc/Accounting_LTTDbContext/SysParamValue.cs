﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class SysParamValue
{
    public int OrderSort { get; set; }

    public string SysParamName { get; set; }

    public string SysParamValue1 { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string CreatedBy { get; set; }

    public string UpdatedBy { get; set; }

    public string Status { get; set; }

    public string SynStatus { get; set; }

    public string SyncTime { get; set; }

    public virtual SysParam SysParamNameNavigation { get; set; }
}