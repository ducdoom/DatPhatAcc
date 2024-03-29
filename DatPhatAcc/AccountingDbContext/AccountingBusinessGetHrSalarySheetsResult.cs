﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class AccountingBusinessGetHrSalarySheetsResult
    {
        public string SalarySheetID { get; set; } = default!;
        public string? TransCode { get; set; }
        public string? ZoneID { get; set; }
        public string SalaryMonth { get; set; } = default!;
        public string DepartmentID { get; set; } = default!;
        public string? DepartmentName { get; set; }
        public int? SalaryPayDay { get; set; }
        public Guid? FeeID { get; set; }
        public string? TransDate { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Status { get; set; }
        public string? SynStatus { get; set; }
        public string? SyncTime { get; set; }
        public Guid? ImpExpMethodID { get; set; }
        public string? ImpExpMethodCode { get; set; }
        public string? ImpExpMethodName { get; set; }
    }
}
