﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng kết quả tính giá thành
/// </summary>
public partial class JcproductCostDetail
{
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// ID của JCPeriodDetail
    /// </summary>
    public Guid? JcperiodDetailId { get; set; }

    /// <summary>
    /// Đối tượng THCP
    /// </summary>
    public Guid JobId { get; set; }

    /// <summary>
    /// FK - ID kỳ tính giá thành
    /// </summary>
    public Guid JcperiodId { get; set; }

    /// <summary>
    /// Mã thành phẩm
    /// </summary>
    public Guid InventoryItemId { get; set; }

    /// <summary>
    /// hệ số/Tỷ lệ phân bổ giá thành
    /// </summary>
    public decimal Coefficient { get; set; }

    /// <summary>
    /// Số thứ tự dòng
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// Chi phí nguyên vật liệu trực tiếp trong kỳ
    /// </summary>
    public decimal DirectMatetialAmount { get; set; }

    /// <summary>
    /// Chi phí nguyên vật liệu gián tiếp trong kỳ
    /// </summary>
    public decimal IndirectMatetialAmount { get; set; }

    /// <summary>
    /// Chi phí nhân công trực tiếp trong kỳ
    /// </summary>
    public decimal DirectLaborAmount { get; set; }

    /// <summary>
    /// Chi phí nhân công gián tiếp trong kỳ
    /// </summary>
    public decimal IndirectLaborAmount { get; set; }

    /// <summary>
    /// Chi phí khấu hao trong kỳ
    /// </summary>
    public decimal DepreciationAmount { get; set; }

    /// <summary>
    /// Chi phí mua ngoài trong kỳ
    /// </summary>
    public decimal PurchaseAmount { get; set; }

    /// <summary>
    /// Chi phí khác trong kỳ
    /// </summary>
    public decimal OtherAmount { get; set; }

    /// <summary>
    /// Tổng giá thành
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Tổng số lượng
    /// </summary>
    public decimal TotalQuantity { get; set; }

    /// <summary>
    /// Giá thành đơn vị
    /// </summary>
    public decimal CostPrice { get; set; }

    /// <summary>
    /// 0=Sổ tài chinh;1=Sổ quản trị
    /// </summary>
    public int DisplayOnBook { get; set; }

    /// <summary>
    /// ID Công đoạn (áp dụng cho giá thành phân bước liên tục) các loại khác để null
    /// </summary>
    public Guid? PhaseId { get; set; }

    public virtual InventoryItem InventoryItem { get; set; } = null!;

    public virtual JcperiodDetail? JcperiodDetail { get; set; }

    public virtual Job Job { get; set; } = null!;
}