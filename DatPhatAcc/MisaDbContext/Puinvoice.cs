﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Hóa đơn nhận (Mua hàng, Mua dịch vụ, Giám giá hàng mua, Bán trả lại)
/// </summary>
public partial class Puinvoice
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Loại chứng từ
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Ngày chứng từ (Phiếu chi/Chứng từ ghi nợ)
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Ngày hạch toán (Phiếu chi/Chứng từ ghi nợ)
    /// </summary>
    public DateTime PostedDate { get; set; }

    /// <summary>
    /// Số chứng từ sổ tài chính (Phiếu chi/Chứng từ ghi nợ)
    /// </summary>
    public string? RefNoFinance { get; set; }

    /// <summary>
    /// Số chứng từ sổ quản trị (Phiếu chi/Chứng từ ghi nợ)
    /// </summary>
    public string? RefNoManagement { get; set; }

    /// <summary>
    /// Trạng thái ghi sổ Sổ tài chính
    /// </summary>
    public bool IsPostedFinance { get; set; }

    /// <summary>
    /// Trạng thái ghi sổ Sổ quản trị
    /// </summary>
    public bool IsPostedManagement { get; set; }

    /// <summary>
    /// Với loại chứng từ là Mua hàng nhập khẩu thì = 1. Còn lại = 0
    /// </summary>
    public bool IsImportPurchase { get; set; }

    /// <summary>
    /// Nhận kèm hóa đơn? (Hóa đơn này được nhận kèm chứng từ)
    /// </summary>
    public bool IncludeInvoice { get; set; }

    /// <summary>
    /// Mã nhà cung cấp/khách hàng/cán bộ
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Tên nhà cung cấp/khách hàng/cán bộ
    /// </summary>
    public string? AccountObjectName { get; set; }

    /// <summary>
    /// Địa chỉ người nhận
    /// </summary>
    public string? AccountObjectAddress { get; set; }

    /// <summary>
    /// Mã số thuế
    /// </summary>
    public string? AccountObjectTaxCode { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? JournalMemo { get; set; }

    /// <summary>
    /// Nhân viên mua hàng
    /// </summary>
    public Guid? EmployeeId { get; set; }

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
    /// Số hóa đơn
    /// </summary>
    public string? InvNo { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public string? CurrencyId { get; set; }

    /// <summary>
    /// Tỉ giá hối đoái
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// Giá trị HHDV chưa thuế
    /// </summary>
    public decimal TotalTurnoverAmountOc { get; set; }

    /// <summary>
    /// Giá trị HHDV chưa thuế QĐ
    /// </summary>
    public decimal TotalTurnoverAmount { get; set; }

    /// <summary>
    /// Tiền thuế GTGT
    /// </summary>
    public decimal TotalVatamountOc { get; set; }

    /// <summary>
    /// Tiền thuế GTGT QĐ
    /// </summary>
    public decimal TotalVatamount { get; set; }

    /// <summary>
    /// Đã thanh toán đủ
    /// </summary>
    public bool IsPaid { get; set; }

    /// <summary>
    /// Cộng gộp các mặt hàng giống nhau
    /// </summary>
    public bool IsSummaryBySameInventoryItem { get; set; }

    /// <summary>
    /// Xác định chứng từ được hiển thị trên sổ nào (0=Sổ tài chinh;1=Sổ quản trị;2=Cả hai)
    /// </summary>
    public int? DisplayOnBook { get; set; }

    /// <summary>
    /// EditVersion
    /// </summary>
    public byte[]? EditVersion { get; set; }

    /// <summary>
    /// Số thứ tự nhập chứng từ
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

    /// <summary>
    /// Hạn thanh toán
    /// </summary>
    public DateTime? DueDate { get; set; }

    public string? TransactionId { get; set; }

    public string? SellerTaxCode { get; set; }

    public int? EinvoiceType { get; set; }

    public bool IsImportEinvoice { get; set; }

    public virtual AccountObject? AccountObject { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual Ccy? Currency { get; set; }

    public virtual AccountObject? Employee { get; set; }

    public virtual ICollection<PudiscountDetail> PudiscountDetails { get; set; } = new List<PudiscountDetail>();

    public virtual ICollection<Pudiscount> Pudiscounts { get; set; } = new List<Pudiscount>();

    public virtual ICollection<PuinvoiceDetail> PuinvoiceDetails { get; set; } = new List<PuinvoiceDetail>();

    public virtual ICollection<PuvoucherDetail> PuvoucherDetails { get; set; } = new List<PuvoucherDetail>();

    public virtual ICollection<Puvoucher> Puvouchers { get; set; } = new List<Puvoucher>();

    public virtual ICollection<SareturnDetail> SareturnDetails { get; set; } = new List<SareturnDetail>();

    public virtual ICollection<Sareturn> Sareturns { get; set; } = new List<Sareturn>();
}