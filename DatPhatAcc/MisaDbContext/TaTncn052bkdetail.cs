﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Phụ lục 052BK-TNCN
/// </summary>
public partial class TaTncn052bkdetail
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
    public string EmployeeName { get; set; }

    /// <summary>
    /// Mã số thuế
    /// </summary>
    public string EmployeeTaxCode { get; set; }

    /// <summary>
    /// Số CMTND/Hộ chiếu
    /// </summary>
    public string IdentificationNumber { get; set; }

    /// <summary>
    /// Cá nhân không cư trú
    /// </summary>
    public bool? IsNotResidencePerson { get; set; }

    /// <summary>
    /// Tổng số thu nhập chịu thuế
    /// </summary>
    public decimal TotalTaxableIncome { get; set; }

    /// <summary>
    /// TNCN làm căn cứ giảm thuế
    /// </summary>
    public decimal TaxReduceByWorkInEconmicZone { get; set; }

    /// <summary>
    /// Thuế TNCN được giảm theo Hiệp định
    /// </summary>
    public decimal TaxReduceByAgreement { get; set; }

    /// <summary>
    /// Số thuế TNCN đã khấu trừ
    /// </summary>
    public decimal TaxIncomeDeducted { get; set; }

    /// <summary>
    /// Số thuế TNCN được giảm do làm việc trong KKT
    /// </summary>
    public decimal TaxIncomeDeductedByWorkInEz { get; set; }

    /// <summary>
    /// Nhóm
    /// </summary>
    public string GroupName { get; set; }

    public virtual TadeclarationAppendix Appendix { get; set; }
}