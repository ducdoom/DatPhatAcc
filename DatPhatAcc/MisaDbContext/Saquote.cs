﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng báo giá
/// </summary>
public partial class Saquote
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Số báo giá
    /// </summary>
    public string RefNo { get; set; } = null!;

    /// <summary>
    /// Ngày báo giá
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Ngày hiệu lực
    /// </summary>
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    /// Loại chứng từ
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// ID khách hàng là tổ chức hoặc cá nhân
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Tên khách hàng
    /// </summary>
    public string? AccountObjectName { get; set; }

    /// <summary>
    /// Địa chỉ khách hàng
    /// </summary>
    public string? AccountObjectAddress { get; set; }

    /// <summary>
    /// Mã số thuế
    /// </summary>
    public string? AccountObjectTaxCode { get; set; }

    /// <summary>
    /// Người liên hệ
    /// </summary>
    public string? AccountObjectContactName { get; set; }

    /// <summary>
    /// Ghi chú
    /// </summary>
    public string? JournalMemo { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public string? CurrencyId { get; set; }

    /// <summary>
    /// Tỉ giá hối đoái
    /// </summary>
    public decimal ExchangeRate { get; set; }

    /// <summary>
    /// Tổng tiền hàng
    /// </summary>
    public decimal TotalAmountOc { get; set; }

    /// <summary>
    /// Tổng tiền hàng quy đổi
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Tổng tiền chiết khấu
    /// </summary>
    public decimal TotalDiscountAmountOc { get; set; }

    /// <summary>
    /// Tổng tiền chiết khấu quy đổi
    /// </summary>
    public decimal TotalDiscountAmount { get; set; }

    /// <summary>
    /// Tổng tiền thuế GTGT
    /// </summary>
    public decimal TotalVatamountOc { get; set; }

    /// <summary>
    /// Tổng tiền thuế GTGT quy đổi
    /// </summary>
    public decimal TotalVatamount { get; set; }

    /// <summary>
    /// EditVersion
    /// </summary>
    public byte[]? EditVersion { get; set; }

    /// <summary>
    /// Ngày sửa
    /// </summary>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Người tạo
    /// </summary>
    public string? CreatedBy { get; set; }

    /// <summary>
    /// Ngày tạo
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Người sửa
    /// </summary>
    public string? ModifiedBy { get; set; }

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

    public Guid? EmployeeId { get; set; }

    public virtual AccountObject? AccountObject { get; set; }

    public virtual Ccy? Currency { get; set; }

    public virtual ICollection<Saorder> Saorders { get; set; } = new List<Saorder>();

    public virtual ICollection<SaquoteDetail> SaquoteDetails { get; set; } = new List<SaquoteDetail>();
}