﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class PavoucherDeduction
{
    /// <summary>
    /// ID chứng từ
    /// </summary>
    public Guid RefId { get; set; }

    public Guid BranchId { get; set; }

    public string CompanyTaxCode { get; set; }

    /// <summary>
    /// Loại chứng từ
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Ngày chứng từ
    /// </summary>
    public DateTime RefDate { get; set; }

    public string TemplateNo { get; set; }

    public string Series { get; set; }

    public string RefNo { get; set; }

    /// <summary>
    /// ID người lập chứng từ
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Tên người nộp thuế
    /// </summary>
    public string EmployeeName { get; set; }

    /// <summary>
    /// Loại người nộp thuế: 1. Nhân viên, 2. Vãng lai
    /// </summary>
    public int EmployeeType { get; set; }

    /// <summary>
    /// Mã nhân viên
    /// </summary>
    public Guid? EmployeeId { get; set; }

    /// <summary>
    /// Mã số thuế người nộp thuế
    /// </summary>
    public string EmployeeTaxNo { get; set; }

    /// <summary>
    /// Quốc tịch
    /// </summary>
    public string NationalName { get; set; }

    /// <summary>
    /// Có phải cá nhân cư trú không: 1. Cư trú, 0. Không cư trú, mặc định là 1
    /// </summary>
    public bool? IsResident { get; set; }

    /// <summary>
    /// SĐT của người nộp thuế
    /// </summary>
    public string EmployeeMobile { get; set; }

    /// <summary>
    /// Địa chỉ người nộp thuế
    /// </summary>
    public string EmployeeAddress { get; set; }

    /// <summary>
    /// Tên loại giấy tờ: 3 loại: CMND, CCCD, Hộ chiếu
    /// </summary>
    public string IdentifyTypeName { get; set; }

    /// <summary>
    /// Số giấy tờ: Số CMND/CCCD/Hộ chiếu
    /// </summary>
    public string IdentifyNumber { get; set; }

    /// <summary>
    /// Ngày cấp
    /// </summary>
    public DateOnly? IdentifyDate { get; set; }

    /// <summary>
    /// Mã nơi cấp
    /// </summary>
    public string IdentifyIssuedPlaceCode { get; set; }

    /// <summary>
    /// Tên nơi cấp
    /// </summary>
    public string IdentifyIssuedPlaceName { get; set; }

    /// <summary>
    /// Tháng bắt đầu chi trả thu nhập
    /// </summary>
    public int StartMonth { get; set; }

    /// <summary>
    /// Tháng kết thúc chi trả thu nhập
    /// </summary>
    public int EndMonth { get; set; }

    /// <summary>
    /// Năm chi trả thu nhập
    /// </summary>
    public int IncomeYear { get; set; }

    public string IncomeDateName { get; set; }

    /// <summary>
    /// Khoản thu nhập
    /// </summary>
    public string IncomeTypeName { get; set; }

    /// <summary>
    /// Tổng thu nhập chịu thuế phải khấu trừ
    /// </summary>
    public decimal TotalTaxIncome { get; set; }

    /// <summary>
    /// Tổng thu nhập tính thuế
    /// </summary>
    public decimal IncomeForCalculateTax { get; set; }

    /// <summary>
    /// Số thuế thu nhập cá nhân đã khấu trừ
    /// </summary>
    public decimal PersonalIncomeTax { get; set; }

    /// <summary>
    /// Khoản đóng bảo hiểm bắt buộc
    /// </summary>
    public decimal InsuranceCompulsoryPayment { get; set; }

    /// <summary>
    /// Trạng thái chứng từ
    /// </summary>
    public int VoucherStatus { get; set; }

    /// <summary>
    /// Tên trạng thái chứng từ
    /// </summary>
    public string VoucherStatusName { get; set; }

    /// <summary>
    /// Trạng thái gửi người nộp thuế
    /// </summary>
    public int SentEmployeeStatus { get; set; }

    /// <summary>
    /// Trạng thái gửi người nộp thuế
    /// </summary>
    public string SentEmployeeStatusName { get; set; }

    /// <summary>
    /// Ngày hủy
    /// </summary>
    public DateTime? CancelDate { get; set; }

    /// <summary>
    /// Lý do hủy
    /// </summary>
    public string CancelReason { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; }

    public string ModifiedBy { get; set; }

    public byte[] EditVersion { get; set; }

    public int? TaxHoldingConfigId { get; set; }

    public Guid? TransactionId { get; set; }

    public Guid? OrganizationId { get; set; }

    public int? TaxHoldingConfigType { get; set; }

    public string ReceiverName { get; set; }

    public string ReceiverEmail { get; set; }

    public string Ccemail { get; set; }

    public string Bccemail { get; set; }

    public string CreatorEmail { get; set; }

    public string CreatorName { get; set; }

    public string CreatorJobName { get; set; }

    public string CreatorPhone { get; set; }

    public virtual OrganizationUnit Branch { get; set; }

    public virtual AccountObject Employee { get; set; }
}