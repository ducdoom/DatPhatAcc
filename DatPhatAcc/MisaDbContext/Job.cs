﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Đối tượng tập hợp chi phí
/// </summary>
public partial class Job
{
    /// <summary>
    /// PK Công việc, công trình dự án
    /// </summary>
    public Guid JobId { get; set; }

    /// <summary>
    /// Mã công việc
    /// </summary>
    public string JobCode { get; set; } = null!;

    /// <summary>
    /// Tên Công việc
    /// </summary>
    public string JobName { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public string? MisacodeId { get; set; }

    public int? Grade { get; set; }

    public bool IsParent { get; set; }

    /// <summary>
    /// Loại có giá trị: 0=phân xưởng;1=sản phẩm;2=quy trình sản xuất;3=công đoạn
    /// </summary>
    public int? JobType { get; set; }

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
    /// Là hệ thống
    /// </summary>
    public bool IsSystem { get; set; }

    /// <summary>
    /// Thành phẩm
    /// </summary>
    public Guid? InventoryItemId { get; set; }

    /// <summary>
    /// Loại quy trình sản xuất (0=Phân bước liên tục;1=phân bước song song)
    /// </summary>
    public int ProductionProcessType { get; set; }

    /// <summary>
    /// Công đoạn thứ n
    /// </summary>
    public int Stage { get; set; }

    /// <summary>
    /// Công đoạn trước
    /// </summary>
    public Guid? StageId { get; set; }

    /// <summary>
    /// Chi nhánh
    /// </summary>
    public Guid? BranchId { get; set; }

    /// <summary>
    /// 0:Tập hợp chi phí đến công đoạn; 1: Tập hợp chi phi đến từng sản phẩm trong công đoạn
    /// </summary>
    public int? CollectCostInStageType { get; set; }

    /// <summary>
    /// Là nửa thành phẩm của công đoạn
    /// </summary>
    public bool? IsSemiProduct { get; set; }

    /// <summary>
    /// Cột dùng để sort trên báo cáo. Không sử dụng trên giao diện.
    /// </summary>
    public string? SortMisacodeId { get; set; }

    public virtual ICollection<BadepositDetail> BadepositDetails { get; set; } = new List<BadepositDetail>();

    public virtual ICollection<BawithDrawDetail> BawithDrawDetails { get; set; } = new List<BawithDrawDetail>();

    public virtual OrganizationUnit? Branch { get; set; }

    public virtual ICollection<CapaymentDetail> CapaymentDetails { get; set; } = new List<CapaymentDetail>();

    public virtual ICollection<CareceiptDetail> CareceiptDetails { get; set; } = new List<CareceiptDetail>();

    public virtual ICollection<FaadjustmentDetailPost> FaadjustmentDetailPosts { get; set; } = new List<FaadjustmentDetailPost>();

    public virtual ICollection<FadecrementDetailPost> FadecrementDetailPosts { get; set; } = new List<FadecrementDetailPost>();

    public virtual ICollection<FadepreciationDetailPost> FadepreciationDetailPosts { get; set; } = new List<FadepreciationDetailPost>();

    public virtual ICollection<GlvoucherDetail> GlvoucherDetails { get; set; } = new List<GlvoucherDetail>();

    public virtual ICollection<IninvoiceHubOutwardDetail> IninvoiceHubOutwardDetails { get; set; } = new List<IninvoiceHubOutwardDetail>();

    public virtual ICollection<IninvoiceHubTransferDetail> IninvoiceHubTransferDetails { get; set; } = new List<IninvoiceHubTransferDetail>();

    public virtual ICollection<IninwardDetail> IninwardDetails { get; set; } = new List<IninwardDetail>();

    public virtual ICollection<InoutwardDetail> InoutwardDetails { get; set; } = new List<InoutwardDetail>();

    public virtual ICollection<InproductionOrderDetail> InproductionOrderDetails { get; set; } = new List<InproductionOrderDetail>();

    public virtual ICollection<InproductionOrderProduct> InproductionOrderProducts { get; set; } = new List<InproductionOrderProduct>();

    public virtual ICollection<IntransferDetail> IntransferDetails { get; set; } = new List<IntransferDetail>();

    public virtual InventoryItem? InventoryItem { get; set; }

    public virtual JcallocationQuantum? JcallocationQuantum { get; set; }

    public virtual ICollection<JccostAllocationDetail> JccostAllocationDetails { get; set; } = new List<JccostAllocationDetail>();

    public virtual ICollection<JcexpenseTranferDetail> JcexpenseTranferDetails { get; set; } = new List<JcexpenseTranferDetail>();

    public virtual ICollection<Jcopn> Jcopns { get; set; } = new List<Jcopn>();

    public virtual ICollection<JcperiodDetail> JcperiodDetails { get; set; } = new List<JcperiodDetail>();

    public virtual ICollection<JcproductCostAllocationConfig> JcproductCostAllocationConfigs { get; set; } = new List<JcproductCostAllocationConfig>();

    public virtual ICollection<JcproductCostDetail> JcproductCostDetails { get; set; } = new List<JcproductCostDetail>();

    public virtual ICollection<JcuncompleteDetail> JcuncompleteDetails { get; set; } = new List<JcuncompleteDetail>();

    public virtual ICollection<Jcuncomplete> Jcuncompletes { get; set; } = new List<Jcuncomplete>();

    public virtual ICollection<JobProduct> JobProducts { get; set; } = new List<JobProduct>();

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