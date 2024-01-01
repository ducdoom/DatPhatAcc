﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Chi tiết kiểm kê tài sản
/// </summary>
public partial class FaauditDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// RefID của Master
    /// </summary>
    public Guid RefId { get; set; }

    /// <summary>
    /// Tài sản cố định
    /// </summary>
    public Guid FixedAssetId { get; set; }

    /// <summary>
    /// Đơn vị sử dụng
    /// </summary>
    public Guid OrganizationUnitId { get; set; }

    /// <summary>
    /// Nguyên giá
    /// </summary>
    public decimal OrgPrice { get; set; }

    /// <summary>
    /// Giá trị tính khấu hao hiện tại
    /// </summary>
    public decimal DepreciationAmount { get; set; }

    /// <summary>
    /// Giá trị hao mòn lỹ kế hiện tại
    /// </summary>
    public decimal AccumDepreciationAmount { get; set; }

    /// <summary>
    /// Giá trị còn lại
    /// </summary>
    public decimal RemainingAmount { get; set; }

    /// <summary>
    /// 0 = Mất; 1 = Còn
    /// </summary>
    public int? ExistInStock { get; set; }

    /// <summary>
    /// 0: Hoạt động tốt, 1: Bị hỏng, 2: Không xác định
    /// </summary>
    public int? Quality { get; set; }

    /// <summary>
    /// 0 = Không kiến nghị; 1 = Ghi giảm; 2 = Khác
    /// </summary>
    public int? Recommendation { get; set; }

    /// <summary>
    /// Ghi chú
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Số thứ tự dòng
    /// </summary>
    public int SortOrder { get; set; }

    public virtual FixedAsset FixedAsset { get; set; } = null!;

    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    public virtual Faaudit Ref { get; set; } = null!;
}