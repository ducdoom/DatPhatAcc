﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class AccountingBusinessGetTransactionExpiredDateDetailsResult
    {
        public Guid ExpireID { get; set; }
        public string TransactionID { get; set; } = default!;
        public string GoodID { get; set; } = default!;
        public string? FullName { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string LotNumber { get; set; } = default!;
        public string ImportID { get; set; } = default!;
        public string ExportID { get; set; } = default!;
        public int Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? SyncTime { get; set; }
        public string BigUnitID { get; set; } = default!;
        public string? UnitID { get; set; }
        [Column("ExchangeRate", TypeName = "decimal(22,8)")]
        public decimal? ExchangeRate { get; set; }
        [Column("ImpPriceOC", TypeName = "decimal(38,16)")]
        public decimal? ImpPriceOC { get; set; }
        [Column("ImpPriceVAT", TypeName = "decimal(22,8)")]
        public decimal? ImpPriceVAT { get; set; }
        [Column("ImpPriceVATOC", TypeName = "decimal(38,16)")]
        public decimal? ImpPriceVATOC { get; set; }
        [Column("TotalImpPriceOC", TypeName = "decimal(38,16)")]
        public decimal? TotalImpPriceOC { get; set; }
        [Column("TotalImpPriceVAT", TypeName = "decimal(22,8)")]
        public decimal? TotalImpPriceVAT { get; set; }
        [Column("TotalImpPriceVATOC", TypeName = "decimal(38,16)")]
        public decimal? TotalImpPriceVATOC { get; set; }
        [Column("TotalPriceOrgOC", TypeName = "decimal(38,16)")]
        public decimal? TotalPriceOrgOC { get; set; }
        [Column("TotalPriceVATOrgOC", TypeName = "decimal(38,16)")]
        public decimal? TotalPriceVATOrgOC { get; set; }
        [Column("TotalPriceOrg", TypeName = "decimal(22,8)")]
        public decimal? TotalPriceOrg { get; set; }
        [Column("TotalPriceVATOrg", TypeName = "decimal(22,8)")]
        public decimal? TotalPriceVATOrg { get; set; }
        [Column("ExpPriceOC", TypeName = "decimal(38,16)")]
        public decimal? ExpPriceOC { get; set; }
        [Column("ExpPriceVATOC", TypeName = "decimal(38,16)")]
        public decimal? ExpPriceVATOC { get; set; }
        [Column("TotalExpPriceOC", TypeName = "decimal(38,16)")]
        public decimal? TotalExpPriceOC { get; set; }
        [Column("TotalExpPriceVATOC", TypeName = "decimal(38,16)")]
        public decimal? TotalExpPriceVATOC { get; set; }
    }
}