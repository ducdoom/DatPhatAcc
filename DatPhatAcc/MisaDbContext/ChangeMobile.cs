﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng lưu số điện thoại thay đổi khi chuyển đầu số
/// </summary>
public partial class ChangeMobile
{
    public int KeyId { get; set; }

    public Guid ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public string? OldTel { get; set; }

    public string? NewTel { get; set; }

    public string? OldMobile { get; set; }

    public string? NewMobile { get; set; }

    public string? OldContactMobile { get; set; }

    public string? NewContactMobile { get; set; }

    public string? OldOtherContactMobile { get; set; }

    public string? NewOtherContactMobile { get; set; }

    public string? OldContactFixedTel { get; set; }

    public string? NewContactFixedTel { get; set; }

    public string? OldEinvoiceContactMobile { get; set; }

    public string? NewEinvoiceContactMobile { get; set; }

    public string? OldContactOfficeTel { get; set; }

    public string? NewContactOfficeTel { get; set; }

    public string? NotificationId { get; set; }
}