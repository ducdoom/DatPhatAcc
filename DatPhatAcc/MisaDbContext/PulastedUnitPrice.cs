﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class PulastedUnitPrice
{
    public Guid PulastedUnitPriceId { get; set; }

    public Guid AccountObjectId { get; set; }

    public string CurrencyId { get; set; }

    public Guid InventoryItemId { get; set; }

    public Guid? UnitId { get; set; }

    public decimal UnitPrice { get; set; }

    public virtual AccountObject AccountObject { get; set; }

    public virtual InventoryItem InventoryItem { get; set; }

    public virtual Unit Unit { get; set; }
}