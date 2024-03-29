﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class ReportsExportGoodFlagResult
    {
        public string? BranchID { get; set; }
        public string? GroupID { get; set; }
        public string? SupplierID { get; set; }
        public string? CustomerName { get; set; }
        public string GoodID { get; set; } = default!;
        public string? FullName { get; set; }
        public string? FlagOnDate { get; set; }
        public string? FlagOffDate { get; set; }
        public string? Status { get; set; }
        public string? FlagOnBy { get; set; }
        public string OrderId { get; set; } = default!;
        public int? OrderQuantity { get; set; }
        [Column("TotalImpPriceVAT", TypeName = "decimal(22,8)")]
        public decimal? TotalImpPriceVAT { get; set; }
        public string? ObjOrderId { get; set; }
        public string? ObjOrderName { get; set; }
        public string? OrderDate { get; set; }
    }
}
