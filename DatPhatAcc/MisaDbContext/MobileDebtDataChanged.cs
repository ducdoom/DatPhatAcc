﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class MobileDebtDataChanged
{
    public int ChangedId { get; set; }

    public DateOnly PostedDate { get; set; }

    public int SyncStatus { get; set; }

    public DateOnly? DueDate { get; set; }
}