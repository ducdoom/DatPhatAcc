﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Tài sản đảm bảo
/// </summary>
public partial class LoanagreementAsset
{
    /// <summary>
    /// Khóa chính
    /// </summary>
    public Guid LoanagreementDetailId { get; set; }

    /// <summary>
    /// Khóa ngoại
    /// </summary>
    public Guid LoanagreementId { get; set; }

    /// <summary>
    /// Tên tài tản
    /// </summary>
    public string? AssetName { get; set; }

    /// <summary>
    /// Giá trị tài sản
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Hình thức đảm bảo
    /// </summary>
    public string? MortgageMethod { get; set; }

    /// <summary>
    /// Hợp đồng đảm bảo
    /// </summary>
    public string? ContractCode { get; set; }

    /// <summary>
    /// Giấy tờ chuyển giao
    /// </summary>
    public string? TransferPaper { get; set; }

    /// <summary>
    /// Ghi chú
    /// </summary>
    public string? Note { get; set; }

    public int? SortOrder { get; set; }

    public virtual Loanagreement Loanagreement { get; set; } = null!;
}