﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng xác nhận đối chiếu ngân hàng
/// </summary>
public partial class Ebreconciliation
{
    public Guid ReconciliationId { get; set; }

    /// <summary>
    /// TK ngân hàng
    /// </summary>
    public Guid BankAccountId { get; set; }

    /// <summary>
    /// Hiển thị theo sổ
    /// </summary>
    public bool DisplayOnBook { get; set; }

    /// <summary>
    /// Từ ngày của ngày xác nhận đối chiếu
    /// </summary>
    public DateTime Todate { get; set; }

    public Guid? BranchId { get; set; }
}