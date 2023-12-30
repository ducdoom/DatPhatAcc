﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng master của chứng từ thu tiền gửi
/// Là Master của các bảng detail sau:
///  -BADepositeDetail
///  -BADepositeDetailSale
///  -BADepositeDetailFixedAsset
/// </summary>
public partial class Badeposit
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Loại chứng từ (Lấy từ bảng RefType)
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Ngày chứng từ
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Ngày hạch toán
    /// </summary>
    public DateTime PostedDate { get; set; }

    /// <summary>
    /// Số chứng từ sổ tài chính
    /// </summary>
    public string? RefNoFinance { get; set; }

    /// <summary>
    /// Số chứng từ sổ quản trị
    /// </summary>
    public string? RefNoManagement { get; set; }

    /// <summary>
    /// Trạng thái (Ghi sổ/Chưa ghi sổ)
    /// </summary>
    public bool IsPostedFinance { get; set; }

    /// <summary>
    /// Trạng thái ghi vào sổ quản trị
    /// </summary>
    public bool IsPostedManagement { get; set; }

    /// <summary>
    /// Mã người nộp tiền
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Tên người nộp tiền/Kho bạc
    /// </summary>
    public string? AccountObjectName { get; set; }

    /// <summary>
    /// Địa chỉ người nộp tiền
    /// </summary>
    public string? AccountObjectAddress { get; set; }

    /// <summary>
    /// Tài khoản ngân hàng
    /// </summary>
    public Guid? BankAccountId { get; set; }

    /// <summary>
    /// Tên ngân hàng
    /// </summary>
    public string? BankName { get; set; }

    /// <summary>
    /// Lý do thu
    /// </summary>
    public int? ReasonTypeId { get; set; }

    /// <summary>
    /// Diễn giải Lý do thu
    /// </summary>
    public string? JournalMemo { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public string? CurrencyId { get; set; }

    /// <summary>
    /// Tỷ giá hối đoái
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// Tổng tiền hàng
    /// </summary>
    public decimal TotalAmountOc { get; set; }

    /// <summary>
    /// Tổng tiền hàng quy đổi
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Nhân viên
    /// </summary>
    public Guid? EmployeeId { get; set; }

    /// <summary>
    /// Mã chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Xác định chứng từ được ghi vào sổ nào (0=Sổ tài chinh;1=Sổ quản trị;2=Cả hai)
    /// </summary>
    public int? DisplayOnBook { get; set; }

    /// <summary>
    /// Phiên bản sửa chứng từ
    /// </summary>
    public byte[]? EditVersion { get; set; }

    /// <summary>
    /// Số thứ tự chứng từ nhập vào database
    /// </summary>
    public int RefOrder { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

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

    public bool? IsCreateFromEbhistory { get; set; }

    public string? RefNoMshop { get; set; }

    public string? RefIdmshop { get; set; }

    public Guid? GlvoucherRefId { get; set; }

    public virtual AccountObject? AccountObject { get; set; }

    public virtual ICollection<BadepositDetail> BadepositDetails { get; set; } = new List<BadepositDetail>();

    public virtual BankAccount? BankAccount { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual Ccy? Currency { get; set; }

    public virtual AccountObject? Employee { get; set; }
}