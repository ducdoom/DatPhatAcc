﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Tasubmission
{
    public string SubmissionId { get; set; } = null!;

    public string? SubmissionCode { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxReturnCode { get; set; }

    public string? TaxPeriod { get; set; }

    public string? DeclareSubmissionType { get; set; }

    public int? SubmissionTimes { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? PeriodTypeId { get; set; }

    public string? TaxReturnName { get; set; }

    public string? ParentCode { get; set; }
}