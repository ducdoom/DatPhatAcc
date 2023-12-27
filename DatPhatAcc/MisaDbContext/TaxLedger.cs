﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class TaxLedger
{
    public int TaxLedgerId { get; set; }

    public Guid RefId { get; set; }

    public Guid? RefDetailId { get; set; }

    public string Vataccount { get; set; }

    public string CorespondingAccountNumber { get; set; }

    public int TaxType { get; set; }

    public string Description { get; set; }

    public decimal VatamountOc { get; set; }

    public decimal Vatamount { get; set; }

    public decimal? Vatrate { get; set; }

    public decimal TurnOverAmountOc { get; set; }

    public decimal TurnOverAmount { get; set; }

    public string InvTemplateNo { get; set; }

    public DateTime? InvDate { get; set; }

    public string InvSeries { get; set; }

    public string InvNo { get; set; }

    public Guid? AccountObjectId { get; set; }

    public string AccountObjectName { get; set; }

    public string AccountObjectNameDi { get; set; }

    public string AccountObjectAddress { get; set; }

    public string CompanyTaxCode { get; set; }

    public Guid? BranchId { get; set; }

    public Guid? PurchasePurposeId { get; set; }

    public int? SortOrder { get; set; }

    public int? RefOrder { get; set; }

    public int? RefType { get; set; }

    public DateTime? RefDate { get; set; }

    public DateTime? PostedDate { get; set; }

    public string RefNo { get; set; }

    public string AccountObjectCode { get; set; }

    public string PurchasePurposeCode { get; set; }

    public string PurchasePurposeName { get; set; }

    public int TableListType { get; set; }

    public DateTime? PaymentDate { get; set; }

    public int SaleTableListType { get; set; }

    public bool? IsUpdateRedundant { get; set; }

    public bool IsPostToManagementBook { get; set; }

    public Guid? InvRefId { get; set; }

    public int? TacareerGroupId { get; set; }

    public int? VoucherRefType { get; set; }

    public Guid? VoucherRefId { get; set; }

    public Guid? VoucherRefDetailId { get; set; }

    public string VoucherRefNo { get; set; }

    public DateTime? VoucherRefDate { get; set; }

    public DateTime? VoucherPostedDate { get; set; }

    /// <summary>
    /// HHDV không tổng hợp trên tờ khai GTGT
    /// </summary>
    public bool NotInVatdeclaration { get; set; }

    /// <summary>
    /// Posteddate của chứng từ liên quan (dùng để lên bảng kê)
    /// </summary>
    public DateTime? OriginInvoicePostedDate { get; set; }

    /// <summary>
    /// Reftype của chứng từ liên quan (dùng để lên bảng kê)
    /// </summary>
    public int? OriginInvoiceRefType { get; set; }

    /// <summary>
    /// RefID của chứng từ liên quan (dùng để lên bảng kê)
    /// </summary>
    public Guid? OriginInvoiceRefId { get; set; }

    /// <summary>
    /// Refno của chứng từ liên quan (dùng để lên bảng kê)
    /// </summary>
    public string OriginInvoiceRefNo { get; set; }

    /// <summary>
    /// RefDate của chứng từ liên quan (dùng để lên bảng kê)
    /// </summary>
    public DateTime? OriginInvoiceRefDate { get; set; }

    /// <summary>
    /// Diễn giải master chứng từ liên quan (dùng để lên bảng kê)
    /// </summary>
    public string OriginInvoiceJournalMemo { get; set; }

    /// <summary>
    /// Diễn giải master của hóa đơn
    /// </summary>
    public string JournalMemo { get; set; }

    /// <summary>
    /// Reftype của chứng từ gốc
    /// </summary>
    public int? OriginRefType { get; set; }

    /// <summary>
    /// RefID của chứng từ gốc
    /// </summary>
    public Guid? OriginRefId { get; set; }

    public Guid? InvestmentProjectId { get; set; }

    public decimal? VatrateOther { get; set; }
}