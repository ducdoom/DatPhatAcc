﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class ToolsSynchronizeCategorySyncgetCategoriesReferResult
    {
        public string ParentID { get; set; } = default!;
        public string ZoneID { get; set; } = default!;
        public string? ZoneName { get; set; }
        public string? Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Status { get; set; }
        public string? SynStatus { get; set; }
        public string? SyncTime { get; set; }
    }
}
