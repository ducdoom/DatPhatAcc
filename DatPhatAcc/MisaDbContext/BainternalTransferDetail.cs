﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết chuyển tiền nội bộ
/// </summary>
public partial class BainternalTransferDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// TK Nợ
    /// </summary>
    public string? DebitAccount { get; set; }

    /// <summary>
    /// TK Có
    /// </summary>
    public string? CreditAccount { get; set; }

    /// <summary>
    /// Số tiền
    /// </summary>
    public decimal AmountOc { get; set; }

    /// <summary>
    /// Số tiền quy đổi
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Mã thống kê
    /// </summary>
    public Guid? ListItemId { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp các dòng chi tiết
    /// </summary>
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

    public Guid? OrganizationUnitId { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? PucontractId { get; set; }

    public Guid? ContractId { get; set; }

    public Guid? JobId { get; set; }

    public Guid? ProjectWorkId { get; set; }

    public Guid? ExpenseItemId { get; set; }

    public bool UnResonableCost { get; set; }

    /// <summary>
    /// Quy đổi theo Tỷ giá xuất quỹ sổ tài chính
    /// </summary>
    public decimal CashOutAmountFinance { get; set; }

    /// <summary>
    /// Chênh lệch Tỷ giá xuất quỹ sổ tài chính
    /// </summary>
    public decimal CashOutDiffAmountFinance { get; set; }

    /// <summary>
    /// Tài khoản xử lý chênh lệch Tỷ giá xuất quỹ sổ tài chính
    /// </summary>
    public string? CashOutDiffAccountNumberFinance { get; set; }

    /// <summary>
    /// Quy đổi theo Tỷ giá xuất quỹ sổ quản trị
    /// </summary>
    public decimal CashOutAmountManagement { get; set; }

    /// <summary>
    /// Chênh lệch Tỷ giá xuất quỹ sổ quản trị
    /// </summary>
    public decimal CashOutDiffAmountManagement { get; set; }

    /// <summary>
    /// Tài khoản xử lý chênh lệch Tỷ giá xuất quỹ sổ quản trị
    /// </summary>
    public string? CashOutDiffAccountNumberManagement { get; set; }

    /// <summary>
    /// Tỷ giá xuất quỹ sổ tài chính
    /// </summary>
    public decimal CashOutExchangeRateFinance { get; set; }

    /// <summary>
    /// Tỷ giá xuất quỹ sổ quản trị
    /// </summary>
    public decimal CashOutExchangeRateManagement { get; set; }

    public Guid? PuorderRefId { get; set; }

    public Guid? BudgetItemId { get; set; }

    public Guid? LoanagreementId { get; set; }

    public virtual Account? CashOutDiffAccountNumberFinanceNavigation { get; set; }

    public virtual Account? CashOutDiffAccountNumberManagementNavigation { get; set; }

    public virtual Contract? Contract { get; set; }

    public virtual Account? CreditAccountNavigation { get; set; }

    public virtual Account? DebitAccountNavigation { get; set; }

    public virtual ExpenseItem? ExpenseItem { get; set; }

    public virtual ListItem? ListItem { get; set; }

    public virtual Loanagreement? Loanagreement { get; set; }

    public virtual Pucontract? Pucontract { get; set; }

    public virtual Puorder? PuorderRef { get; set; }

    public virtual BainternalTransfer Ref { get; set; } = null!;
}