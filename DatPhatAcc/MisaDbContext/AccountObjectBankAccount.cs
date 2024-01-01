﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu tài khoản ngân hàng của khách hàng
/// </summary>
public partial class AccountObjectBankAccount
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid AccountObjectBankAccountId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid AccountObjectId { get; set; }

    /// <summary>
    /// Số TK ngân hàng
    /// </summary>
    public string? BankAccount { get; set; }

    /// <summary>
    /// Tên ngân hàng
    /// </summary>
    public string? BankName { get; set; }

    public int? SortOrder { get; set; }

    public string? BankBranchName { get; set; }

    public string? ProvinceOrCity { get; set; }

    public virtual AccountObject AccountObject { get; set; } = null!;
}