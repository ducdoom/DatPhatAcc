﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class SystemStockSummaryXNTTestResult
    {
        public string? ExportID { get; set; }
        [Column("SumQtyExp", TypeName = "decimal(18,6)")]
        public decimal? SumQtyExp { get; set; }
        [Column("SumExp", TypeName = "decimal(18,6)")]
        public decimal? SumExp { get; set; }
        [Column("SumExpVat", TypeName = "decimal(18,6)")]
        public decimal? SumExpVat { get; set; }
        public string? ImportID { get; set; }
        [Column("SumQtyImp", TypeName = "decimal(18,6)")]
        public decimal? SumQtyImp { get; set; }
        [Column("SumImp", TypeName = "decimal(18,6)")]
        public decimal? SumImp { get; set; }
        [Column("SumImpVat", TypeName = "decimal(18,6)")]
        public decimal? SumImpVat { get; set; }
    }
}
