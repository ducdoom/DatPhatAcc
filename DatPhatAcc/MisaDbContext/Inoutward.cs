﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng master xuất kho
/// </summary>
public partial class Inoutward
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Xác định chứng từ được ghi vào sổ nào (0=Sổ tài chinh;1=Sổ quản trị;2=Cả hai)
    /// </summary>
    public int DisplayOnBook { get; set; }

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
    /// Số chứng từ Sổ tài chính
    /// </summary>
    public string? RefNoFinance { get; set; }

    /// <summary>
    /// Số chứng từ Sổ quản trị
    /// </summary>
    public string? RefNoManagement { get; set; }

    /// <summary>
    /// Mẫu số HĐ
    /// </summary>
    public string? InvTemplateNo { get; set; }

    /// <summary>
    /// Ký hiệu hóa đơn
    /// </summary>
    public string? InvSeries { get; set; }

    /// <summary>
    /// Số chứng từ (Xuất hàng cho các đơn vị hạch toán phụ thuộc)
    /// </summary>
    public string? InvNo { get; set; }

    /// <summary>
    /// Trạng thái ghi sổ Sổ tài chính
    /// </summary>
    public bool IsPostedFinance { get; set; }

    /// <summary>
    /// Trạng thái ghi sổ Sổ quản trị
    /// </summary>
    public bool IsPostedManagement { get; set; }

    /// <summary>
    /// Mã đối tượng
    /// </summary>
    public Guid? AccountObjectId { get; set; }

    /// <summary>
    /// Tên đối tượng
    /// </summary>
    public string? AccountObjectName { get; set; }

    /// <summary>
    /// Địa chỉ
    /// </summary>
    public string? AccountObjectAddress { get; set; }

    /// <summary>
    /// Lệnh điều động số
    /// </summary>
    public string? OrderNo { get; set; }

    /// <summary>
    /// Ngày lệnh điều động
    /// </summary>
    public DateTime? OrderDate { get; set; }

    /// <summary>
    /// Tên người nhận/Bộ phận/Của
    /// </summary>
    public string? ContactName { get; set; }

    /// <summary>
    /// Lý do xuất/Về việc
    /// </summary>
    public string? JournalMemo { get; set; }

    /// <summary>
    /// Nhân viên
    /// </summary>
    public Guid? EmployeeId { get; set; }

    /// <summary>
    /// Tài liệu kèm theo
    /// </summary>
    public string? DocumentIncluded { get; set; }

    /// <summary>
    /// Người vận chuyển (danh mục nhân viên)
    /// </summary>
    public Guid? TransporterId { get; set; }

    /// <summary>
    /// Tên người vận chuyển
    /// </summary>
    public string? TransporterName { get; set; }

    /// <summary>
    /// Hợp đồng số
    /// </summary>
    public string? ContractCode { get; set; }

    /// <summary>
    /// Phương tiện vận chuyển
    /// </summary>
    public string? Transport { get; set; }

    /// <summary>
    /// Xuất tại kho
    /// </summary>
    public Guid? FromStockId { get; set; }

    /// <summary>
    /// Nhập tại kho
    /// </summary>
    public Guid? ToStockId { get; set; }

    /// <summary>
    /// Tổng thành tiền Sổ tài chính
    /// </summary>
    public decimal TotalAmountFinance { get; set; }

    /// <summary>
    /// ID của chi nhánh.
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Trạng thái ghi sổ thủ kho (Sổ tài chính)
    /// </summary>
    public bool? IsPostedInventoryBookFinance { get; set; }

    /// <summary>
    /// Trạng thái ghi sổ thủ kho (Sổ quản trị)
    /// </summary>
    public bool? IsPostedInventoryBookManagement { get; set; }

    /// <summary>
    /// Ngày ghi sổ kho
    /// </summary>
    public DateTime? InventoryPostedDate { get; set; }

    /// <summary>
    /// Phiên bản sửa chứng từ
    /// </summary>
    public byte[]? EditVersion { get; set; }

    /// <summary>
    /// Số thứ tự nhập chứng từ
    /// </summary>
    public int RefOrder { get; set; }

    /// <summary>
    /// Tình trạng ghi nhận doanh thu. 0 = Chưa lập; 1 = Đã lập
    /// </summary>
    public int? RevenueStatus { get; set; }

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
    /// Tổng thành tiền Sổ quản trị
    /// </summary>
    public decimal TotalAmountManagement { get; set; }

    public Guid? AssemblyRefId { get; set; }

    public DateTime InrefOrder { get; set; }

    public bool? IsBranchIssued { get; set; }

    public bool IsSaleWithOutward { get; set; }

    public string? ShippingAddress { get; set; }

    public bool IsInvoiceReplace { get; set; }

    public string? RefIdmshop { get; set; }

    public string? RefNoMshop { get; set; }

    public bool? IsGetForInvoice { get; set; }

    public Guid? OrganizationUnitId { get; set; }

    public int InvoiceSystem { get; set; }

    public string? InvoiceCode { get; set; }

    public bool IsProcessInvoiceError { get; set; }

    public string? BranchImportName { get; set; }

    public string? BranchImportMst { get; set; }

    public string? FromStockAddress { get; set; }

    public string? ToStockAddress { get; set; }

    public virtual AccountObject? AccountObject { get; set; }

    public virtual InassemblyDisassembly? AssemblyRef { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual AccountObject? Employee { get; set; }

    public virtual Stock? FromStock { get; set; }

    public virtual ICollection<Inaudit> Inaudits { get; set; } = new List<Inaudit>();

    public virtual ICollection<InoutwardDetail> InoutwardDetails { get; set; } = new List<InoutwardDetail>();

    public virtual ICollection<SaleOutwardReference> SaleOutwardReferences { get; set; } = new List<SaleOutwardReference>();

    public virtual Stock? ToStock { get; set; }

    public virtual AccountObject? Transporter { get; set; }
}