﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class BankSupported
{
    public string BankCode { get; set; }

    public string BankNo { get; set; }

    public string BankName { get; set; }

    public string ShortName { get; set; }

    public byte[] Logo { get; set; }

    public byte[] SmallLogo { get; set; }

    public string LogoUrl { get; set; }

    public string SmallLogoUrl { get; set; }

    public string AccountTypes { get; set; }

    public int? AccountObjectMaxLength { get; set; }

    public int? DescriptionMaxLength { get; set; }

    public string Hotline { get; set; }

    public string LinkPromotion { get; set; }

    public string LinkPageListBranch { get; set; }

    public string PhoneNumbers { get; set; }

    public bool? HasMarketing { get; set; }

    public int? Timeout { get; set; }

    public bool? Status { get; set; }

    public int? SortOrder { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? SupportVersion { get; set; }

    public string SupportProduct { get; set; }

    public bool SupportTransactionSalary { get; set; }

    public bool SupportOptionFee { get; set; }

    public bool SupportApproveTransaction { get; set; }

    public bool IsSyncAccount { get; set; }
}