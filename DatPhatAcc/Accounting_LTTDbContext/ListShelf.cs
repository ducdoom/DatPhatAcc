﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class ListShelf
{
    public string ShelfId { get; set; }

    public string StockId { get; set; }

    public string GoodId { get; set; }

    public string ZoneId { get; set; }

    public string SyncTime { get; set; }

    public virtual Stock Stock { get; set; }
}