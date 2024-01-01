﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class FachangeFinancialLeasingToOwner
{
    public Guid RefId { get; set; }

    public Guid BranchId { get; set; }

    public int DisplayOnBook { get; set; }

    public int RefType { get; set; }

    public DateTime PostedDate { get; set; }

    public DateTime RefDate { get; set; }

    public string RefNo { get; set; } = null!;

    public bool IsPostedFinance { get; set; }

    public bool IsPostedManagement { get; set; }

    public string? JournalMemo { get; set; }

    public Guid FixedAssetId { get; set; }

    public string FixedAssetCode { get; set; } = null!;

    public string? OldOrgPriceAccount { get; set; }

    public string? NewOrgPriceAccount { get; set; }

    public string? OldDepreciationAccount { get; set; }

    public string? NewDepreciationAccount { get; set; }

    public decimal OldOrgPrice { get; set; }

    public decimal NewOrgPrice { get; set; }

    public decimal OldDepreciationAmount { get; set; }

    public decimal NewDepreciationAmount { get; set; }

    public decimal OldAccumDepreciationAmount { get; set; }

    public decimal NewAccumDepreciationAmount { get; set; }

    public decimal OldRemainingAmount { get; set; }

    public decimal NewRemainingAmount { get; set; }

    public decimal OldLifeTime { get; set; }

    public decimal NewLifeTime { get; set; }

    public decimal OldLifeTimeRemaining { get; set; }

    public decimal NewLifeTimeRemaining { get; set; }

    public decimal OldDepreciationRateMonth { get; set; }

    public decimal NewDepreciationRateMonth { get; set; }

    public decimal OldMonthlyDepreciationAmount { get; set; }

    public decimal NewMonthlyDepreciationAmount { get; set; }

    public decimal OldDepreciationRateYear { get; set; }

    public decimal NewDepreciationRateYear { get; set; }

    public decimal OldYearlyDepreciationAmount { get; set; }

    public decimal NewYearlyDepreciationAmount { get; set; }

    public bool OldIsLimitDepreciationAmount { get; set; }

    public bool NewIsLimitDepreciationAmount { get; set; }

    public decimal OldDepreciationAmountByIncomeTax { get; set; }

    public decimal NewDepreciationAmountByIncomeTax { get; set; }

    public decimal OldRemainingAmountByIncomeTax { get; set; }

    public decimal NewRemainingAmountByIncomeTax { get; set; }

    public decimal OldMonthlyDepreciationAmountByIncomeTax { get; set; }

    public decimal NewMonthlyDepreciationAmountByIncomeTax { get; set; }

    public byte[]? EditVersion { get; set; }

    public int RefOrder { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual OrganizationUnit Branch { get; set; } = null!;

    public virtual ICollection<FachangeFinancialLeasingToOwnerDetail> FachangeFinancialLeasingToOwnerDetails { get; set; } = new List<FachangeFinancialLeasingToOwnerDetail>();

    public virtual FixedAsset FixedAsset { get; set; } = null!;

    public virtual Account? NewDepreciationAccountNavigation { get; set; }

    public virtual Account? NewOrgPriceAccountNavigation { get; set; }

    public virtual Account? OldDepreciationAccountNavigation { get; set; }

    public virtual Account? OldOrgPriceAccountNavigation { get; set; }
}