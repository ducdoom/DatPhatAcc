﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class TRANSACTIONADJUSTMENTINVENTORYGETGOODSBYCONDITIONResult
    {
        public string StockID { get; set; } = default!;
        public string? StockName { get; set; }
        public string GoodID { get; set; } = default!;
        public string FullGoodID { get; set; } = default!;
        public string? FullName { get; set; }
        public string? SupplierID { get; set; }
        public string? CustomerName { get; set; }
        public string? BranchID { get; set; }
        public string? BranchName { get; set; }
        public string? GroupID { get; set; }
        public string? GroupName { get; set; }
        public decimal AveryPrice { get; set; }
        public decimal AveryPriceVat { get; set; }
        public int QtyStart { get; set; }
        public decimal? AmountStart { get; set; }
        public decimal? AmountStartVat { get; set; }
        public int? ImpQty { get; set; }
        public decimal? ImpAmount { get; set; }
        public decimal? ImpAmountVat { get; set; }
        public int? ExpQty { get; set; }
        public decimal? ExpAmount { get; set; }
        public decimal? ExpAmountVat { get; set; }
        public int? EndQty { get; set; }
        public decimal? EndAmount { get; set; }
        public decimal? EndAmountVat { get; set; }
        [Column("ExpRetailPriceVat", TypeName = "decimal(22,8)")]
        public decimal? ExpRetailPriceVat { get; set; }
        [Column("ExpWholePriceVat", TypeName = "decimal(22,8)")]
        public decimal? ExpWholePriceVat { get; set; }
        public string? UnitName { get; set; }
        public int? ConvertUnit { get; set; }
    }
}