﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class HrWorkingTime
{
    /// <summary>
    /// Ngày hạch toán
    /// </summary>
    public string WorkingTime { get; set; }

    public string DepartmentId { get; set; }

    /// <summary>
    /// Số tiền nguyên tệ
    /// </summary>
    public int? NumOfWorkingDay { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string CreatedBy { get; set; }

    public string UpdatedBy { get; set; }

    public string Status { get; set; }

    public string SynStatus { get; set; }

    public string SyncTime { get; set; }
}