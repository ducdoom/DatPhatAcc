﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// (Bảng chi tiết)Chứng từ nghiệp vụ khác, Hạch toán chi phí lương 
/// </summary>
public partial class GlvoucherDetail
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
    /// Số tiền quy đổi/Số chênh lệch trên Tỷ giá xuất quỹ
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// % thuế GTGT
    /// </summary>
    public decimal? Vatrate { get; set; }

    /// <summary>
    /// Tiền thuế GTGT quy đổi
    /// </summary>
    public decimal Vatamount { get; set; }

    /// <summary>
    /// TK thuế GTGT
    /// </summary>
    public string? Vataccount { get; set; }

    /// <summary>
    /// Tài khoản ngân hàng
    /// </summary>
    public Guid? BankAccountId { get; set; }

    /// <summary>
    /// Đối tượng THCP
    /// </summary>
    public Guid? JobId { get; set; }

    /// <summary>
    /// Hợp đồng mua
    /// </summary>
    public Guid? PucontractId { get; set; }

    /// <summary>
    /// Hợp đồng
    /// </summary>
    public Guid? ContractId { get; set; }

    /// <summary>
    /// Đối tượng Nợ
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Đối tượng Có
    /// </summary>
    public Guid? CreditAccountObjectId { get; set; }

    /// <summary>
    /// Mã thống kê
    /// </summary>
    public Guid? ListItemId { get; set; }

    /// <summary>
    /// Đơn vị
    /// </summary>
    public Guid? OrganizationUnitId { get; set; }

    /// <summary>
    /// Khoản mục chi phí
    /// </summary>
    public Guid? ExpenseItemId { get; set; }

    /// <summary>
    /// Công trình/Dự án
    /// </summary>
    public Guid? ProjectWorkId { get; set; }

    /// <summary>
    /// Đơn hàng
    /// </summary>
    public Guid? OrderId { get; set; }

    /// <summary>
    /// Chi phí không hợp lý
    /// </summary>
    public bool UnResonableCost { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp các dòng chi tiết
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Loại tiền tỷ giá xuất quỹ
    /// </summary>
    public string? CashOutCurrencyId { get; set; }

    /// <summary>
    /// Số tiền đã xuất quỹ
    /// </summary>
    public decimal? CashOutAmountOc { get; set; }

    /// <summary>
    /// Số tiền Quy đổi đã xuất quỹ (theo chứng từ gốc)
    /// </summary>
    public decimal? CashOutAmountOrg { get; set; }

    /// <summary>
    /// Tỷ giá xuất quỹ bình quân
    /// </summary>
    public decimal? CashOutExchangeRate { get; set; }

    /// <summary>
    /// Số tiền Quy đổi theo tỷ giá xuất quỹ
    /// </summary>
    public decimal? CashOutAmount { get; set; }

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

    /// <summary>
    /// Mục chi/thu
    /// </summary>
    public Guid? BudgetItemId { get; set; }

    /// <summary>
    /// Tiền thuế GTGT
    /// </summary>
    public decimal VatamountOc { get; set; }

    /// <summary>
    /// Kê lên tờ khai
    /// </summary>
    public bool IsListOnTaxDeclaration { get; set; }

    public string? InvTemplateNo { get; set; }

    public string? InvSeries { get; set; }

    public DateTime? InvDate { get; set; }

    public string? InvNo { get; set; }

    public Guid? PurchasePurposeId { get; set; }

    public Guid? TaxAccountObjectId { get; set; }

    public string? TaxAccountObjectName { get; set; }

    public string? TaxAccountObjectTaxCode { get; set; }

    public string? TaxAccountObjectAddress { get; set; }

    public string? Vatdescription { get; set; }

    public Guid? EmployeeId { get; set; }

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

    /// <summary>
    /// Số TK ngân hàng của đối tượng Nợ
    /// </summary>
    public string? DebitBankAccount { get; set; }

    /// <summary>
    /// Tên ngân hàng của đối tượng Nợ
    /// </summary>
    public string? DebitBankName { get; set; }

    public decimal LastExchangeRate { get; set; }

    /// <summary>
    /// Không có hóa đơn
    /// </summary>
    public bool NotIncludeInvoice { get; set; }

    public int? BusinessType { get; set; }

    public Guid? PuorderRefId { get; set; }

    public Guid? LoanagreementId { get; set; }

    public Guid? InvestmentProjectId { get; set; }

    public decimal? VatrateOther { get; set; }

    public virtual AccountObject? AccountObject { get; set; }

    public virtual BankAccount? BankAccount { get; set; }

    public virtual BudgetItem? BudgetItem { get; set; }

    public virtual Ccy? CashOutCurrency { get; set; }

    public virtual Account? CashOutDiffAccountNumberFinanceNavigation { get; set; }

    public virtual Account? CashOutDiffAccountNumberManagementNavigation { get; set; }

    public virtual Contract? Contract { get; set; }

    public virtual Account? CreditAccountNavigation { get; set; }

    public virtual AccountObject? CreditAccountObject { get; set; }

    public virtual Account? DebitAccountNavigation { get; set; }

    public virtual AccountObject? Employee { get; set; }

    public virtual ExpenseItem? ExpenseItem { get; set; }

    public virtual InvestmentProject? InvestmentProject { get; set; }

    public virtual Job? Job { get; set; }

    public virtual ListItem? ListItem { get; set; }

    public virtual Loanagreement? Loanagreement { get; set; }

    public virtual Saorder? Order { get; set; }

    public virtual OrganizationUnit? OrganizationUnit { get; set; }

    public virtual ProjectWork? ProjectWork { get; set; }

    public virtual Pucontract? Pucontract { get; set; }

    public virtual Puorder? PuorderRef { get; set; }

    public virtual Glvoucher Ref { get; set; } = null!;

    public virtual Account? VataccountNavigation { get; set; }
}