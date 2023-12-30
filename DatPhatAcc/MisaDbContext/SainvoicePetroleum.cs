﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SainvoicePetroleum
{
    public Guid RefId { get; set; }

    public Guid? BranchId { get; set; }

    public int DisplayOnBook { get; set; }

    public int RefType { get; set; }

    public Guid? AccountObjectId { get; set; }

    public string? AccountObjectName { get; set; }

    public string? AccountObjectAddress { get; set; }

    public string? AccountObjectTaxCode { get; set; }

    public string? AccountObjectBankAccount { get; set; }

    public string? PaymentMethod { get; set; }

    public string? Buyer { get; set; }

    public Guid? EmployeeId { get; set; }

    public bool IsPaid { get; set; }

    public bool IsPosted { get; set; }

    public bool IsPostedLastYear { get; set; }

    public DateTime? InvDate { get; set; }

    public string? InvNo { get; set; }

    public bool IncludeInvoice { get; set; }

    public string? CurrencyId { get; set; }

    public decimal ExchangeRate { get; set; }

    public decimal TotalSaleAmountOc { get; set; }

    public decimal TotalSaleAmount { get; set; }

    public decimal TotalDiscountAmountOc { get; set; }

    public decimal TotalDiscountAmount { get; set; }

    public decimal TotalVatamountOc { get; set; }

    public decimal TotalVatamount { get; set; }

    public decimal TotalAmountOc { get; set; }

    public decimal TotalAmount { get; set; }

    public Guid? AdjustRefId { get; set; }

    public int? AdjustRefType { get; set; }

    public string? AdjustJournalMemo { get; set; }

    public Guid? AdjustPurchasePurposeId { get; set; }

    public decimal? AdjustVatrate { get; set; }

    public int? AdjustTacareerGroupId { get; set; }

    public string? AdjustInvNo { get; set; }

    public DateTime? AdjustInvDate { get; set; }

    public bool? IsAdjustAutoCalculate { get; set; }

    public byte[]? EditVersion { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? CustomField1 { get; set; }

    public string? CustomField2 { get; set; }

    public string? CustomField3 { get; set; }

    public string? CustomField4 { get; set; }

    public string? CustomField5 { get; set; }

    public string? CustomField6 { get; set; }

    public string? CustomField7 { get; set; }

    public string? CustomField8 { get; set; }

    public string? CustomField9 { get; set; }

    public string? CustomField10 { get; set; }

    public virtual AccountObject? AccountObject { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual Ccy? Currency { get; set; }

    public virtual ICollection<EinvoiceSummaryDetailReference> EinvoiceSummaryDetailReferences { get; set; } = new List<EinvoiceSummaryDetailReference>();

    public virtual ICollection<EinvoiceSummaryReference> EinvoiceSummaryReferences { get; set; } = new List<EinvoiceSummaryReference>();

    public virtual AccountObject? Employee { get; set; }

    public virtual ICollection<SainvoicePetroleumDetail> SainvoicePetroleumDetails { get; set; } = new List<SainvoicePetroleumDetail>();

    public virtual ICollection<SainvoicePetroleumReference> SainvoicePetroleumReferences { get; set; } = new List<SainvoicePetroleumReference>();
}