﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ConfigListTableUpdateRule
{
    /// <summary>
    /// Khóa
    /// </summary>
    public Guid ConfigListTableUpdateRuleId { get; set; }

    /// <summary>
    /// Tên bảng chung
    /// </summary>
    public string GeneralTableName { get; set; } = null!;

    /// <summary>
    /// Tên cột chính
    /// </summary>
    public string GeneralColumnName { get; set; } = null!;

    /// <summary>
    /// Tên cột sẽ được cập nhật
    /// </summary>
    public string ListColumnName { get; set; } = null!;

    /// <summary>
    /// Mô tả
    /// </summary>
    public string? Description { get; set; }

    public string? Condition { get; set; }
}