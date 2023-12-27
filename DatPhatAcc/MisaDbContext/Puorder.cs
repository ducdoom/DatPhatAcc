﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Đơn mua hàng
/// </summary>
public partial class Puorder
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Mã chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Ngày đơn hàng
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Loại chứng từ (lấy từ bảng RefType)
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Số đơn hàng
    /// </summary>
    public string RefNo { get; set; }

    /// <summary>
    /// Tình trạng đơn hàng: 0: Chưa gửi; 1: Đã gửi; 2: Đang thực hiện; 3: Hoàn thành 4: Đã hủy bỏ
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// Mã nhà cung cấp/khách hàng/cán bộ
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Tên nhà cung cấp/khách hàng/cán bộ
    /// </summary>
    public string AccountObjectName { get; set; }

    /// <summary>
    /// Địa chỉ NCC
    /// </summary>
    public string AccountObjectAddress { get; set; }

    /// <summary>
    /// Mã số thuế NCC
    /// </summary>
    public string AccountObjectTaxCode { get; set; }

    /// <summary>
    /// Diễn giải/Lý do
    /// </summary>
    public string JournalMemo { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public string CurrencyId { get; set; }

    /// <summary>
    /// Tỉ giá hối đoái
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// Ngày nhận hàng
    /// </summary>
    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// Địa chỉ nhận hàng
    /// </summary>
    public string ReceiveAddress { get; set; }

    /// <summary>
    /// Điều khoản thanh toán
    /// </summary>
    public Guid? PaymentTermId { get; set; }

    /// <summary>
    /// Số ngày được nợ
    /// </summary>
    public int? DueDay { get; set; }

    /// <summary>
    /// Điều khoản khác
    /// </summary>
    public string OtherTerm { get; set; }

    /// <summary>
    /// Nhân viên
    /// </summary>
    public Guid? EmployeeId { get; set; }

    /// <summary>
    /// Tổng tiền
    /// </summary>
    public decimal TotalAmountOc { get; set; }

    /// <summary>
    /// Tổng tiền quy đổi
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Tổng tiền thuế
    /// </summary>
    public decimal TotalVatamountOc { get; set; }

    /// <summary>
    /// Tổng tiền thuế Quy đổi
    /// </summary>
    public decimal TotalVatamount { get; set; }

    /// <summary>
    /// Tổng tiền chiết khấu
    /// </summary>
    public decimal TotalDiscountAmountOc { get; set; }

    /// <summary>
    /// Tổng tiền chiết khấu quy đổi
    /// </summary>
    public decimal TotalDiscountAmount { get; set; }

    public byte[] EditVersion { get; set; }

    /// <summary>
    /// Số thứ tự nhập chứng từ
    /// </summary>
    public int RefOrder { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string ModifiedBy { get; set; }

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

    public string RefIdmshop { get; set; }

    public string RefNoMshop { get; set; }

    public virtual AccountObject AccountObject { get; set; }

    public virtual ICollection<BadepositDetail> BadepositDetails { get; set; } = new List<BadepositDetail>();

    public virtual ICollection<BainternalTransferDetail> BainternalTransferDetails { get; set; } = new List<BainternalTransferDetail>();

    public virtual ICollection<BawithDrawDetail> BawithDrawDetails { get; set; } = new List<BawithDrawDetail>();

    public virtual OrganizationUnit Branch { get; set; }

    public virtual ICollection<CapaymentDetail> CapaymentDetails { get; set; } = new List<CapaymentDetail>();

    public virtual ICollection<CareceiptDetail> CareceiptDetails { get; set; } = new List<CareceiptDetail>();

    public virtual Ccy Currency { get; set; }

    public virtual AccountObject Employee { get; set; }

    public virtual ICollection<GlvoucherDetail> GlvoucherDetails { get; set; } = new List<GlvoucherDetail>();

    public virtual ICollection<Loanagreement> Loanagreements { get; set; } = new List<Loanagreement>();

    public virtual ICollection<OpeningAccountEntryDetail> OpeningAccountEntryDetails { get; set; } = new List<OpeningAccountEntryDetail>();

    public virtual ICollection<PudiscountDetail> PudiscountDetails { get; set; } = new List<PudiscountDetail>();

    public virtual ICollection<PuinvoiceDetail> PuinvoiceDetails { get; set; } = new List<PuinvoiceDetail>();

    public virtual ICollection<PuorderDetail> PuorderDetails { get; set; } = new List<PuorderDetail>();

    public virtual ICollection<PureturnDetail> PureturnDetails { get; set; } = new List<PureturnDetail>();

    public virtual ICollection<PuserviceDetail> PuserviceDetails { get; set; } = new List<PuserviceDetail>();

    public virtual ICollection<PuvoucherDetail> PuvoucherDetails { get; set; } = new List<PuvoucherDetail>();
}