﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Loại chứng từ
/// </summary>
public partial class SysrefType
{
    /// <summary>
    /// PK - Mã loại chứng từ
    /// </summary>
    public int RefType { get; set; }

    /// <summary>
    /// Tên loại chứng từ
    /// </summary>
    public string? RefTypeName { get; set; }

    /// <summary>
    /// Nhóm chứng từ. Các chu cùng nhóm thì dùng chung AutoID và cùng hiển thị trên 1 danh sách chứng từ.
    /// </summary>
    public int? RefTypeCategory { get; set; }

    /// <summary>
    /// Tên bảng Master của chứng từ ứng với RefType (phục vụ phần PostVoucher)
    /// </summary>
    public string? MasterTableName { get; set; }

    /// <summary>
    /// Tên bảng Detail của chứng từ ứng với RefType (phục vụ phần PostVoucher)
    /// </summary>
    public string? DetailTableName { get; set; }

    /// <summary>
    /// Loại chứng từ này có chức năng ghi sổ (post)
    /// </summary>
    public bool Postable { get; set; }

    /// <summary>
    /// Loại chứng từ này cho xuất hiện trong chức năng &quot;Tìm kiếm chứng từ&quot;
    /// </summary>
    public bool Searchable { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// Phân hệ
    /// </summary>
    public string? SubSystem { get; set; }

    /// <summary>
    /// Xác định ứng với Reftype nay thi có post vào bảng GeneralLedger không: 0 : có Post vào bảng GL, 1 : không post vào bảng GL
    /// </summary>
    public int? PostType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    /// <summary>
    /// Trường này dùng để chỉ các loại RefType Nào được show lên trên danh mục tài khoản ngầm định
    /// </summary>
    public bool IsShowOnAccountDefault { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    public bool? IsReference { get; set; }

    public string? RefTypeNameEnglish { get; set; }

    public string? RefTypeNameChinese { get; set; }

    public string? RefTypeNameKorean { get; set; }

    public virtual SysrefTypeCategory? RefTypeCategoryNavigation { get; set; }

    public virtual ICollection<SysrefTypeDetail> SysrefTypeDetails { get; set; } = new List<SysrefTypeDetail>();

    public virtual ICollection<VoucherTypeCategoryRefType> VoucherTypeCategoryRefTypes { get; set; } = new List<VoucherTypeCategoryRefType>();
}