﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Declaration03Dleinvoice
{
    public Guid RefId { get; set; }

    public int? RefType { get; set; }

    public Guid? BranchId { get; set; }

    public DateOnly? DeclarationCreatedDate { get; set; }

    public string? DeclarationName { get; set; }

    public int? PeriodType { get; set; }

    public string? PeriodName { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? DeclarationNum { get; set; }

    public string? TaxPayer { get; set; }

    public string? PayerTaxCode { get; set; }

    public string? TaxAgencyName { get; set; }

    public string? AgencyTaxCode { get; set; }

    public decimal? TotalRevenueAmount { get; set; }

    public decimal? TotalVatamount { get; set; }

    public string? SignPlace { get; set; }

    public string? Signer { get; set; }

    public byte[] EditVersion { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<Declaration03DleinvoiceDetail> Declaration03DleinvoiceDetails { get; set; } = new List<Declaration03DleinvoiceDetail>();
}