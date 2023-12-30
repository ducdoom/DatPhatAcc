﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Khế ước vay/ Hợp đồng tín dụng
/// </summary>
public partial class Loanagreement
{
    /// <summary>
    /// Khóa chính
    /// </summary>
    public Guid LoanagreementId { get; set; }

    public int RefType { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Là hợp đồng/khế ước
    /// </summary>
    public bool IsContract { get; set; }

    /// <summary>
    /// Hợp đồng dự toán cha
    /// </summary>
    public Guid? LoancontractId { get; set; }

    /// <summary>
    /// Mã HĐ/Khế ước
    /// </summary>
    public string LoanagreementCode { get; set; } = null!;

    /// <summary>
    /// 0: hợp đồng tín dụng hạn mức, 1: hợp đồng tín dụng khác
    /// </summary>
    public bool IsContractOther { get; set; }

    /// <summary>
    /// Ngày ký
    /// </summary>
    public DateTime? SignDate { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public string? CurrencyId { get; set; }

    /// <summary>
    /// Tỷ giá
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// Hạn mức cho vay/Số tiền cho vay
    /// </summary>
    public decimal LoancontractAmount { get; set; }

    /// <summary>
    /// Hạn mức cho vay quy đổi/Số tiền cho vay nguyên tệ
    /// </summary>
    public decimal LoancontractAmountOc { get; set; }

    /// <summary>
    /// Số kỳ hạn duy trì hạn mức
    /// </summary>
    public int Loanexpried { get; set; }

    /// <summary>
    /// Loại kỳ hạn duy trì hạn mức
    /// </summary>
    public int ExpriedType { get; set; }

    /// <summary>
    /// Từ ngày duy trì hạn mức
    /// </summary>
    public DateTime ExpriedFromDate { get; set; }

    /// <summary>
    /// Đến ngày duy trì hạn mức
    /// </summary>
    public DateTime ExpriedToDate { get; set; }

    /// <summary>
    /// ID đối tượng cho vay
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Tên đối tượng cho vay
    /// </summary>
    public string? AccountObjectName { get; set; }

    /// <summary>
    /// Phương thức cho vay
    /// </summary>
    public string? Loanmethod { get; set; }

    /// <summary>
    /// Mục đích sử dụng vốn
    /// </summary>
    public string? Description { get; set; }

    public string? DebitAccount { get; set; }

    public string? RepayAccount { get; set; }

    /// <summary>
    /// Hình thức giải ngân
    /// </summary>
    public int DisbursementMethod { get; set; }

    /// <summary>
    /// ID tài khoản ngân hàng
    /// </summary>
    public Guid? BankAccountId { get; set; }

    /// <summary>
    /// Chi nhánh ngân hàng
    /// </summary>
    public string? BankBranch { get; set; }

    /// <summary>
    /// Tên tài khoản ngân hàng
    /// </summary>
    public string? BankName { get; set; }

    /// <summary>
    /// ID nhà cung cấp
    /// </summary>
    public Guid? VendorId { get; set; }

    /// <summary>
    /// Tên nhà cung cấp
    /// </summary>
    public string? VendorName { get; set; }

    /// <summary>
    /// Số TK ngân hàng NCC
    /// </summary>
    public string? BankAccountVendor { get; set; }

    /// <summary>
    /// Tên TK ngân hàng NCC
    /// </summary>
    public string? BankNameVendor { get; set; }

    /// <summary>
    /// Loại chứng từ hạch toán
    /// </summary>
    public int? VoucherType { get; set; }

    /// <summary>
    /// Số hóa đơn, số hợp đồng
    /// </summary>
    public string? InvContractNo { get; set; }

    /// <summary>
    /// Cách tính lãi
    /// </summary>
    public int CalculateInterestType { get; set; }

    /// <summary>
    /// Lãi năm tính trên 365/360 ngày
    /// </summary>
    public int InterestYearType { get; set; }

    /// <summary>
    /// Loại lãi suất
    /// </summary>
    public int InterestType { get; set; }

    /// <summary>
    /// Lãi suất
    /// </summary>
    public decimal InterestRate { get; set; }

    /// <summary>
    /// Trả gốc
    /// </summary>
    public int PayOriginalType { get; set; }

    /// <summary>
    /// Ngày trả gốc đầu tiên
    /// </summary>
    public DateTime? PayOriginalDate { get; set; }

    /// <summary>
    /// Số tiền trả mỗi kỳ
    /// </summary>
    public decimal PayOriginalAmount { get; set; }

    /// <summary>
    /// Trả lãi
    /// </summary>
    public int PayInterestType { get; set; }

    /// <summary>
    /// Ngày trả lãi đầu tiên
    /// </summary>
    public DateTime? PayInterestDate { get; set; }

    /// <summary>
    /// Phương thức trả nợ
    /// </summary>
    public int? PayMethod { get; set; }

    /// <summary>
    /// ID TK ngân hàng trả nợ
    /// </summary>
    public Guid? PayBankAccountId { get; set; }

    /// <summary>
    /// Tên TK ngân hàng trả nợ
    /// </summary>
    public string? PayBankAccountName { get; set; }

    /// <summary>
    /// Công trình
    /// </summary>
    public Guid? ProjectWorkId { get; set; }

    /// <summary>
    /// Đơn mua hàng
    /// </summary>
    public Guid? PuorderRefId { get; set; }

    /// <summary>
    /// Hợp đồng mua
    /// </summary>
    public Guid? PucontractId { get; set; }

    /// <summary>
    /// Hợp đồng bán
    /// </summary>
    public Guid? ContractId { get; set; }

    /// <summary>
    /// Đơn đặt hàng
    /// </summary>
    public Guid? SaorderId { get; set; }

    /// <summary>
    /// Mục thu chi
    /// </summary>
    public Guid? BudgetItemId { get; set; }

    /// <summary>
    /// Khoản mục chi phí
    /// </summary>
    public Guid? ExpenseItemId { get; set; }

    /// <summary>
    /// Mã thống kê
    /// </summary>
    public Guid? ListItemId { get; set; }

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
    /// Đã trả đầu kỳ
    /// </summary>
    public decimal OpeningPaidAmount { get; set; }

    /// <summary>
    /// Đã trả đầu kỳ nguyên tệ
    /// </summary>
    public decimal OpeningPaidAmountOc { get; set; }

    /// <summary>
    /// Lãi đã trả
    /// </summary>
    public decimal OpeningInterestPaidAmount { get; set; }

    /// <summary>
    /// Lãi đã trả nguyê tệ
    /// </summary>
    public decimal OpeningInterestPaidAmountOc { get; set; }

    /// <summary>
    /// Trạng thái
    /// </summary>
    public int Status { get; set; }

    public decimal OpeningPaidAmountManagement { get; set; }

    public decimal OpeningPaidAmountOcmanagement { get; set; }

    public decimal OpeningInterestPaidAmountManagement { get; set; }

    public decimal OpeningInterestPaidAmountOcmanagement { get; set; }

    public virtual AccountObject? AccountObject { get; set; }

    public virtual ICollection<BadepositDetail> BadepositDetails { get; set; } = new List<BadepositDetail>();

    public virtual ICollection<BainternalTransferDetail> BainternalTransferDetails { get; set; } = new List<BainternalTransferDetail>();

    public virtual BankAccount? BankAccount { get; set; }

    public virtual ICollection<BawithDrawDetail> BawithDrawDetails { get; set; } = new List<BawithDrawDetail>();

    public virtual BudgetItem? BudgetItem { get; set; }

    public virtual ICollection<CapaymentDetail> CapaymentDetails { get; set; } = new List<CapaymentDetail>();

    public virtual ICollection<CareceiptDetail> CareceiptDetails { get; set; } = new List<CareceiptDetail>();

    public virtual Contract? Contract { get; set; }

    public virtual Ccy? Currency { get; set; }

    public virtual Account? DebitAccountNavigation { get; set; }

    public virtual ExpenseItem? ExpenseItem { get; set; }

    public virtual ICollection<GlvoucherDetail> GlvoucherDetails { get; set; } = new List<GlvoucherDetail>();

    public virtual ICollection<IninwardDetail> IninwardDetails { get; set; } = new List<IninwardDetail>();

    public virtual ICollection<InoutwardDetail> InoutwardDetails { get; set; } = new List<InoutwardDetail>();

    public virtual ListItem? ListItem { get; set; }

    public virtual ICollection<LoanagreementAsset> LoanagreementAssets { get; set; } = new List<LoanagreementAsset>();

    public virtual ICollection<LoanagreementCalendar> LoanagreementCalendars { get; set; } = new List<LoanagreementCalendar>();

    public virtual ICollection<LoanagreementInterestRate> LoanagreementInterestRates { get; set; } = new List<LoanagreementInterestRate>();

    public virtual ICollection<LoanagreementPayment> LoanagreementPayments { get; set; } = new List<LoanagreementPayment>();

    public virtual BankAccount? PayBankAccount { get; set; }

    public virtual ProjectWork? ProjectWork { get; set; }

    public virtual Pucontract? Pucontract { get; set; }

    public virtual ICollection<PudiscountDetail> PudiscountDetails { get; set; } = new List<PudiscountDetail>();

    public virtual Puorder? PuorderRef { get; set; }

    public virtual ICollection<PureturnDetail> PureturnDetails { get; set; } = new List<PureturnDetail>();

    public virtual ICollection<PuserviceDetail> PuserviceDetails { get; set; } = new List<PuserviceDetail>();

    public virtual ICollection<PuvoucherDetail> PuvoucherDetails { get; set; } = new List<PuvoucherDetail>();

    public virtual Account? RepayAccountNavigation { get; set; }

    public virtual ICollection<SadiscountDetail> SadiscountDetails { get; set; } = new List<SadiscountDetail>();

    public virtual Saorder? Saorder { get; set; }

    public virtual ICollection<SareturnDetail> SareturnDetails { get; set; } = new List<SareturnDetail>();

    public virtual ICollection<SavoucherDetail> SavoucherDetails { get; set; } = new List<SavoucherDetail>();

    public virtual AccountObject? Vendor { get; set; }
}