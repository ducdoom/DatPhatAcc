﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Phụ lục 051BK-TNCN
/// </summary>
public partial class TaTncn051bkdetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// FK - RefID của tờ khai thuế
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// ID phụ lục
    /// </summary>
    public Guid AppendixId { get; set; }

    /// <summary>
    /// Số thứ tự
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Họ và tên
    /// </summary>
    public string? EmployeeName { get; set; }

    /// <summary>
    /// Mã số thuế
    /// </summary>
    public string? EmployeeTaxCode { get; set; }

    /// <summary>
    /// Số CMTND/Hộ chiếu
    /// </summary>
    public string? IdentificationNumber { get; set; }

    /// <summary>
    /// Cá nhân ủy quyền quyết toán thay
    /// </summary>
    public bool? IsAuthorized { get; set; }

    /// <summary>
    /// Tổng số thu nhập chịu thuế
    /// </summary>
    public decimal TotalTaxableIncome { get; set; }

    /// <summary>
    /// Thuế TNCN được giảm do làm việc trong KKT
    /// </summary>
    public decimal TaxReduceByWorkInEconmicZone { get; set; }

    /// <summary>
    /// Thuế TNCN được giảm theo Hiệp định
    /// </summary>
    public decimal TaxReduceByAgreement { get; set; }

    /// <summary>
    /// Tổng số tiền giảm trừ gia cảnh
    /// </summary>
    public decimal FamilyConditionDeduction { get; set; }

    /// <summary>
    /// Giảm trừ từ thiện, nhân đạo, khuyến học
    /// </summary>
    public decimal HumanityDeduction { get; set; }

    /// <summary>
    /// Giảm trừ bảo hiểm được trừ
    /// </summary>
    public decimal ForceInsuranceDeduction { get; set; }

    /// <summary>
    /// Giảm trừ hưu trí tự nguyện
    /// </summary>
    public decimal RetireSpontaneousDeduction { get; set; }

    /// <summary>
    /// Thu nhập tính thuế
    /// </summary>
    public decimal TaxCalculationIncome { get; set; }

    /// <summary>
    /// Số thuế TNCN đã khấu trừ
    /// </summary>
    public decimal TaxIncomeDeducted { get; set; }

    /// <summary>
    /// Số thuế TNCN được giảm do làm việc trong KKT
    /// </summary>
    public decimal TaxIncomeDeductedByWorkInEz { get; set; }

    /// <summary>
    /// Số thuế TNCN phải khấu trừ
    /// </summary>
    public decimal TaxIncomeMustDeduct { get; set; }

    /// <summary>
    /// Tổng số thuế phải nộp
    /// </summary>
    public decimal TotalTaxAmount { get; set; }

    /// <summary>
    /// Số thuế đã nộp thừa
    /// </summary>
    public decimal ExtraTaxAmount { get; set; }

    /// <summary>
    /// Số thuế phải khấu trừ thêm
    /// </summary>
    public decimal TaxAmountMustDeduct { get; set; }

    /// <summary>
    /// Nhóm
    /// </summary>
    public string GroupName { get; set; } = null!;

    public virtual TadeclarationAppendix Appendix { get; set; } = null!;
}