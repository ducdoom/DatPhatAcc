﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng Detail của chứng từ chi tiền gửi. Bao gồm các loại chi sau:
/// - Chi tiền gửi thông thường
/// - Chi tiền gửi trả nhà cung cấp
/// - Tiền đang chuyển đi
/// </summary>
public partial class BawithDrawDetail
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
    public string Description { get; set; }

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string DebitAccount { get; set; }

    /// <summary>
    /// Tài khoản Có
    /// </summary>
    public string CreditAccount { get; set; }

    /// <summary>
    /// Số tiền
    /// </summary>
    public decimal AmountOc { get; set; }

    /// <summary>
    /// Số tiền quy đổi
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Mục chi
    /// </summary>
    public Guid? BudgetItemId { get; set; }

    /// <summary>
    /// Công trình/vụ việc
    /// </summary>
    public Guid? ProjectWorkId { get; set; }

    /// <summary>
    /// ĐT tập hợp chi phí
    /// </summary>
    public Guid? JobId { get; set; }

    /// <summary>
    /// Đơn hàng
    /// </summary>
    public Guid? OrderId { get; set; }

    /// <summary>
    /// Hợp đồng bán
    /// </summary>
    public Guid? ContractId { get; set; }

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
    /// Khế ước vay
    /// </summary>
    public Guid? DebtAgreementId { get; set; }

    /// <summary>
    /// Chi phí không hợp lý
    /// </summary>
    public bool UnResonableCost { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp các dòng chi tiết
    /// </summary>
    public int? SortOrder { get; set; }

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

    /// <summary>
    /// ID đối tượng
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Hợp đồng mua
    /// </summary>
    public Guid? PucontractId { get; set; }

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
    public string CashOutDiffAccountNumberFinance { get; set; }

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
    public string CashOutDiffAccountNumberManagement { get; set; }

    /// <summary>
    /// Tỷ giá xuất quỹ sổ tài chính
    /// </summary>
    public decimal CashOutExchangeRateFinance { get; set; }

    /// <summary>
    /// Tỷ giá xuất quỹ sổ quản trị
    /// </summary>
    public decimal CashOutExchangeRateManagement { get; set; }

    public int? BusinessType { get; set; }

    public Guid? PuorderRefId { get; set; }

    public Guid? LoanagreementId { get; set; }

    public virtual AccountObject AccountObject { get; set; }

    public virtual BudgetItem BudgetItem { get; set; }

    public virtual Account CashOutDiffAccountNumberFinanceNavigation { get; set; }

    public virtual Account CashOutDiffAccountNumberManagementNavigation { get; set; }

    public virtual Contract Contract { get; set; }

    public virtual Account CreditAccountNavigation { get; set; }

    public virtual Account DebitAccountNavigation { get; set; }

    public virtual DebtAgreement DebtAgreement { get; set; }

    public virtual ExpenseItem ExpenseItem { get; set; }

    public virtual Job Job { get; set; }

    public virtual ListItem ListItem { get; set; }

    public virtual Loanagreement Loanagreement { get; set; }

    public virtual OrganizationUnit OrganizationUnit { get; set; }

    public virtual ProjectWork ProjectWork { get; set; }

    public virtual Pucontract Pucontract { get; set; }

    public virtual Puorder PuorderRef { get; set; }

    public virtual BawithDraw Ref { get; set; }
}