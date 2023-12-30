﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Loại công trình, vụ việc
/// </summary>
public partial class ProjectWorkCategory
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid ProjectWorkCategoryId { get; set; }

    /// <summary>
    /// Mã loại công trình dự án
    /// </summary>
    public string? ProjectWorkCategoryCode { get; set; }

    /// <summary>
    /// Tên loại công trình dự án
    /// </summary>
    public string? ProjectWorkCategoryName { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    /// <summary>
    /// Mô tả tóm tắt
    /// </summary>
    public string? Description { get; set; }

    public virtual ICollection<ProjectWork> ProjectWorks { get; set; } = new List<ProjectWork>();
}