﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class SystemLogginggetLogsByZoneIDResult
    {
        public string LogID { get; set; } = default!;
        public string? ZoneID { get; set; }
        public string? StationID { get; set; }
        public string? UserID { get; set; }
        public string? FormID { get; set; }
        public string? ControlID { get; set; }
        public DateTime? DateLog { get; set; }
        public string? LogContent { get; set; }
        public string? ZoneName { get; set; }
        public string? StationName { get; set; }
        public string UserName { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public string? FormName { get; set; }
        public string? ControlName { get; set; }
    }
}
