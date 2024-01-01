﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SysvoucherTemplateDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid LayoutDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid LayoutId { get; set; }

    /// <summary>
    /// Xác định loại grid, 0=Grid Detail, 1=Grid other
    /// </summary>
    public byte GridType { get; set; }

    /// <summary>
    /// Thứ tự của tab
    /// </summary>
    public byte TabIndex { get; set; }

    /// <summary>
    /// Tiêu đề
    /// </summary>
    public string? TabCaption { get; set; }

    /// <summary>
    /// Tab này có được hiển thị không
    /// </summary>
    public bool? TabVisible { get; set; }

    /// <summary>
    /// Là tab chứa các thông tin bổ sung
    /// </summary>
    public bool? IsTabCustomField { get; set; }

    /// <summary>
    /// Cấu hình của grid tương ứng với tab đang chọn
    /// </summary>
    public string? TemplateConfig { get; set; }

    /// <summary>
    /// Tên của grid, dùng để phân biệt trên các chứng từ có nhiều grid
    /// </summary>
    public string? GridName { get; set; }

    /// <summary>
    /// Tab này có được hiển thị khi chọn PP khấu trừ thuế trực tiếp theo doanh thu hay không?
    /// </summary>
    public bool? IsHiddenTabByVatmethod { get; set; }

    /// <summary>
    /// Tab này có được hiển thị khi chọn PP khấu trừ thuế trực tiếp theo doanh thu hay không?
    /// </summary>
    public bool? IsShowOnMaster { get; set; }

    public string? TabCaptionEnglish { get; set; }

    public string? TabCaptionChinese { get; set; }

    public string? TabCaptionKorean { get; set; }

    public virtual SysvoucherTemplate Layout { get; set; } = null!;
}