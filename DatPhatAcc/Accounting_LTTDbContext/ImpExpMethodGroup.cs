﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class ImpExpMethodGroup
{
    /// <summary>
    /// Mã nhóm phương thức nhập xuất.
    /// </summary>
    public string ImpExpMethodGroupId { get; set; }

    /// <summary>
    /// Tên nhóm phương thức nhập xuất.
    /// </summary>
    public string ImpExpMethodGroupName { get; set; }

    public string Status { get; set; }

    public string SynStatus { get; set; }

    public string SyncTime { get; set; }
}