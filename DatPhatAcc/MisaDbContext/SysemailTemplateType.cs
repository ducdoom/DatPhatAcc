﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SysemailTemplateType
{
    public int TemplateTypeId { get; set; }

    public string TemplateTypeName { get; set; }

    public int? CategoryId { get; set; }

    public string ListObjectId { get; set; }

    public string TableName { get; set; }

    public string ProcedureName { get; set; }

    public string FunctionName { get; set; }

    public string Description { get; set; }

    public string MergeTempalte { get; set; }

    public virtual ICollection<EmailTemplateList> EmailTemplateLists { get; set; } = new List<EmailTemplateList>();
}