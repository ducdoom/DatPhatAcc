﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class DboptionExtend
{
    public Guid OptionExtendId { get; set; }

    public string OptionId { get; set; } = null!;

    public string? OptionValue { get; set; }

    public int ValueType { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}