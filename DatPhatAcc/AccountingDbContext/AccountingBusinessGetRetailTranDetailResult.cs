﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class AccountingBusinessGetRetailTranDetailResult
    {
        public Guid TransDetailID { get; set; }
        public string TransactionID { get; set; } = default!;
        public string? ZoneID { get; set; }
        public string FullGoodID { get; set; } = default!;
        public string? GoodID { get; set; }
        public string? FullName { get; set; }
        public bool? Warranty { get; set; }
        public int? NumberWarrantyDay { get; set; }
        public bool? HasExpireDate { get; set; }
        public int? NumberExpireDay { get; set; }
        public bool? HasSerial { get; set; }
        public string? GroupID { get; set; }
        public string? BranchID { get; set; }
        public string? CustomerID { get; set; }
        public int? Quantity { get; set; }
        public int? OrginalQty { get; set; }
        public string BigUnitID { get; set; } = default!;
        public string? UnitID { get; set; }
        public string? UnitName { get; set; }
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
        [Column("ExpPrice_CK", TypeName = "decimal(1,1)")]
        public decimal ExpPrice_CK { get; set; }
        [Column("ExpPriceVAT_CK", TypeName = "decimal(1,1)")]
        public decimal ExpPriceVAT_CK { get; set; }
        public string? VatID { get; set; }
        public int VatPercent { get; set; }
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
        [Column("ProfitVat", TypeName = "decimal(33,8)")]
        public decimal? ProfitVat { get; set; }
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
        [Column("TotalVAT", TypeName = "decimal(22,8)")]
        public decimal? TotalVAT { get; set; }
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
        public string CostDebitAccount { get; set; } = default!;
        public string CostCreditAccount { get; set; } = default!;
        [Column("FeeAmount", TypeName = "decimal(22,8)")]
        public decimal FeeAmount { get; set; }
        [Column("FeeAmountVAT", TypeName = "decimal(22,8)")]
        public decimal FeeAmountVAT { get; set; }
        [Column("FeeTaxVatAmount", TypeName = "decimal(22,8)")]
        public decimal FeeTaxVatAmount { get; set; }
        [Column("DiscountRate", TypeName = "decimal(22,8)")]
        public decimal DiscountRate { get; set; }
        [Column("DiscountAmount", TypeName = "decimal(22,8)")]
        public decimal DiscountAmount { get; set; }
        public string DiscountName { get; set; } = default!;
        public string DiscountType { get; set; } = default!;
        [Column("OtherTaxRate", TypeName = "decimal(22,8)")]
        public decimal OtherTaxRate { get; set; }
        [Column("OtherTaxAmount", TypeName = "decimal(22,8)")]
        public decimal OtherTaxAmount { get; set; }
        public string OtherTaxName { get; set; } = default!;
        public string DebitAccount_OtherTaxAmount { get; set; } = default!;
        public string CreditAccount_OtherTaxAmount { get; set; } = default!;
        [Column("PromotionRate", TypeName = "decimal(22,8)")]
        public decimal PromotionRate { get; set; }
        [Column("PromotionAmount", TypeName = "decimal(22,8)")]
        public decimal PromotionAmount { get; set; }
        public string PromotionName { get; set; } = default!;
        public string PromotionType { get; set; } = default!;
        [Column("TransportAmount", TypeName = "decimal(22,8)")]
        public decimal TransportAmount { get; set; }
        public string TransporterID { get; set; } = default!;
        public string TransporterName { get; set; } = default!;
        public string DebitAccount_TransportAmount { get; set; } = default!;
        public string CreditAccount_TransportAmount { get; set; } = default!;
        [Column("TotalPriceOrg", TypeName = "decimal(22,8)")]
        public decimal? TotalPriceOrg { get; set; }
        [Column("TotalPriceVATOrg", TypeName = "decimal(22,8)")]
        public decimal? TotalPriceVATOrg { get; set; }
        [Column("ProfitPercent", TypeName = "decimal(38,11)")]
        public decimal? ProfitPercent { get; set; }
        [Column("TotalProfit", TypeName = "decimal(1,1)")]
        public decimal TotalProfit { get; set; }
        public string PacketID { get; set; } = default!;
        public int QuantityPacket { get; set; }
        public int Accumulation { get; set; }
    }
}
