﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Danh mục mã thống kế
/// </summary>
public partial class ListItem
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid ListItemId { get; set; }

    /// <summary>
    /// Mã thông kê
    /// </summary>
    public string ListItemCode { get; set; } = null!;

    /// <summary>
    /// Tên mã thông kê
    /// </summary>
    public string ListItemName { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public string? MisacodeId { get; set; }

    public int? Grade { get; set; }

    public bool IsParent { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    /// <summary>
    /// Cột dùng để sort trên báo cáo. Không sử dụng trên giao diện.
    /// </summary>
    public string? SortMisacodeId { get; set; }

    public virtual ICollection<BadepositDetail> BadepositDetails { get; set; } = new List<BadepositDetail>();

    public virtual ICollection<BainternalTransferDetail> BainternalTransferDetails { get; set; } = new List<BainternalTransferDetail>();

    public virtual ICollection<BawithDrawDetail> BawithDrawDetails { get; set; } = new List<BawithDrawDetail>();

    public virtual ICollection<CapaymentDetail> CapaymentDetails { get; set; } = new List<CapaymentDetail>();

    public virtual ICollection<CareceiptDetail> CareceiptDetails { get; set; } = new List<CareceiptDetail>();

    public virtual ICollection<FaadjustmentDetailPost> FaadjustmentDetailPosts { get; set; } = new List<FaadjustmentDetailPost>();

    public virtual ICollection<FadecrementDetailPost> FadecrementDetailPosts { get; set; } = new List<FadecrementDetailPost>();

    public virtual ICollection<FadepreciationDetailAllocation> FadepreciationDetailAllocations { get; set; } = new List<FadepreciationDetailAllocation>();

    public virtual ICollection<FadepreciationDetailPost> FadepreciationDetailPosts { get; set; } = new List<FadepreciationDetailPost>();

    public virtual ICollection<FixedAssetDetailAllocation> FixedAssetDetailAllocations { get; set; } = new List<FixedAssetDetailAllocation>();

    public virtual ICollection<GlvoucherDetail> GlvoucherDetails { get; set; } = new List<GlvoucherDetail>();

    public virtual ICollection<IninvoiceHubOutwardDetail> IninvoiceHubOutwardDetails { get; set; } = new List<IninvoiceHubOutwardDetail>();

    public virtual ICollection<IninvoiceHubTransferDetail> IninvoiceHubTransferDetails { get; set; } = new List<IninvoiceHubTransferDetail>();

    public virtual ICollection<IninwardDetail> IninwardDetails { get; set; } = new List<IninwardDetail>();

    public virtual ICollection<InoutwardDetail> InoutwardDetails { get; set; } = new List<InoutwardDetail>();

    public virtual ICollection<InproductionOrderDetail> InproductionOrderDetails { get; set; } = new List<InproductionOrderDetail>();

    public virtual ICollection<InproductionOrderProduct> InproductionOrderProducts { get; set; } = new List<InproductionOrderProduct>();

    public virtual ICollection<IntransferDetail> IntransferDetails { get; set; } = new List<IntransferDetail>();

    public virtual ICollection<JcacceptedDetail> JcacceptedDetails { get; set; } = new List<JcacceptedDetail>();

    public virtual ICollection<JcexpenseTranferDetail> JcexpenseTranferDetails { get; set; } = new List<JcexpenseTranferDetail>();

    public virtual ICollection<Loanagreement> Loanagreements { get; set; } = new List<Loanagreement>();

    public virtual ICollection<OpeningAccountEntryDetail> OpeningAccountEntryDetails { get; set; } = new List<OpeningAccountEntryDetail>();

    public virtual ICollection<PasalaryExpenseDetail> PasalaryExpenseDetails { get; set; } = new List<PasalaryExpenseDetail>();

    public virtual ICollection<PudiscountDetail> PudiscountDetails { get; set; } = new List<PudiscountDetail>();

    public virtual ICollection<PuinvoiceDetail> PuinvoiceDetails { get; set; } = new List<PuinvoiceDetail>();

    public virtual ICollection<PureturnDetail> PureturnDetails { get; set; } = new List<PureturnDetail>();

    public virtual ICollection<PuserviceDetail> PuserviceDetails { get; set; } = new List<PuserviceDetail>();

    public virtual ICollection<PuvoucherDetail> PuvoucherDetails { get; set; } = new List<PuvoucherDetail>();

    public virtual ICollection<SadiscountDetail> SadiscountDetails { get; set; } = new List<SadiscountDetail>();

    public virtual ICollection<SareturnDetail> SareturnDetails { get; set; } = new List<SareturnDetail>();

    public virtual ICollection<SavoucherDetail> SavoucherDetails { get; set; } = new List<SavoucherDetail>();

    public virtual ICollection<SuallocationDetailPost> SuallocationDetailPosts { get; set; } = new List<SuallocationDetailPost>();
}