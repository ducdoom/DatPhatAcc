﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class AccumulationCustomer
{
    public string ZoneId { get; set; }

    public string TransactionId { get; set; }

    public string CustomerId { get; set; }

    public string PromotionId { get; set; }

    public decimal? TotalExpPrice { get; set; }

    public decimal? TotalExpPriceVat { get; set; }

    public decimal? Accumulation { get; set; }

    public decimal? Payed { get; set; }

    public string TransDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string CreatedBy { get; set; }

    public string UpdatedBy { get; set; }

    public string Status { get; set; }

    public string SyncTime { get; set; }
}