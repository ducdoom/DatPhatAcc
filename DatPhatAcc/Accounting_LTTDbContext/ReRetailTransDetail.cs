﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class ReRetailTransDetail
{
    public int ItemId { get; set; }

    public string TransactionId { get; set; }

    public string GoodId { get; set; }

    public string FullGoodId { get; set; }

    public int? Quantity { get; set; }

    public string BigUnitId { get; set; }

    public string PacketId { get; set; }

    public string Status { get; set; }

    public string SynStatus { get; set; }

    public string SyncTime { get; set; }

    public virtual RetailTran Transaction { get; set; }

    public virtual Transaction TransactionNavigation { get; set; }
}