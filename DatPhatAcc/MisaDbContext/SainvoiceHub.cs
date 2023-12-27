﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SainvoiceHub
{
    public Guid RefId { get; set; }

    public Guid BranchId { get; set; }

    public int? DisplayOnBook { get; set; }

    public int RefType { get; set; }

    public Guid? AccountObjectId { get; set; }

    public string AccountObjectName { get; set; }

    public string AccountObjectAddress { get; set; }

    public string AccountObjectTaxCode { get; set; }

    public string AccountObjectBankAccount { get; set; }

    public string PaymentMethod { get; set; }

    public string Buyer { get; set; }

    public Guid? EmployeeId { get; set; }

    public bool IsPaid { get; set; }

    public bool IsPosted { get; set; }

    public string InvTemplateNo { get; set; }

    public string InvSeries { get; set; }

    public string InvNo { get; set; }

    public DateTime? InvDate { get; set; }

    public bool IncludeInvoice { get; set; }

    public bool IsAttachList { get; set; }

    public string ListNo { get; set; }

    public DateTime? ListDate { get; set; }

    public string CommonInventoryName { get; set; }

    public string ContractCode { get; set; }

    public DateTime? ContractDate { get; set; }

    public string PlaceOfDelivery { get; set; }

    public string PlaceOfReceipt { get; set; }

    public string BillOfLadingNo { get; set; }

    public string ContainerNo { get; set; }

    public string TransportName { get; set; }

    public string CurrencyId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal TotalSaleAmountOc { get; set; }

    public decimal TotalSaleAmount { get; set; }

    public decimal TotalDiscountAmountOc { get; set; }

    public decimal TotalDiscountAmount { get; set; }

    public decimal TotalVatamountOc { get; set; }

    public decimal TotalVatamount { get; set; }

    public decimal TotalAmountOc { get; set; }

    public decimal TotalAmount { get; set; }

    public byte[] EditVersion { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string ModifiedBy { get; set; }

    public int? InvTypeId { get; set; }

    public bool? IsBranchIssued { get; set; }

    public string CustomField1 { get; set; }

    public string CustomField2 { get; set; }

    public string CustomField3 { get; set; }

    public string CustomField4 { get; set; }

    public string CustomField5 { get; set; }

    public string CustomField6 { get; set; }

    public string CustomField7 { get; set; }

    public string CustomField8 { get; set; }

    public string CustomField9 { get; set; }

    public string CustomField10 { get; set; }

    public bool IsPostedLastYear { get; set; }

    public bool IsInvoiceReplace { get; set; }

    public Guid? AdjustRefId { get; set; }

    public int? AdjustRefType { get; set; }

    public string AdjustJournalMemo { get; set; }

    public Guid? AdjustPurchasePurposeId { get; set; }

    public decimal? AdjustVatrate { get; set; }

    public int? AdjustTacareerGroupId { get; set; }

    public string AdjustInvTemplateNo { get; set; }

    public string AdjustInvSeries { get; set; }

    public string AdjustInvNo { get; set; }

    public DateTime? AdjustInvDate { get; set; }

    public bool ExportNontariffZones { get; set; }

    public string RefIdmshop { get; set; }

    public string RefNoMshop { get; set; }

    public bool? IsGetForInvoice { get; set; }

    public Guid? AdjustInvestmentProjectId { get; set; }

    public virtual AccountObject AccountObject { get; set; }

    public virtual OrganizationUnit Branch { get; set; }

    public virtual Ccy Currency { get; set; }

    public virtual AccountObject Employee { get; set; }

    public virtual ICollection<SainvoiceHubDetail> SainvoiceHubDetails { get; set; } = new List<SainvoiceHubDetail>();
}