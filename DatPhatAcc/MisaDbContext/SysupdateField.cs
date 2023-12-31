﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SysupdateField
{
    public Guid UpdateFieldId { get; set; }

    /// <summary>
    /// Tên cột cần Update
    /// </summary>
    public string TableColumnName { get; set; } = null!;

    /// <summary>
    /// Điều kiện Update
    /// </summary>
    public string? UpdateCondition { get; set; }

    /// <summary>
    /// Danh sách bảng không cần Update
    /// </summary>
    public string? TableUpdate { get; set; }

    public string? MasterTableName { get; set; }

    /// <summary>
    /// Trường này dùng để lấy các bảng để chuyển (VD: Chuyển tài khoản hạch toán thì giá trị=Account; Chuyển phòng ban thì giá trị =Department)
    /// </summary>
    public string? DictionaryCategory { get; set; }

    /// <summary>
    /// Trường này để xác định loại bảng (0=Danh mục; 1=chứng từ; 2=Số dư;3=Báo cáo;4=Ledger)
    /// </summary>
    public int? TableType { get; set; }
}