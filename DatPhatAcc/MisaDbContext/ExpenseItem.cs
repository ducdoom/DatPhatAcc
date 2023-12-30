﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng danh mục khoản mục chi phí
/// </summary>
public partial class ExpenseItem
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid ExpenseItemId { get; set; }

    /// <summary>
    /// Mã khoản mục chi phí
    /// </summary>
    public string ExpenseItemCode { get; set; } = null!;

    /// <summary>
    /// Tên khoản mục chi phí
    /// </summary>
    public string ExpenseItemName { get; set; } = null!;

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// ID khoản mục chi phí cha
    /// </summary>
    public Guid? ParentId { get; set; }

    public string? MisacodeId { get; set; }

    public int? Grade { get; set; }

    public bool IsParent { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }

    /// <summary>
    /// Thuộc hệ thống
    /// </summary>
    public bool IsSystem { get; set; }

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

    public virtual ICollection<ContractDetailExpense> ContractDetailExpenses { get; set; } = new List<ContractDetailExpense>();

    public virtual ICollection<FaadjustmentDetailPost> FaadjustmentDetailPosts { get; set; } = new List<FaadjustmentDetailPost>();

    public virtual ICollection<FadecrementDetailPost> FadecrementDetailPosts { get; set; } = new List<FadecrementDetailPost>();

    public virtual ICollection<FadepreciationDetailAllocation> FadepreciationDetailAllocations { get; set; } = new List<FadepreciationDetailAllocation>();

    public virtual ICollection<FadepreciationDetailPost> FadepreciationDetailPosts { get; set; } = new List<FadepreciationDetailPost>();

    public virtual ICollection<FatransferDetail> FatransferDetails { get; set; } = new List<FatransferDetail>();

    public virtual ICollection<FixedAssetDetailAllocation> FixedAssetDetailAllocations { get; set; } = new List<FixedAssetDetailAllocation>();

    public virtual ICollection<GlvoucherDetailExpensesAllocation> GlvoucherDetailExpensesAllocations { get; set; } = new List<GlvoucherDetailExpensesAllocation>();

    public virtual ICollection<GlvoucherDetail> GlvoucherDetails { get; set; } = new List<GlvoucherDetail>();

    public virtual ICollection<IninvoiceHubOutwardDetail> IninvoiceHubOutwardDetails { get; set; } = new List<IninvoiceHubOutwardDetail>();

    public virtual ICollection<IninvoiceHubTransferDetail> IninvoiceHubTransferDetails { get; set; } = new List<IninvoiceHubTransferDetail>();

    public virtual ICollection<IninwardDetail> IninwardDetails { get; set; } = new List<IninwardDetail>();

    public virtual ICollection<InoutwardDetail> InoutwardDetails { get; set; } = new List<InoutwardDetail>();

    public virtual ICollection<InproductionOrderDetail> InproductionOrderDetails { get; set; } = new List<InproductionOrderDetail>();

    public virtual ICollection<IntransferDetail> IntransferDetails { get; set; } = new List<IntransferDetail>();

    public virtual ICollection<JcacceptedDetail> JcacceptedDetails { get; set; } = new List<JcacceptedDetail>();

    public virtual ICollection<JcallocationExpenseDetailTable> JcallocationExpenseDetailTables { get; set; } = new List<JcallocationExpenseDetailTable>();

    public virtual ICollection<JcallocationExpenseDetail> JcallocationExpenseDetails { get; set; } = new List<JcallocationExpenseDetail>();

    public virtual ICollection<JccostAllocationDetail> JccostAllocationDetails { get; set; } = new List<JccostAllocationDetail>();

    public virtual ICollection<JccostVoucher> JccostVouchers { get; set; } = new List<JccostVoucher>();

    public virtual ICollection<JcexpenseTranferDetail> JcexpenseTranferDetails { get; set; } = new List<JcexpenseTranferDetail>();

    public virtual ICollection<Jcopnallocation> Jcopnallocations { get; set; } = new List<Jcopnallocation>();

    public virtual ICollection<Loanagreement> Loanagreements { get; set; } = new List<Loanagreement>();

    public virtual ICollection<OpeningAccountEntryDetail> OpeningAccountEntryDetails { get; set; } = new List<OpeningAccountEntryDetail>();

    public virtual ICollection<PasalaryExpenseDetail> PasalaryExpenseDetails { get; set; } = new List<PasalaryExpenseDetail>();

    public virtual ICollection<PrepaidExpensesDetail> PrepaidExpensesDetails { get; set; } = new List<PrepaidExpensesDetail>();

    public virtual ICollection<ProjectWorkEstimateDetail> ProjectWorkEstimateDetails { get; set; } = new List<ProjectWorkEstimateDetail>();

    public virtual ICollection<PudiscountDetail> PudiscountDetails { get; set; } = new List<PudiscountDetail>();

    public virtual ICollection<PuinvoiceDetail> PuinvoiceDetails { get; set; } = new List<PuinvoiceDetail>();

    public virtual ICollection<PuorderDetail> PuorderDetails { get; set; } = new List<PuorderDetail>();

    public virtual ICollection<PureturnDetail> PureturnDetails { get; set; } = new List<PureturnDetail>();

    public virtual ICollection<PuserviceDetail> PuserviceDetails { get; set; } = new List<PuserviceDetail>();

    public virtual ICollection<PuvoucherDetail> PuvoucherDetails { get; set; } = new List<PuvoucherDetail>();

    public virtual ICollection<SadiscountDetail> SadiscountDetails { get; set; } = new List<SadiscountDetail>();

    public virtual ICollection<SaorderDetail> SaorderDetails { get; set; } = new List<SaorderDetail>();

    public virtual ICollection<SaquoteDetail> SaquoteDetails { get; set; } = new List<SaquoteDetail>();

    public virtual ICollection<SareturnDetail> SareturnDetails { get; set; } = new List<SareturnDetail>();

    public virtual ICollection<SavoucherDetail> SavoucherDetails { get; set; } = new List<SavoucherDetail>();

    public virtual ICollection<SuallocationDetailPost> SuallocationDetailPosts { get; set; } = new List<SuallocationDetailPost>();

    public virtual ICollection<SuallocationDetailTable> SuallocationDetailTables { get; set; } = new List<SuallocationDetailTable>();

    public virtual ICollection<SuincrementDetailAllocation> SuincrementDetailAllocations { get; set; } = new List<SuincrementDetailAllocation>();

    public virtual ICollection<SutransferDetail> SutransferDetails { get; set; } = new List<SutransferDetail>();
}