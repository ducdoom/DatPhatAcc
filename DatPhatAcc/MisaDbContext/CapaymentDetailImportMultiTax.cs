﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class CapaymentDetailImportMultiTax
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
    /// RefID của chứng từ hàng nhập khẩu
    /// </summary>
    public Guid? VoucherRefId { get; set; }

    /// <summary>
    /// Ngày chứng từ
    /// </summary>
    public DateTime? VoucherRefDate { get; set; }

    /// <summary>
    /// Ngày hạch toán
    /// </summary>
    public DateTime? VoucherPostedDate { get; set; }

    /// <summary>
    /// Số chứng từ
    /// </summary>
    public string? VoucherRefNoFinance { get; set; }

    /// <summary>
    /// Số chứng từ sổ quản trị
    /// </summary>
    public string? VoucherRefNoManagement { get; set; }

    /// <summary>
    /// Loại chứng từ của hóa đơn gốc
    /// </summary>
    public int? VoucherRefType { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp các dòng chi tiết
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Lưu ID của chứng từ mua hàng nhập khẩu, nhằm đáp ứng nhu cầu nộp thuế cho từng dòng chi tiết
    /// </summary>
    public Guid? VoucherRefDetailId { get; set; }

    /// <summary>
    /// Số hóa đơn
    /// </summary>
    public string? InvNo { get; set; }

    /// <summary>
    /// Diễn giải của chứng từ
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Giá hàng tính thuế
    /// </summary>
    public decimal? TurnOverAmount { get; set; }

    /// <summary>
    /// Mẫu số hóa đơn
    /// </summary>
    public string? InvTemplateNo { get; set; }

    /// <summary>
    /// Ngày hóa đơn
    /// </summary>
    public DateTime? InvDate { get; set; }

    /// <summary>
    /// Ký hiệu hóa đơn
    /// </summary>
    public string? InvSeries { get; set; }

    /// <summary>
    /// ID của đối tượng (NCC)
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Tên NCC
    /// </summary>
    public string? AccountObjectName { get; set; }

    /// <summary>
    /// Địa chỉ NCC
    /// </summary>
    public string? AccountObjectAddress { get; set; }

    /// <summary>
    /// Mã số thuế
    /// </summary>
    public string? AccountObjectTaxCode { get; set; }

    /// <summary>
    /// Nhóm HHDV mua vào
    /// </summary>
    public Guid? PurchasePurposeId { get; set; }

    /// <summary>
    /// Thuế suất thuế NK
    /// </summary>
    public decimal? ImportRate { get; set; }

    /// <summary>
    /// Tiền thuế NK
    /// </summary>
    public decimal? ImportAmount { get; set; }

    /// <summary>
    /// Số phải nộp của thuế NK
    /// </summary>
    public decimal ImportPayableAmount { get; set; }

    /// <summary>
    /// Số nộp của thuế NK
    /// </summary>
    public decimal ImportPaidAmount { get; set; }

    /// <summary>
    /// Số còn phải nộp của thuế NK
    /// </summary>
    public decimal ImportRemainningAmount { get; set; }

    /// <summary>
    /// TK thuế nhập khẩu
    /// </summary>
    public string? ImportAccount { get; set; }

    /// <summary>
    /// Thuế suất tiêu thụ đặc biệt
    /// </summary>
    public decimal? SpecialRate { get; set; }

    /// <summary>
    /// Tiền thuế tiêu thụ đặc biệt
    /// </summary>
    public decimal? SpecialAmount { get; set; }

    /// <summary>
    /// Số phải nộp của thuế tiêu thụ đặc biệt
    /// </summary>
    public decimal SpecialPayableAmount { get; set; }

    /// <summary>
    /// Số nộp của thuế tiêu thụ đặc biệt
    /// </summary>
    public decimal SpecialPaidAmount { get; set; }

    /// <summary>
    /// Số còn phải nộp của thuế tiêu thụ đặc biệt
    /// </summary>
    public decimal SpecialRemainningAmount { get; set; }

    /// <summary>
    /// TK thuế tiêu thụ đặc biệt
    /// </summary>
    public string? SpecialAccount { get; set; }

    /// <summary>
    /// Thuế suất  bảo vệ môi trường
    /// </summary>
    public decimal? EnvironmentRate { get; set; }

    /// <summary>
    /// Tiền thuế  bảo vệ môi trường
    /// </summary>
    public decimal? EnvironmentAmount { get; set; }

    /// <summary>
    /// Số phải nộp của thuế  bảo vệ môi trường
    /// </summary>
    public decimal EnvironmentPayableAmount { get; set; }

    /// <summary>
    /// Số nộp của thuế  bảo vệ môi trường
    /// </summary>
    public decimal EnvironmentPaidAmount { get; set; }

    /// <summary>
    /// Số còn phải nộp của thuế  bảo vệ môi trường
    /// </summary>
    public decimal EnvironmentRemainningAmount { get; set; }

    /// <summary>
    /// TK thuế tiêu thụ đặc biệt
    /// </summary>
    public string? EnvironmentAccount { get; set; }

    /// <summary>
    /// Thuế suất  GTGT
    /// </summary>
    public decimal? Vatrate { get; set; }

    /// <summary>
    /// Tiền thuế  GTGT
    /// </summary>
    public decimal? Vatamount { get; set; }

    /// <summary>
    /// Số phải nộp của thuế  GTGT
    /// </summary>
    public decimal VatpayableAmount { get; set; }

    /// <summary>
    /// Số nộp của thuế GTGT
    /// </summary>
    public decimal VatpaidAmount { get; set; }

    /// <summary>
    /// Số còn phải nộp của thuế  GTGT
    /// </summary>
    public decimal VatremainningAmount { get; set; }

    /// <summary>
    /// TK thuế GTGT
    /// </summary>
    public string? Vataccount { get; set; }

    /// <summary>
    /// TK thuế GTGT khấu trừ
    /// </summary>
    public string? VatcorrespondingAccount { get; set; }

    /// <summary>
    /// TK đối ứng thuế GTGT
    /// </summary>
    public string? VatdeductionAccount { get; set; }

    public Guid? InvestmentProjectId { get; set; }

    public decimal AntiDumpingTaxRate { get; set; }

    public decimal AntiDumpingTaxAmount { get; set; }

    public decimal AntiDumpingTaxPayableAmount { get; set; }

    public decimal AntiDumpingTaxPaidAmount { get; set; }

    public decimal AntiDumpingTaxRemainningAmount { get; set; }

    public string? AntiDumpingTaxAccount { get; set; }

    public virtual Account? AntiDumpingTaxAccountNavigation { get; set; }

    public virtual Account? EnvironmentAccountNavigation { get; set; }

    public virtual Account? ImportAccountNavigation { get; set; }

    public virtual InvestmentProject? InvestmentProject { get; set; }

    public virtual Capayment Ref { get; set; } = null!;

    public virtual Account? SpecialAccountNavigation { get; set; }

    public virtual Account? VataccountNavigation { get; set; }

    public virtual Account? VatcorrespondingAccountNavigation { get; set; }

    public virtual Account? VatdeductionAccountNavigation { get; set; }
}