﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class ToolsSynchronizeTransactionsSyncgetTransDetailResult
    {
        public int ItemID { get; set; }
        public Guid TransDetailID { get; set; }
        public string TransactionID { get; set; } = default!;
        public string? ZoneID { get; set; }
        public string FullGoodID { get; set; } = default!;
        public string? GoodID { get; set; }
        public string? GroupID { get; set; }
        public string? BranchID { get; set; }
        public string? CustomerID { get; set; }
        public int? Quantity { get; set; }
        public int? QuantityRefer { get; set; }
        public string BigUnitID { get; set; } = default!;
        public string? UnitID { get; set; }
        [Column("ExchangeRate", TypeName = "decimal(22,8)")]
        public decimal? ExchangeRate { get; set; }
        [Column("ImpPrice", TypeName = "decimal(22,8)")]
        public decimal? ImpPrice { get; set; }
        [Column("ImpPriceVAT", TypeName = "decimal(22,8)")]
        public decimal? ImpPriceVAT { get; set; }
        [Column("ExpPrice", TypeName = "decimal(22,8)")]
        public decimal? ExpPrice { get; set; }
        [Column("ExpPriceVAT", TypeName = "decimal(22,8)")]
        public decimal? ExpPriceVAT { get; set; }
        public string? VatID { get; set; }
        [Column("TotalImpPrice", TypeName = "decimal(22,8)")]
        public decimal? TotalImpPrice { get; set; }
        [Column("TotalImpPriceVAT", TypeName = "decimal(22,8)")]
        public decimal? TotalImpPriceVAT { get; set; }
        [Column("TotalExpPrice", TypeName = "decimal(22,8)")]
        public decimal? TotalExpPrice { get; set; }
        [Column("TotalExpPriceVAT", TypeName = "decimal(22,8)")]
        public decimal? TotalExpPriceVAT { get; set; }
        [Column("Profit", TypeName = "decimal(22,8)")]
        public decimal? Profit { get; set; }
        public string? Description { get; set; }
        public int? Sort { get; set; }
        public string? TransDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Status { get; set; }
        public string? SynStatus { get; set; }
        public string? Time { get; set; }
        public string? SyncTime { get; set; }
        public string? DebitAccount { get; set; }
        public string? CreditAccount { get; set; }
        [Column("TaxVatRate", TypeName = "decimal(22,8)")]
        public decimal? TaxVatRate { get; set; }
        [Column("TaxVatAmount", TypeName = "decimal(22,8)")]
        public decimal TaxVatAmount { get; set; }
        public string? DebitTaxVATAccount { get; set; }
        public string? CreditTaxVATAccount { get; set; }
        public string? LotNumber { get; set; }
        public string? ExpiredDate { get; set; }
        public string ImportID { get; set; } = default!;
        public string ExportID { get; set; } = default!;
        [Column("PriceOrg", TypeName = "decimal(22,8)")]
        public decimal? PriceOrg { get; set; }
        [Column("PriceVATOrg", TypeName = "decimal(22,8)")]
        public decimal? PriceVATOrg { get; set; }
        public string? CostDebitAccount { get; set; }
        public string? CostCreditAccount { get; set; }
        [Column("FeeAmount", TypeName = "decimal(22,8)")]
        public decimal? FeeAmount { get; set; }
        [Column("FeeAmountVAT", TypeName = "decimal(22,8)")]
        public decimal? FeeAmountVAT { get; set; }
        [Column("TotalPriceOrg", TypeName = "decimal(22,8)")]
        public decimal? TotalPriceOrg { get; set; }
        [Column("TotalPriceVATOrg", TypeName = "decimal(22,8)")]
        public decimal? TotalPriceVATOrg { get; set; }
    }
}
