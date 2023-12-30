﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class IninvoiceHubOutwardDetail
{
    public Guid RefDetailId { get; set; }

    public Guid RefId { get; set; }

    public Guid InventoryItemId { get; set; }

    public string? Description { get; set; }

    public Guid? StockId { get; set; }

    public string? DebitAccount { get; set; }

    public string? CreditAccount { get; set; }

    public Guid? UnitId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPriceFinance { get; set; }

    public decimal UnitPriceManagement { get; set; }

    public decimal AmountFinance { get; set; }

    public decimal AmountManagement { get; set; }

    public string? LotNo { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public bool IsUnUpdateOutwardPrice { get; set; }

    public Guid? ProductionId { get; set; }

    public Guid? ProductionOrderRefId { get; set; }

    public Guid? ConfrontingRefId { get; set; }

    public Guid? ConfrontingRefDetailId { get; set; }

    public Guid? ExpenseItemId { get; set; }

    public Guid? JobId { get; set; }

    public Guid? ProjectWorkId { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? ContractId { get; set; }

    public Guid? OrganizationUnitId { get; set; }

    public bool UnResonableCost { get; set; }

    public Guid? ListItemId { get; set; }

    public Guid? MainUnitId { get; set; }

    public decimal MainUnitPriceFinance { get; set; }

    public decimal MainUnitPriceManagement { get; set; }

    public decimal MainConvertRate { get; set; }

    public decimal MainQuantity { get; set; }

    public string ExchangeRateOperator { get; set; } = null!;

    public int? SortOrder { get; set; }

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

    public bool IsPromotion { get; set; }

    public Guid? SaorderRefDetailId { get; set; }

    public decimal? SalePrice { get; set; }

    public decimal? SaleAmount { get; set; }

    public Guid? AccountObjectId { get; set; }

    public Guid? ContractDetailId { get; set; }

    public int? InventoryResaleTypeId { get; set; }

    public Guid? PucontractId { get; set; }

    public Guid? InassemblyRefId { get; set; }

    public Guid? InassemblyRefDetailId { get; set; }

    public Guid? PuvoucherRefId { get; set; }

    public string? AccountObjectName { get; set; }

    public Guid? IntransferRefId { get; set; }

    public Guid? IntransferRefDetailId { get; set; }

    public Guid? BudgetItemId { get; set; }

    public Guid? PuvoucherRefDetailId { get; set; }

    public virtual AccountObject? AccountObject { get; set; }

    public virtual Contract? Contract { get; set; }

    public virtual ContractDetailInventoryItem? ContractDetail { get; set; }

    public virtual Account? CreditAccountNavigation { get; set; }

    public virtual Account? DebitAccountNavigation { get; set; }

    public virtual ExpenseItem? ExpenseItem { get; set; }

    public virtual InventoryItem InventoryItem { get; set; } = null!;

    public virtual Job? Job { get; set; }

    public virtual ListItem? ListItem { get; set; }

    public virtual Unit? MainUnit { get; set; }

    public virtual Saorder? Order { get; set; }

    public virtual OrganizationUnit? OrganizationUnit { get; set; }

    public virtual InproductionOrderProduct? Production { get; set; }

    public virtual InproductionOrder? ProductionOrderRef { get; set; }

    public virtual ProjectWork? ProjectWork { get; set; }

    public virtual Pucontract? Pucontract { get; set; }

    public virtual Puvoucher? PuvoucherRef { get; set; }

    public virtual IninvoiceHubOutward Ref { get; set; } = null!;

    public virtual SaorderDetail? SaorderRefDetail { get; set; }

    public virtual Stock? Stock { get; set; }

    public virtual Unit? Unit { get; set; }
}