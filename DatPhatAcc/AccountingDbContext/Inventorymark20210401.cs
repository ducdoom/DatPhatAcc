﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class Inventorymark20210401
{
    public string StockId { get; set; }

    public string ZoneId { get; set; }

    public string GoodId { get; set; }

    public string FullGoodId { get; set; }

    public string CustomerId { get; set; }

    public int Quantity { get; set; }

    public decimal? AverPrice { get; set; }

    public decimal AverPriceVat { get; set; }

    public decimal? Totalvat { get; set; }

    public decimal Total { get; set; }

    public decimal? Totalamountvat { get; set; }
}