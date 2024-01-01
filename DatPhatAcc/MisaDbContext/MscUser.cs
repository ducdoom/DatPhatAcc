﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// bảng danh sách người dùng
/// </summary>
public partial class MscUser
{
    public Guid UserId { get; set; }

    /// <summary>
    /// Tên đăng nhập của người dùng
    /// </summary>
    public string UserName { get; set; } = null!;

    /// <summary>
    /// Mật khẩu đã được mã hóa
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    /// Hàm mã hóa mật khẩu
    /// </summary>
    public string? PasswordEncryption { get; set; }

    /// <summary>
    /// Chức danh
    /// </summary>
    public string? JobTitle { get; set; }

    /// <summary>
    /// Họ và tên
    /// </summary>
    public string? FullName { get; set; }

    /// <summary>
    /// Đơn vị
    /// </summary>
    public Guid? OrganizationUnitId { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Địa chỉ Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Điện thoại cơ quan (Cố định)
    /// </summary>
    public string? WorkPhone { get; set; }

    /// <summary>
    /// Điện thoại di động
    /// </summary>
    public string? MobilePhone { get; set; }

    /// <summary>
    /// Số Fax
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// Địa chỉ cơ quan
    /// </summary>
    public string? WorkAddress { get; set; }

    /// <summary>
    /// Địa chỉ nhà riêng
    /// </summary>
    public string? HomeAddress { get; set; }

    /// <summary>
    /// Ảnh
    /// </summary>
    public byte[]? Photo { get; set; }

    /// <summary>
    /// Làm việc với sổ tài chính
    /// </summary>
    public bool IsWorkingWithFinanceBook { get; set; }

    /// <summary>
    /// Làm việc với sổ quản trị
    /// </summary>
    public bool IsWorkingWithManagementBook { get; set; }

    /// <summary>
    /// Ngừng hoạt động
    /// </summary>
    public bool Inactive { get; set; }

    public bool IsSystem { get; set; }

    public DateTime? NotifyEmailDate { get; set; }

    public string? Misaid { get; set; }

    public bool IsInvite { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public int UserStatus { get; set; }

    public int ActiveType { get; set; }

    /// <summary>
    /// Trạng thái kích hoạt người dùng
    /// </summary>
    public bool IsActived { get; set; }

    public virtual ICollection<MscConfirmPassword> MscConfirmPasswords { get; set; } = new List<MscConfirmPassword>();

    public virtual ICollection<MscUserJoinRole> MscUserJoinRoles { get; set; } = new List<MscUserJoinRole>();

    public virtual OrganizationUnit? OrganizationUnit { get; set; }
}