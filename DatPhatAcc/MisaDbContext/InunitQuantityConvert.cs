﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class InunitQuantityConvert
{
    public Guid ConvertId { get; set; }

    public int? RefType { get; set; }

    public Guid? RefId { get; set; }

    public Guid? RefDetailId { get; set; }

    public Guid? InventoryItemId { get; set; }

    public int Option { get; set; }

    public Guid? UnitId { get; set; }

    public decimal? Quantity { get; set; }

    public string? Description { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<InunitQuantityConvertDetail> InunitQuantityConvertDetails { get; set; } = new List<InunitQuantityConvertDetail>();
}