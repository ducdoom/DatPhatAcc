﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SysreportCustomDesignTemplate
{
    public Guid DesignTemplateId { get; set; }

    public string ReportId { get; set; } = null!;

    public byte[]? ReportFileData { get; set; }

    public Guid? BankId { get; set; }

    public virtual SysreportList Report { get; set; } = null!;
}