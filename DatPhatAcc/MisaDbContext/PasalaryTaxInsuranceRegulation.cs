﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu trữ quy định lương, thuế, bảo hiểm
/// </summary>
public partial class PasalaryTaxInsuranceRegulation
{
    /// <summary>
    /// PK
    /// </summary>
    public string RegulationId { get; set; } = null!;

    /// <summary>
    /// Tên quy định
    /// </summary>
    public string? RegulationName { get; set; }

    /// <summary>
    /// Kiểu dữ liệu
    /// </summary>
    public int? DataType { get; set; }

    /// <summary>
    /// Giá trị của quy định
    /// </summary>
    public decimal? Value { get; set; }
}