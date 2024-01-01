﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SearchConfig
{
    public Guid SearchResultConfigId { get; set; }

    public string? MasterTableName { get; set; }

    public string? DetailTableName { get; set; }

    public string? DetailTableName1 { get; set; }

    public string? FilterCondition { get; set; }

    public string? RefId { get; set; }

    public string? RefType { get; set; }

    public string? RefNoFinance { get; set; }

    public string? RefNoManagement { get; set; }

    public string? CabarefNoFinance { get; set; }

    public string? CabarefNoManagement { get; set; }

    public string? RefDate { get; set; }

    public string? PostedDate { get; set; }

    public string? InvNo { get; set; }

    public string? InvDate { get; set; }

    public string? CurrencyId { get; set; }

    public string? TotalAmountOcfinance { get; set; }

    public string? TotalAmountOcmanagement { get; set; }

    public string? TotalAmountFinance { get; set; }

    public string? TotalAmountManagement { get; set; }

    public string? DebitAccount { get; set; }

    public string? CreditAccount { get; set; }

    public string? InventoryItemId { get; set; }

    public string? InstockId { get; set; }

    public string? OutStockId { get; set; }

    public string? Quantity { get; set; }

    public string? UnitPriceFinance { get; set; }

    public string? UnitPriceManagement { get; set; }

    public string? AmountOcfinance { get; set; }

    public string? AmountOcmanagement { get; set; }

    public string? AmountFinance { get; set; }

    public string? AmountManagement { get; set; }

    public string? DiscountRate { get; set; }

    public string? DiscountAmount { get; set; }

    public string? DiscountAmountOc { get; set; }

    public string? FixedAssetId { get; set; }

    public string? SupplyId { get; set; }

    public string? DebitAccountObjectId { get; set; }

    public string? CreditAccountObjectId { get; set; }

    public string? OrganizationUnitId { get; set; }

    public string? EmployeeId { get; set; }

    public string? ExpenseItemId { get; set; }

    public string? ProjectWorkId { get; set; }

    public string? JobId { get; set; }

    public string? PurchasePurposeId { get; set; }

    public string? UnitId { get; set; }

    public string? OrderId { get; set; }

    public string? PuorderRefId { get; set; }

    public string? ContractId { get; set; }

    public string? PucontractId { get; set; }

    public string? ListItemId { get; set; }

    public string? Description { get; set; }

    public string? IsPostedFinance { get; set; }

    public string? IsPostedManagement { get; set; }

    public string? DisplayOnBook { get; set; }

    public string? BranchId { get; set; }

    public int SortOrder { get; set; }

    public int? SearchType { get; set; }

    public string? DetailInventoryItemId { get; set; }

    public string? DetailUnitId { get; set; }

    public string? DetailJobId { get; set; }

    public string? DetailOrganizationUnitId { get; set; }

    public string? DetailExpenseItemId { get; set; }

    public string? DetailContractId { get; set; }

    public string? BankAccountId { get; set; }

    public string? MasterAccountObjectId { get; set; }

    public string? DetailDescription { get; set; }

    public Guid? InvestmentProjectId { get; set; }
}