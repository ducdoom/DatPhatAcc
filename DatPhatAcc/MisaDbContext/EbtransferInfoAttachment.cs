﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class EbtransferInfoAttachment
{
    public Guid AttachmentId { get; set; }

    public Guid RefId { get; set; }

    public int AttachmentType { get; set; }

    public string? Path { get; set; }

    public string? FileName { get; set; }

    public byte[]? AttachmentContent { get; set; }

    public string? FileExtension { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual EbtransferInfo Ref { get; set; } = null!;
}