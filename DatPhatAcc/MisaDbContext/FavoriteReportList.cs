﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class FavoriteReportList
{
    public string ReportId { get; set; } = null!;

    public string? ReportName { get; set; }

    public bool? Type { get; set; }

    public Guid UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? Description { get; set; }

    public int? GroupId { get; set; }

    public string? ReportNameEnglish { get; set; }

    public int? GroupType { get; set; }

    public string? ReportNameChinese { get; set; }

    public string? ReportNameKorean { get; set; }
}