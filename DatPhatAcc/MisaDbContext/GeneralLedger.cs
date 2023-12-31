﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class GeneralLedger
{
    public int GeneralLedgerId { get; set; }

    public Guid RefId { get; set; }

    public Guid? RefDetailId { get; set; }

    public int RefType { get; set; }

    public string? RefNo { get; set; }

    public DateTime RefDate { get; set; }

    public DateTime PostedDate { get; set; }

    public string? InvNo { get; set; }

    public DateTime? InvDate { get; set; }

    public string? InvSeries { get; set; }

    public string? AccountNumber { get; set; }

    public string? CorrespondingAccountNumber { get; set; }

    public Guid? BankAccountId { get; set; }

    public string? CurrencyId { get; set; }

    public decimal ExchangeRate { get; set; }

    public decimal DebitAmountOc { get; set; }

    public decimal DebitAmount { get; set; }

    public decimal CreditAmountOc { get; set; }

    public decimal CreditAmount { get; set; }

    public string? JournalMemo { get; set; }

    public string? Description { get; set; }

    public string? ContactName { get; set; }

    public Guid? AccountObjectId { get; set; }

    public string? AccountObjectName { get; set; }

    public string? AccountObjectTaxCode { get; set; }

    public string? AccountObjectAddress { get; set; }

    public string? AccountObjectBankAccount { get; set; }

    public string? AccountObjectBankName { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? ExpenseItemId { get; set; }

    public Guid? OrganizationUnitId { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? JobId { get; set; }

    public Guid? ProjectWorkId { get; set; }

    public Guid? PucontractId { get; set; }

    public Guid? ContractId { get; set; }

    public Guid? ListItemId { get; set; }

    public Guid? PaymentTermId { get; set; }

    public Guid? BranchId { get; set; }

    public bool? UnResonableCost { get; set; }

    public bool IsPostToManagementBook { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? RefNo1 { get; set; }

    public string? RefNo2 { get; set; }

    public DateTime? RefDate1 { get; set; }

    public int? SortOrder { get; set; }

    public int? RefOrder { get; set; }

    public string? AccountName { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? BankName { get; set; }

    public string? AccountObjectCode { get; set; }

    public string? EmployeeCode { get; set; }

    public string? EmployeeName { get; set; }

    public string? PucontractCode { get; set; }

    public string? PucontractName { get; set; }

    public string? ContractCode { get; set; }

    public string? ContractName { get; set; }

    public string? PaymentTermCode { get; set; }

    public string? PaymentTermName { get; set; }

    public Guid? InventoryItemId { get; set; }

    public string? InventoryItemCode { get; set; }

    public string? InventoryItemName { get; set; }

    public bool? IsUpdateRedundant { get; set; }

    public string? AccountObjectNameDi { get; set; }

    public Guid? BudgetItemId { get; set; }

    public string? RefTypeName { get; set; }

    public Guid? UnitId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPriceOc { get; set; }

    public decimal UnitPrice { get; set; }

    public int EntryType { get; set; }

    public Guid? InvRefId { get; set; }

    public DateTime? PusignDate { get; set; }

    public DateTime? ContractSignDate { get; set; }

    public Guid? PuorderRefId { get; set; }

    public Guid? MainUnitId { get; set; }

    public decimal MainUnitPrice { get; set; }

    public decimal MainQuantity { get; set; }

    public decimal MainConvertRate { get; set; }

    public string ExchangeRateOperator { get; set; } = null!;

    public Guid? StockId { get; set; }

    public string? StockCode { get; set; }

    public string? StockName { get; set; }

    public string? DocumentIncluded { get; set; }

    public int DetailPostOrder { get; set; }

    public decimal? MainUnitPriceOc { get; set; }

    /// <summary>
    /// 0: Dòng định khoản thường; 1: Dòng xử lý CLTG tiền
    /// </summary>
    public bool IsPostedForCashOutDiff { get; set; }

    public decimal? CashOutExchangeRateLedger { get; set; }

    public int? BusinessType { get; set; }

    public int? TaxYear { get; set; }

    public Guid? LoanagreementId { get; set; }
}