﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class InunitQuantityConvertDetail
{
    public Guid ConvertDetailId { get; set; }

    public Guid ConvertId { get; set; }

    public Guid? UnitId { get; set; }

    public string UnitName { get; set; }

    public Guid? MainUnitId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? MainQuantity { get; set; }

    public decimal? ConvertRate { get; set; }

    public string ExchangeRateOperator { get; set; }

    public int? SortOrder { get; set; }

    public virtual InunitQuantityConvert Convert { get; set; }
}