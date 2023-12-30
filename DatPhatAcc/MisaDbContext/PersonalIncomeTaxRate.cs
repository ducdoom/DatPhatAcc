﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Biểu thuế thu nhập cá nhân (Căn cứ để tính thuế thu nhập các nhân)
/// </summary>
public partial class PersonalIncomeTaxRate
{
    /// <summary>
    /// PK - Biểu thuế thu nhập các nhân
    /// </summary>
    public Guid PersonalIncomeTaxRateId { get; set; }

    /// <summary>
    /// Bậc thuế (1 - 8)
    /// </summary>
    public int TaxGrade { get; set; }

    /// <summary>
    /// Phần trăm chịu thuế (5%; 10%;  20%...)
    /// </summary>
    public decimal TaxRate { get; set; }

    /// <summary>
    /// Thu nhập tính thuế theo tháng từ mức này
    /// </summary>
    public decimal FromIncomeByMonth { get; set; }

    /// <summary>
    /// Thu nhập tính thuế theo tháng đến mức này
    /// </summary>
    public decimal? ToIncomeByMonth { get; set; }

    /// <summary>
    /// Thu nhập tính thuế theo năm từ mức này
    /// </summary>
    public decimal FromIncomeByYear { get; set; }

    /// <summary>
    /// Thu nhập tính thuế theo năm đến mức này
    /// </summary>
    public decimal? ToIncomeByYear { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }
}