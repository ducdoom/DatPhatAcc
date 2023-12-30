﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Danh mục Vật tư hàng hóa
/// </summary>
public partial class InventoryItem
{
    /// <summary>
    /// PK Vật tư
    /// </summary>
    public Guid InventoryItemId { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// Mã vạch (dùng máy đọc mã vạch gí vào phát lên ngay). Khi mua, bán hàng, lại gí vào tự động tìm ra VTHH đó.
    /// </summary>
    public string? BarCode { get; set; }

    /// <summary>
    /// Mã vật tư, hàng hóa
    /// </summary>
    public string InventoryItemCode { get; set; } = null!;

    /// <summary>
    /// Tên vật tư, hàng hóa
    /// </summary>
    public string? InventoryItemName { get; set; }

    /// <summary>
    /// Tính chất:0 Là Vật tư hàng hóa; 1: Là thành phẩm; 2 Là dịch vụ;3 Chỉ là diễn giải
    /// </summary>
    public int? InventoryItemType { get; set; }

    /// <summary>
    /// Lưu MISACodeID của các nhóm VTHH, phân tách nhau bởi dấu ;
    /// </summary>
    public string? InventoryItemCategoryList { get; set; }

    /// <summary>
    /// Lưu Mã của các nhóm VTHH, phân tách nhau bởi dấu ;
    /// </summary>
    public string? InventoryItemCategoryCode { get; set; }

    /// <summary>
    /// Mô tả thêm thông tin hàng hóa, quy cách
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Đơn vị tính chính
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// Thời hạn bảo hành
    /// </summary>
    public string? GuarantyPeriod { get; set; }

    /// <summary>
    /// Số lượng tồn tối thiểu
    /// </summary>
    public decimal MinimumStock { get; set; }

    /// <summary>
    /// Nguồn gốc hàng hóa
    /// </summary>
    public string? InventoryItemSource { get; set; }

    /// <summary>
    /// Kho ngầm định
    /// </summary>
    public Guid? DefaultStockId { get; set; }

    /// <summary>
    /// Tài khoản kho
    /// </summary>
    public string? InventoryAccount { get; set; }

    /// <summary>
    /// Tài khoản chi phí
    /// </summary>
    public string? Cogsaccount { get; set; }

    /// <summary>
    /// Tài khoản doanh thu
    /// </summary>
    public string? SaleAccount { get; set; }

    /// <summary>
    /// Tỷ lệ chiết khấu khi mua hàng
    /// </summary>
    public decimal PurchaseDiscountRate { get; set; }

    /// <summary>
    /// Đơn giá mua
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Đơn giá bán 1
    /// </summary>
    public decimal SalePrice1 { get; set; }

    /// <summary>
    /// Đơn giá bán 2
    /// </summary>
    public decimal SalePrice2 { get; set; }

    /// <summary>
    /// Đơn giá bán 3
    /// </summary>
    public decimal SalePrice3 { get; set; }

    /// <summary>
    /// Giá bán cố định
    /// </summary>
    public decimal FixedSalePrice { get; set; }

    /// <summary>
    /// Là đơn giá sau thuế
    /// </summary>
    public bool IsUnitPriceAfterTax { get; set; }

    /// <summary>
    /// Thuế suất GTGT: 0=0%;5=5%;10=10%;-1=KCT
    /// </summary>
    public decimal? TaxRate { get; set; }

    /// <summary>
    /// Thuế nhập khẩu
    /// </summary>
    public decimal? ImportTaxRate { get; set; }

    /// <summary>
    /// Thuế xuất khẩu
    /// </summary>
    public decimal? ExportTaxRate { get; set; }

    /// <summary>
    /// Nhóm HHDV chịu thuế tiêu thu đặc biệt
    /// </summary>
    public Guid? InventoryCategorySpecialTaxId { get; set; }

    /// <summary>
    /// Là hệ thống
    /// </summary>
    public bool IsSystem { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }

    /// <summary>
    /// Có chiết khấu hay ko? (Nếu giá trị được = True thì khi bán hàng lấy % chiết khấu hoặc số tiền chiết khấu từ danh mục lên cột chiết khấu trên hóa đơn bán hàng)
    /// </summary>
    public bool? IsSaleDiscount { get; set; }

    /// <summary>
    /// Loại chiết khấu (0= % chiết khấu;1= Số tiền chiết khấu, ; 2= Số tiền CK/1 đơn vị SL)
    /// </summary>
    public int? DiscountType { get; set; }

    /// <summary>
    /// Theo dõi theo mã quy cách
    /// </summary>
    public bool? IsFollowSerialNumber { get; set; }

    /// <summary>
    /// Phương pháp tính giá (vẫn để pp tính giá trong danh mục này vì thỉnh thoảng vẫn có KH muốn mỗi VTHH tính theo 1 pp  khác nhau)
    /// </summary>
    public int? CostMethod { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? InventoryItemCategoryName { get; set; }

    public string? Specificity { get; set; }

    /// <summary>
    /// Diễn giải khi mua
    /// </summary>
    public string? PurchaseDescription { get; set; }

    /// <summary>
    /// Diễn giải khi bán
    /// </summary>
    public string? SaleDescription { get; set; }

    public int? TacareerGroupId { get; set; }

    /// <summary>
    /// Hình ảnh
    /// </summary>
    public byte[]? Image { get; set; }

    /// <summary>
    /// Đơn giá mua cố định
    /// </summary>
    public decimal FixedUnitPrice { get; set; }

    /// <summary>
    /// Công thức tính số lượng trên chứng từ bán hàng do NSD nhập
    /// </summary>
    public string? FrontEndFormula { get; set; }

    /// <summary>
    /// Công thức tính số lượng trên chứng từ bán hàng chuyển từ công thức NSD ra để dùng tính toán trên chứng từ bán hàng
    /// </summary>
    public string? BackEndFormula { get; set; }

    /// <summary>
    /// Lưu Value của Enum Dựa trên cách tính khi thiết lập công thức tính số lượng. Cho phép NSD không nhập liệu
    /// </summary>
    public int? BaseOnFormula { get; set; }

    public string? DiscountAccount { get; set; }

    public string? SaleOffAccount { get; set; }

    public string? ReturnAccount { get; set; }

    public string Vat43type { get; set; } = null!;

    public bool IsPromotion { get; set; }

    public virtual InventoryQuantityFormulaTemplate? BaseOnFormulaNavigation { get; set; }

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual Account? CogsaccountNavigation { get; set; }

    public virtual ICollection<ContractDetailInventoryItem> ContractDetailInventoryItems { get; set; } = new List<ContractDetailInventoryItem>();

    public virtual ICollection<ContractDetailRevenue> ContractDetailRevenues { get; set; } = new List<ContractDetailRevenue>();

    public virtual Stock? DefaultStock { get; set; }

    public virtual Account? DiscountAccountNavigation { get; set; }

    public virtual ICollection<InassemblyDisassembly> InassemblyDisassemblies { get; set; } = new List<InassemblyDisassembly>();

    public virtual ICollection<InassemblyDisassemblyDetail> InassemblyDisassemblyDetails { get; set; } = new List<InassemblyDisassemblyDetail>();

    public virtual ICollection<InauditDetail> InauditDetails { get; set; } = new List<InauditDetail>();

    public virtual ICollection<IninventoryBookDetail> IninventoryBookDetails { get; set; } = new List<IninventoryBookDetail>();

    public virtual ICollection<IninvoiceHubOutwardDetail> IninvoiceHubOutwardDetails { get; set; } = new List<IninvoiceHubOutwardDetail>();

    public virtual ICollection<IninvoiceHubTransferDetail> IninvoiceHubTransferDetails { get; set; } = new List<IninvoiceHubTransferDetail>();

    public virtual ICollection<IninwardDetail> IninwardDetails { get; set; } = new List<IninwardDetail>();

    public virtual ICollection<InoutwardDetail> InoutwardDetails { get; set; } = new List<InoutwardDetail>();

    public virtual ICollection<InproductionOrderDetail> InproductionOrderDetails { get; set; } = new List<InproductionOrderDetail>();

    public virtual ICollection<InproductionOrderProduct> InproductionOrderProducts { get; set; } = new List<InproductionOrderProduct>();

    public virtual ICollection<IntransferDetail> IntransferDetails { get; set; } = new List<IntransferDetail>();

    public virtual Account? InventoryAccountNavigation { get; set; }

    public virtual InventoryItemCategorySpecialTax? InventoryCategorySpecialTax { get; set; }

    public virtual ICollection<InventoryItemDetailDiscount> InventoryItemDetailDiscounts { get; set; } = new List<InventoryItemDetailDiscount>();

    public virtual ICollection<InventoryItemDetailNorm> InventoryItemDetailNorms { get; set; } = new List<InventoryItemDetailNorm>();

    public virtual ICollection<InventoryItemDetailSerialType> InventoryItemDetailSerialTypes { get; set; } = new List<InventoryItemDetailSerialType>();

    public virtual ICollection<InventoryItemPurchaseFixedUnitPrice> InventoryItemPurchaseFixedUnitPrices { get; set; } = new List<InventoryItemPurchaseFixedUnitPrice>();

    public virtual ICollection<InventoryItemPurchaseUnitPrice> InventoryItemPurchaseUnitPrices { get; set; } = new List<InventoryItemPurchaseUnitPrice>();

    public virtual ICollection<InventoryItemUnitConvert> InventoryItemUnitConverts { get; set; } = new List<InventoryItemUnitConvert>();

    public virtual ICollection<JcproductCostAllocationConfig> JcproductCostAllocationConfigs { get; set; } = new List<JcproductCostAllocationConfig>();

    public virtual ICollection<JcproductCostDetail> JcproductCostDetails { get; set; } = new List<JcproductCostDetail>();

    public virtual JcproductQuantum? JcproductQuantum { get; set; }

    public virtual ICollection<JcuncompleteDetailInventoryItem> JcuncompleteDetailInventoryItems { get; set; } = new List<JcuncompleteDetailInventoryItem>();

    public virtual ICollection<JobProduct> JobProducts { get; set; } = new List<JobProduct>();

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

    public virtual ICollection<OpeningInventoryEntry> OpeningInventoryEntries { get; set; } = new List<OpeningInventoryEntry>();

    public virtual ICollection<ProjectWorkNormDetail> ProjectWorkNormDetails { get; set; } = new List<ProjectWorkNormDetail>();

    public virtual ICollection<PucontractDetailInventoryItem> PucontractDetailInventoryItems { get; set; } = new List<PucontractDetailInventoryItem>();

    public virtual ICollection<PudiscountDetail> PudiscountDetails { get; set; } = new List<PudiscountDetail>();

    public virtual ICollection<PuinvoiceDetail> PuinvoiceDetails { get; set; } = new List<PuinvoiceDetail>();

    public virtual ICollection<PulastedUnitPrice> PulastedUnitPrices { get; set; } = new List<PulastedUnitPrice>();

    public virtual ICollection<PuorderDetail> PuorderDetails { get; set; } = new List<PuorderDetail>();

    public virtual ICollection<PureturnDetail> PureturnDetails { get; set; } = new List<PureturnDetail>();

    public virtual ICollection<PuserviceDetail> PuserviceDetails { get; set; } = new List<PuserviceDetail>();

    public virtual ICollection<PuvoucherDetail> PuvoucherDetails { get; set; } = new List<PuvoucherDetail>();

    public virtual Account? ReturnAccountNavigation { get; set; }

    public virtual ICollection<SadiscountDetail> SadiscountDetails { get; set; } = new List<SadiscountDetail>();

    public virtual ICollection<SainvoiceDetail> SainvoiceDetails { get; set; } = new List<SainvoiceDetail>();

    public virtual ICollection<SainvoiceHubDetail> SainvoiceHubDetails { get; set; } = new List<SainvoiceHubDetail>();

    public virtual ICollection<SainvoicePetroleumDetail> SainvoicePetroleumDetails { get; set; } = new List<SainvoicePetroleumDetail>();

    public virtual Account? SaleAccountNavigation { get; set; }

    public virtual Account? SaleOffAccountNavigation { get; set; }

    public virtual ICollection<SaorderDetail> SaorderDetails { get; set; } = new List<SaorderDetail>();

    public virtual ICollection<SapolicyPrice> SapolicyPrices { get; set; } = new List<SapolicyPrice>();

    public virtual ICollection<SaquoteDetail> SaquoteDetails { get; set; } = new List<SaquoteDetail>();

    public virtual ICollection<SareturnDetail> SareturnDetails { get; set; } = new List<SareturnDetail>();

    public virtual ICollection<SavoucherDetail> SavoucherDetails { get; set; } = new List<SavoucherDetail>();

    public virtual Unit? Unit { get; set; }
}