﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class CustomersType
{
    public string TypeId { get; set; }

    public string TypeName { get; set; }

    public int? CusType { get; set; }

    public string SyncTime { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}