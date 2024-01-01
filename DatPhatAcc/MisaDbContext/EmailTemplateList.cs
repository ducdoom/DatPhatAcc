﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class EmailTemplateList
{
    public Guid TemplateId { get; set; }

    public string TemplateName { get; set; } = null!;

    public int TemplateType { get; set; }

    public string TemplateSubject { get; set; } = null!;

    public string TemplateContent { get; set; } = null!;

    public string? AttachmentDefault { get; set; }

    public bool IsSystem { get; set; }

    public bool IsGlobal { get; set; }

    public Guid? BranchId { get; set; }

    public Guid? UserId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<EmailTemplateApply> EmailTemplateApplies { get; set; } = new List<EmailTemplateApply>();

    public virtual SysemailTemplateType TemplateTypeNavigation { get; set; } = null!;
}