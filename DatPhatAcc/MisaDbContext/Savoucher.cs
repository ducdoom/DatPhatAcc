﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng master chứng từ bán hàng
/// </summary>
public partial class Savoucher
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid BranchId { get; set; }

    /// <summary>
    /// Xác định chứng từ được ghi vào sổ nào (0=Sổ tài chinh;1=Sổ quản trị;2=Cả hai)
    /// </summary>
    public int? DisplayOnBook { get; set; }

    /// <summary>
    /// Loại chứng từ
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
    /// Trạng thái ghi sổ Sổ tài chính
    /// </summary>
    public bool IsPostedFinance { get; set; }

    /// <summary>
    /// Trạng thái ghi sổ Sổ quản trị
    /// </summary>
    public bool IsPostedManagement { get; set; }

    /// <summary>
    /// Có lập kèm hóa đơn hay không?
    /// </summary>
    public bool IncludeInvoice { get; set; }

    /// <summary>
    /// Đã xuất hóa đơn
    /// </summary>
    public bool IsInvoiceExported { get; set; }

    /// <summary>
    /// ID khách hàng
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Tên khách hàng
    /// </summary>
    public string? AccountObjectName { get; set; }

    /// <summary>
    /// Địa chỉ
    /// </summary>
    public string? AccountObjectAddress { get; set; }

    /// <summary>
    /// Người nộp (Bán hàng thu tiền ngay) / Người liên hệ (Bán hàng chưa thu tiền)
    /// </summary>
    public string? Payer { get; set; }

    /// <summary>
    /// Lý do nộp/Diễn giải
    /// </summary>
    public string? JournalMemo { get; set; }

    /// <summary>
    /// Nhà cung cấp/Đơn vị ủy thác xuất khẩu
    /// </summary>
    public Guid? SupplierId { get; set; }

    /// <summary>
    /// Tên nhà cung cấp/đơn vị ủy thác xuất khẩu
    /// </summary>
    public string? SupplierName { get; set; }

    /// <summary>
    /// Nhân viên bán hàng
    /// </summary>
    public Guid? EmployeeId { get; set; }

    /// <summary>
    /// Kèm theo chứng từ gốc
    /// </summary>
    public string? DocumentIncluded { get; set; }

    /// <summary>
    /// Đã thanh toán đủ.Với Chưa thanh toán, khi trả hết tiền thì cập nhật = 1
    /// </summary>
    public bool IsPaid { get; set; }

    /// <summary>
    /// Đã xuất hàng (0: Chưa xuất, 1: Đã xuất, 2: Để trắng &lt;đối với hóa đơn bán hàng mà tất cả  mặt hàng đều có tính chất dịchvụ&gt;)
    /// </summary>
    public int? IsOutwardExported { get; set; }

    /// <summary>
    /// Điều kiện thanh toán
    /// </summary>
    public Guid? PaymentTermId { get; set; }

    /// <summary>
    /// Số ngày được nợ
    /// </summary>
    public int? DueDay { get; set; }

    /// <summary>
    /// Hạn thanh toán
    /// </summary>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public string? CurrencyId { get; set; }

    /// <summary>
    /// Tỉ giá hối đoái
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// Tổng tiền hàng
    /// </summary>
    public decimal TotalSaleAmountOc { get; set; }

    /// <summary>
    /// Tổng tiền hàng quy đổi
    /// </summary>
    public decimal TotalSaleAmount { get; set; }

    /// <summary>
    /// Tổng tiền thanh toán
    /// </summary>
    public decimal TotalAmountOc { get; set; }

    /// <summary>
    /// Tổng tiền thanh toán quy đổi
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
    /// Tổng tiền thuế
    /// </summary>
    public decimal TotalVatamountOc { get; set; }

    /// <summary>
    /// Tổng tiền thuế quy đổi
    /// </summary>
    public decimal TotalVatamount { get; set; }

    /// <summary>
    /// Tiền thuế xuất khẩu
    /// </summary>
    public decimal TotalExportTaxAmountOc { get; set; }

    /// <summary>
    /// Tiền thuế xuất khẩu QĐ
    /// </summary>
    public decimal TotalExportTaxAmount { get; set; }

    /// <summary>
    /// Trạng thái ghi sổ thủ quỹ (Sổ tài chính)
    /// </summary>
    public bool? IsPostedCashBookFinance { get; set; }

    /// <summary>
    /// Trạng thái ghi sổ thủ quỹ (Sổ quản trị)
    /// </summary>
    public bool? IsPostedCashBookManagement { get; set; }

    /// <summary>
    /// Ngày ghi sổ thủ quỹ
    /// </summary>
    public DateTime? CashBookPostedDate { get; set; }

    /// <summary>
    /// Tình trạng đòi nợ: (0=nợ bình thường;1=Nợ khó đòi;2=Nợ không thể đòi)
    /// </summary>
    public int? DebtStatus { get; set; }

    /// <summary>
    /// Số thứ tự nhập chứng từ
    /// </summary>
    public int RefOrder { get; set; }

    /// <summary>
    /// EditVersion
    /// </summary>
    public byte[]? EditVersion { get; set; }

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

    public Guid? BankAccountId { get; set; }

    public string? BankName { get; set; }

    public decimal CabaamountOc { get; set; }

    public decimal Cabaamount { get; set; }

    public string? InvNo { get; set; }

    public DateTime? InvDate { get; set; }

    public string? InvSeries { get; set; }

    public bool IsSaleWithOutward { get; set; }

    /// <summary>
    /// Mã số thuế
    /// </summary>
    public string? AccountObjectTaxCode { get; set; }

    /// <summary>
    /// Đã xuất hóa đơn năm trước
    /// </summary>
    public bool IsInvoiceExportedLastYear { get; set; }

    public Guid? PuvoucherRefId { get; set; }

    /// <summary>
    /// Địa điểm giao hàng
    /// </summary>
    public string? ShippingAddress { get; set; }

    /// <summary>
    /// Điều khoản khác
    /// </summary>
    public string? OtherTerm { get; set; }

    public bool ExportNontariffZones { get; set; }

    public string? RefIdmshop { get; set; }

    public string? RefNoMshop { get; set; }

    public bool IsReductionInvoice { get; set; }

    public int TaxReductionType { get; set; }

    public virtual AccountObject? AccountObject { get; set; }

    public virtual BankAccount? BankAccount { get; set; }

    public virtual OrganizationUnit Branch { get; set; } = null!;

    public virtual Ccy? Currency { get; set; }

    public virtual AccountObject? Employee { get; set; }

    public virtual PaymentTerm? PaymentTerm { get; set; }

    public virtual ICollection<SadiscountDetail> SadiscountDetails { get; set; } = new List<SadiscountDetail>();

    public virtual ICollection<SaleOutwardReference> SaleOutwardReferences { get; set; } = new List<SaleOutwardReference>();

    public virtual ICollection<SareturnDetail> SareturnDetails { get; set; } = new List<SareturnDetail>();

    public virtual ICollection<SavoucherDetail> SavoucherDetails { get; set; } = new List<SavoucherDetail>();

    public virtual AccountObject? Supplier { get; set; }
}