﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu thông tin xác nhận  khi quên mật khẩu
/// </summary>
public partial class MscConfirmPassword
{
    public Guid ConfirmPasswordId { get; set; }

    public Guid UserId { get; set; }

    /// <summary>
    /// Mã xác nhận
    /// </summary>
    public string ConfirmPasswordCode { get; set; } = null!;

    /// <summary>
    /// Ngày giờ tạo
    /// </summary>
    public DateTime CreatedDate { get; set; }

    public virtual MscUser User { get; set; } = null!;
}