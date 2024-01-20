﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class SystemStockStockinfoResult
    {
        public string StockID { get; set; } = default!;
        public string? StockName { get; set; }
        public string? Main { get; set; }
        public string? Name { get; set; }
        public int? QtyStart { get; set; }
        [Column("AmountStart", TypeName = "decimal(38,6)")]
        public decimal? AmountStart { get; set; }
        public int? ImpQty { get; set; }
        [Column("ImpAmount", TypeName = "decimal(38,6)")]
        public decimal? ImpAmount { get; set; }
        [Column("ImpAmountVat", TypeName = "decimal(38,6)")]
        public decimal? ImpAmountVat { get; set; }
        public int? ExpQty { get; set; }
        [Column("ExpAmount", TypeName = "decimal(38,6)")]
        public decimal? ExpAmount { get; set; }
        [Column("ExpAmountVat", TypeName = "decimal(38,6)")]
        public decimal? ExpAmountVat { get; set; }
        public int? EndQty { get; set; }
        [Column("EndAmount", TypeName = "decimal(38,6)")]
        public decimal? EndAmount { get; set; }
        [Column("EndAmountVat", TypeName = "decimal(38,6)")]
        public decimal? EndAmountVat { get; set; }
    }
}
