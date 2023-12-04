﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.AccountingDbContext;

public partial class TransactionEnvironmentalTaxDetail
{
    public Guid TransDetailId { get; set; }

    public string TransactionId { get; set; }

    public string FullGoodId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string CreatedBy { get; set; }

    public string UpdatedBy { get; set; }

    public string Status { get; set; }

    public string SynStatus { get; set; }

    public string SyncTime { get; set; }

    /// <summary>
    /// %Thuế tiêu thụ đặc biệt
    /// </summary>
    public decimal EnvironmentalTaxRate { get; set; }

    public decimal EnvironmentalTaxAmount { get; set; }

    public string EnvironmentalTaxAccount { get; set; }

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string DebitAccount { get; set; }

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string CreditAccount { get; set; }
}