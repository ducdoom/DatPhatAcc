﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SysquickEditLedgerConfig
{
    public Guid ConfigId { get; set; }

    public string LedgerTableName { get; set; }

    public string MasterTableName { get; set; }

    public string DetailTableName { get; set; }

    public string RelationColumnMaster { get; set; }

    public string RelationColumnDetail { get; set; }

    public string ColumnDetail { get; set; }

    public string ColumnDetailInLedger { get; set; }

    public string ColumnMaster { get; set; }

    public string ColumnMasterInLedger { get; set; }
}