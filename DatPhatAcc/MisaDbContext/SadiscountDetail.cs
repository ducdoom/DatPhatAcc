﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng Detail của hàng bán giảm giá
/// </summary>
public partial class SadiscountDetail
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
    /// Mã hàng
    /// </summary>
    public Guid InventoryItemId { get; set; }

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
    /// Đơn vị tính
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// Số lượng
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Đơn giá
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Đơn giá sau thuế
    /// </summary>
    public decimal UnitPriceAfterTax { get; set; }

    /// <summary>
    /// Thành tiền trước thuế
    /// </summary>
    public decimal AmountOc { get; set; }

    /// <summary>
    /// Thành tiền trước thuế quy đổi
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Tỷ lệ chiết khấu
    /// </summary>
    public decimal? DiscountRate { get; set; }

    /// <summary>
    /// Tiền chiết khấu
    /// </summary>
    public decimal DiscountAmountOc { get; set; }

    /// <summary>
    /// Tiền chiết khấu quy đổi
    /// </summary>
    public decimal DiscountAmount { get; set; }

    /// <summary>
    /// TK chiết khấu
    /// </summary>
    public string? DiscountAccount { get; set; }

    /// <summary>
    /// % thuế GTGT
    /// </summary>
    public decimal? Vatrate { get; set; }

    /// <summary>
    /// Tiền thuế nguyên tệ
    /// </summary>
    public decimal VatamountOc { get; set; }

    /// <summary>
    /// Tiền thuế quy đổi
    /// </summary>
    public decimal Vatamount { get; set; }

    /// <summary>
    /// TK Thuế
    /// </summary>
    public string? Vataccount { get; set; }

    /// <summary>
    /// Mã thống kê
    /// </summary>
    public Guid? ListItemId { get; set; }

    /// <summary>
    /// Hợp đồng
    /// </summary>
    public Guid? ContractId { get; set; }

    /// <summary>
    /// Đơn hàng
    /// </summary>
    public Guid? OrderId { get; set; }

    /// <summary>
    /// ID công trình
    /// </summary>
    public Guid? ProjectWorkId { get; set; }

    /// <summary>
    /// Khoản mục chi phí
    /// </summary>
    public Guid? ExpenseItemId { get; set; }

    /// <summary>
    /// Đơn vị
    /// </summary>
    public Guid? OrganizationUnitId { get; set; }

    /// <summary>
    /// RefID của chứng từ bán hàng
    /// </summary>
    public Guid? SavoucherRefId { get; set; }

    /// <summary>
    /// RefDetailID của chứng từ bán hàng
    /// </summary>
    public Guid? SavoucherRefDetailId { get; set; }

    /// <summary>
    /// Đơn vị tính chính
    /// </summary>
    public Guid? MainUnitId { get; set; }

    /// <summary>
    /// Đơn giá theo đơn vị chính
    /// </summary>
    public decimal MainUnitPrice { get; set; }

    /// <summary>
    /// Tỷ lệ chuyển đổi ra đơn vị chính
    /// </summary>
    public decimal MainConvertRate { get; set; }

    /// <summary>
    /// Số lượng theo đơn vị chính
    /// </summary>
    public decimal MainQuantity { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp các dòng chi tiết
    /// </summary>
    public int SortOrder { get; set; }

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
    /// ID nhóm ngành nghề
    /// </summary>
    public int? TacareerGroupId { get; set; }

    /// <summary>
    /// ID của hóa đơn xuất (mục đích dễ dàng join lấy lên Hóa đơn xuất)
    /// </summary>
    public Guid? SainvoiceRefId { get; set; }

    /// <summary>
    /// Mục thu
    /// </summary>
    public Guid? BudgetItemId { get; set; }

    public Guid? JobId { get; set; }

    public Guid? BankAccountId { get; set; }

    public string? Vatdescription { get; set; }

    public bool UnResonableCost { get; set; }

    /// <summary>
    /// HHDV không tổng hợp trên tờ khai GTGT
    /// </summary>
    public bool NotInVatdeclaration { get; set; }

    /// <summary>
    /// Quy đổi theo Tỷ giá xuất quỹ sổ tài chính
    /// </summary>
    public decimal CashOutAmountFinance { get; set; }

    /// <summary>
    /// Chênh lệch Tỷ giá xuất quỹ sổ tài chính
    /// </summary>
    public decimal CashOutDiffAmountFinance { get; set; }

    /// <summary>
    /// Tiền thuế quy đổi theo Tỷ giá xuất quỹ sổ tài chính
    /// </summary>
    public decimal CashOutVatamountFinance { get; set; }

    /// <summary>
    /// Chênh lệch tiền thuế
    /// </summary>
    public decimal CashOutDiffVatamountFinance { get; set; }

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
    /// Tiền thuế quy đổi theo Tỷ giá xuất quỹ sổ quản trị
    /// </summary>
    public decimal CashOutVatamountManagement { get; set; }

    /// <summary>
    /// Chênh lệch tiền thuế
    /// </summary>
    public decimal CashOutDiffVatamountManagement { get; set; }

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

    public Guid? SaorderRefDetailId { get; set; }

    public Guid? LoanagreementId { get; set; }

    public decimal? VatrateOther { get; set; }

    public Guid? ContractDetailId { get; set; }

    public virtual BankAccount? BankAccount { get; set; }

    public virtual BudgetItem? BudgetItem { get; set; }

    public virtual Account? CashOutDiffAccountNumberFinanceNavigation { get; set; }

    public virtual Account? CashOutDiffAccountNumberManagementNavigation { get; set; }

    public virtual Contract? Contract { get; set; }

    public virtual ContractDetailInventoryItem? ContractDetail { get; set; }

    public virtual ExpenseItem? ExpenseItem { get; set; }

    public virtual InventoryItem InventoryItem { get; set; } = null!;

    public virtual Job? Job { get; set; }

    public virtual ListItem? ListItem { get; set; }

    public virtual Loanagreement? Loanagreement { get; set; }

    public virtual Unit? MainUnit { get; set; }

    public virtual Saorder? Order { get; set; }

    public virtual OrganizationUnit? OrganizationUnit { get; set; }

    public virtual ProjectWork? ProjectWork { get; set; }

    public virtual Sadiscount Ref { get; set; } = null!;

    public virtual Sainvoice? SainvoiceRef { get; set; }

    public virtual SaorderDetail? SaorderRefDetail { get; set; }

    public virtual Savoucher? SavoucherRef { get; set; }

    public virtual SavoucherDetail? SavoucherRefDetail { get; set; }

    public virtual TacareerGroup? TacareerGroup { get; set; }

    public virtual Unit? Unit { get; set; }
}