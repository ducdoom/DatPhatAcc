﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SysreportMergeType
{
    public int ReportTypeId { get; set; }

    public string ReportTypeName { get; set; }

    public string ProcedureName { get; set; }

    public string RefTypeList { get; set; }

    public string TableName { get; set; }

    public string PrimaryKeyMaster { get; set; }

    public string FunctionReportName { get; set; }

    public string MergeTemplate { get; set; }

    public int? RefTypeCategory { get; set; }

    public string ReportTypeNameEnglish { get; set; }

    public string ReportTypeNameChinese { get; set; }

    public string ReportTypeNameKorean { get; set; }

    public string RefTypeListSample { get; set; }

    public string MergeTemplateSample { get; set; }

    public virtual ICollection<SysreportCustom> SysreportCustoms { get; set; } = new List<SysreportCustom>();
}