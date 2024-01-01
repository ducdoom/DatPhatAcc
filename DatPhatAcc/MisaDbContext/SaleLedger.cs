﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng Ledger bán hàng
/// </summary>
public partial class SaleLedger
{
    /// <summary>
    /// PK - Sổ bán hàng
    /// </summary>
    public int SaleLedgerId { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// RefID chứng từ gốc
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// RefDetailID chứng từ gốc
    /// </summary>
    public Guid? RefDetailId { get; set; }

    /// <summary>
    /// Loại chứng từ
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Số chứng từ Sổ tài chính
    /// </summary>
    public string? RefNo { get; set; }

    /// <summary>
    /// Ngày chứng từ
    /// </summary>
    public DateTime RefDate { get; set; }

    /// <summary>
    /// Ngày hạch toán
    /// </summary>
    public DateTime PostedDate { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public string? CurrencyId { get; set; }

    /// <summary>
    /// Tỉ giá hối đoái
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// Ngày hóa đơn tài chính
    /// </summary>
    public DateTime? InvDate { get; set; }

    /// <summary>
    /// Ký hiệu hóa đơn
    /// </summary>
    public string? InvSeries { get; set; }

    /// <summary>
    /// Số hóa đơn tài chính
    /// </summary>
    public string? InvNo { get; set; }

    /// <summary>
    /// Diễn giải master
    /// </summary>
    public string? JournalMemo { get; set; }

    /// <summary>
    /// Mã hàng
    /// </summary>
    public Guid InventoryItemId { get; set; }

    /// <summary>
    /// Diễn giải detail
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Kho vật tư
    /// </summary>
    public Guid? StockId { get; set; }

    /// <summary>
    /// TK phải thu
    /// </summary>
    public string? DebitAccount { get; set; }

    /// <summary>
    /// TK doanh thu
    /// </summary>
    public string? CreditAccount { get; set; }

    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// Đơn giá quy đổi
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Số lượng bán
    /// </summary>
    public decimal SaleQuantity { get; set; }

    /// <summary>
    /// Thành tiền bán hàng
    /// </summary>
    public decimal SaleAmountOc { get; set; }

    /// <summary>
    /// Thành tiền bán hàng quy đổi
    /// </summary>
    public decimal SaleAmount { get; set; }

    /// <summary>
    /// Tỉ lệ chiết khấu
    /// </summary>
    public decimal? DiscountRate { get; set; }

    /// <summary>
    /// Tiền chiêt khấu
    /// </summary>
    public decimal DiscountAmountOc { get; set; }

    /// <summary>
    /// Tiền chiêt khấu quy đổi
    /// </summary>
    public decimal DiscountAmount { get; set; }

    /// <summary>
    /// Tài khoản chiết khấu
    /// </summary>
    public string? DiscountAccount { get; set; }

    /// <summary>
    /// Thuế suất
    /// </summary>
    public decimal? Vatrate { get; set; }

    /// <summary>
    /// Tiền thuế nguyên tệ
    /// </summary>
    public decimal VatamountOc { get; set; }

    /// <summary>
    /// Tiền thuế quy đổi
    /// </summary>
    public decimal Vatamount { get; set; }

    /// <summary>
    /// TK thuế
    /// </summary>
    public string? Vataccount { get; set; }

    /// <summary>
    /// Tỉ lệ thuế xuất khẩu
    /// </summary>
    public decimal? ExportTaxRate { get; set; }

    /// <summary>
    /// Tiền thuế xuất khẩu nguyên tệ
    /// </summary>
    public decimal ExportTaxAmountOc { get; set; }

    /// <summary>
    /// Tiền thuế xuất khẩu
    /// </summary>
    public decimal ExportTaxAmount { get; set; }

    /// <summary>
    /// Tài khoản thuế xuất khẩu
    /// </summary>
    public string? ExportTaxAccount { get; set; }

    /// <summary>
    /// Số lượng bán trả lại
    /// </summary>
    public decimal ReturnQuantity { get; set; }

    /// <summary>
    /// Giá trị trả lại
    /// </summary>
    public decimal ReturnAmountOc { get; set; }

    /// <summary>
    /// Giá trị trả lại Quy đổi
    /// </summary>
    public decimal ReturnAmount { get; set; }

    /// <summary>
    /// Giá trị giảm giá
    /// </summary>
    public decimal ReduceAmountOc { get; set; }

    /// <summary>
    /// Giá trị giảm giá quy đổi
    /// </summary>
    public decimal ReduceAmount { get; set; }

    /// <summary>
    /// RefID của chứng từ Bán hàng
    /// </summary>
    public Guid? SavoucherRefId { get; set; }

    /// <summary>
    /// RefDetailID của chứng từ Bán hàng
    /// </summary>
    public Guid? SavoucherRefDetailId { get; set; }

    /// <summary>
    /// Ngày hết hạn
    /// </summary>
    public DateTime? ExpiryDate { get; set; }

    /// <summary>
    /// Số lô
    /// </summary>
    public string? LotNo { get; set; }

    /// <summary>
    /// Hạn bảo hành
    /// </summary>
    public string? Warranty { get; set; }

    /// <summary>
    /// Hạn thanh toán
    /// </summary>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Ngày thanh toán
    /// </summary>
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    /// 1=Là hàng khuyến mại;0=không phải là hàng khuyến mại
    /// </summary>
    public bool IsPromotion { get; set; }

    /// <summary>
    /// Đơn vị chính
    /// </summary>
    public Guid? MainUnitId { get; set; }

    /// <summary>
    /// Đơn giá theo đơn vị chính
    /// </summary>
    public decimal MainUnitPrice { get; set; }

    /// <summary>
    /// Tỷ lệ chuyển đổi ra đơn vị chính
    /// </summary>
    public decimal MainConvertRate { get; set; }

    /// <summary>
    /// Số lượng theo đơn vị chính
    /// </summary>
    public decimal MainQuantity { get; set; }

    /// <summary>
    /// Toán tử quy đổi *=nhân;/=chia
    /// </summary>
    public string? ExchangeRateOperator { get; set; }

    /// <summary>
    /// Trạng thái ghi vào vào sổ quản trị
    /// </summary>
    public bool IsPostToManagementBook { get; set; }

    /// <summary>
    /// Đối tượng
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
    /// Mã số thuế của khách hàng
    /// </summary>
    public string? CompanyTaxCode { get; set; }

    /// <summary>
    /// Nhân viên
    /// </summary>
    public Guid? EmployeeId { get; set; }

    /// <summary>
    /// ID đơn hàng
    /// </summary>
    public Guid? OrderId { get; set; }

    /// <summary>
    /// Đối tượng THCP
    /// </summary>
    public Guid? JobId { get; set; }

    /// <summary>
    /// Hợp đồng
    /// </summary>
    public Guid? ContractId { get; set; }

    /// <summary>
    /// Mã thống kê
    /// </summary>
    public Guid? ListItemId { get; set; }

    /// <summary>
    /// ID Đơn vị
    /// </summary>
    public Guid? OrganizationUnitId { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp các dòng chi tiết
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Thứ tự các chứng từ nhập trước, nhập sau
    /// </summary>
    public int? RefOrder { get; set; }

    /// <summary>
    /// Mã vật tư, hàng hóa
    /// </summary>
    public string? InventoryItemCode { get; set; }

    /// <summary>
    /// Tên vật tư, hàng hóa
    /// </summary>
    public string? InventoryItemName { get; set; }

    /// <summary>
    /// Mã kho
    /// </summary>
    public string? StockCode { get; set; }

    /// <summary>
    /// Tên kho
    /// </summary>
    public string? StockName { get; set; }

    /// <summary>
    /// Mã đối tượng
    /// </summary>
    public string? AccountObjectCode { get; set; }

    /// <summary>
    /// Mã nhân viên
    /// </summary>
    public string? EmployeeCode { get; set; }

    /// <summary>
    /// Tên nhân viên
    /// </summary>
    public string? EmployeeName { get; set; }

    /// <summary>
    /// Công trình/Dự án
    /// </summary>
    public Guid? ProjectWorkId { get; set; }

    /// <summary>
    /// Mã hợp đồng
    /// </summary>
    public string? ContractCode { get; set; }

    /// <summary>
    /// Tên hợp đồng
    /// </summary>
    public string? ContractName { get; set; }

    /// <summary>
    /// ID Điều khoản chiết khấu, dùng cho mua hàng, bán hàng
    /// </summary>
    public Guid? PaymentTermId { get; set; }

    /// <summary>
    /// Mã điều khoản chiết khấu
    /// </summary>
    public string? PaymentTermCode { get; set; }

    /// <summary>
    /// Tên điều khoản chiết khấu
    /// </summary>
    public string? PaymentTermName { get; set; }

    /// <summary>
    /// Có cần cập nhật dữ liệu từ các bảng dư thừa sang không, 0: không, 1: có. Sau khi cập nhật xong thì thiết lập thông tin này về =0
    /// </summary>
    public bool? IsUpdateRedundant { get; set; }

    /// <summary>
    /// Tên đối tượng (lấy từ danh mục)
    /// </summary>
    public string? AccountObjectNameDi { get; set; }

    public string? RefTypeName { get; set; }

    public decimal ReturnMainQuantity { get; set; }

    public Guid? InvRefId { get; set; }

    public decimal ReceiptAmountOc { get; set; }

    public decimal ReceiptAmount { get; set; }

    public decimal UnitPriceOc { get; set; }

    public decimal MainUnitPriceOc { get; set; }

    public string? InvTemplateNo { get; set; }

    public decimal? VatrateOther { get; set; }
}