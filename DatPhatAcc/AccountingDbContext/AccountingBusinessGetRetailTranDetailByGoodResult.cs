﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class AccountingBusinessGetRetailTranDetailByGoodResult
    {
        public Guid? TransDetailID { get; set; }
        public string TransactionID { get; set; } = default!;
        public string ZoneID { get; set; } = default!;
        public string FullGoodID { get; set; } = default!;
        public string GoodID { get; set; } = default!;
        public string? FullName { get; set; }
        public bool? Warranty { get; set; }
        public int? NumberWarrantyDay { get; set; }
        public bool? HasExpireDate { get; set; }
        public int? NumberExpireDay { get; set; }
        public bool? HasSerial { get; set; }
        public string? GroupID { get; set; }
        public string? BranchID { get; set; }
        public string? CustomerID { get; set; }
        [Column("Quantity", TypeName = "decimal(1,1)")]
        public decimal Quantity { get; set; }
        [Column("OrginalQty", TypeName = "decimal(1,1)")]
        public decimal OrginalQty { get; set; }
        public string? BigUnitID { get; set; }
        public string? UnitID { get; set; }
        public string UnitName { get; set; } = default!;
        public int ExchangeRate { get; set; }
        [Column("ImpPrice", TypeName = "decimal(22,8)")]
        public decimal? ImpPrice { get; set; }
        [Column("ImpPriceVAT", TypeName = "decimal(22,8)")]
        public decimal? ImpPriceVAT { get; set; }
        [Column("ExpPrice", TypeName = "decimal(22,8)")]
        public decimal? ExpPrice { get; set; }
        [Column("ExpPriceVAT", TypeName = "decimal(22,8)")]
        public decimal? ExpPriceVAT { get; set; }
        [Column("ExpPrice2", TypeName = "decimal(22,8)")]
        public decimal? ExpPrice2 { get; set; }
        [Column("ExpPriceVAT2", TypeName = "decimal(22,8)")]
        public decimal? ExpPriceVAT2 { get; set; }
        [Column("ExpPrice_CK", TypeName = "decimal(1,1)")]
        public decimal ExpPrice_CK { get; set; }
        [Column("ExpPriceVAT_CK", TypeName = "decimal(1,1)")]
        public decimal ExpPriceVAT_CK { get; set; }
        public string? VatID { get; set; }
        public int VatPercent { get; set; }
        [Column("TotalImpPrice", TypeName = "decimal(1,1)")]
        public decimal TotalImpPrice { get; set; }
        [Column("TotalImpPriceVAT", TypeName = "decimal(1,1)")]
        public decimal TotalImpPriceVAT { get; set; }
        [Column("TotalExpPrice", TypeName = "decimal(1,1)")]
        public decimal TotalExpPrice { get; set; }
        [Column("TotalExpPriceVAT", TypeName = "decimal(1,1)")]
        public decimal TotalExpPriceVAT { get; set; }
        [Column("Profit", TypeName = "decimal(1,1)")]
        public decimal Profit { get; set; }
        [Column("ProfitVat", TypeName = "decimal(1,1)")]
        public decimal ProfitVat { get; set; }
        public string DebitAccount { get; set; } = default!;
        public string CreditAccount { get; set; } = default!;
        [Column("TaxVatRate", TypeName = "decimal(1,1)")]
        public decimal TaxVatRate { get; set; }
        [Column("TaxVatAmount", TypeName = "decimal(1,1)")]
        public decimal TaxVatAmount { get; set; }
        [Column("TotalVAT", TypeName = "decimal(1,1)")]
        public decimal TotalVAT { get; set; }
        public string DebitTaxVATAccount { get; set; } = default!;
        public string CreditTaxVATAccount { get; set; } = default!;
        public string LotNumber { get; set; } = default!;
        public string ExpiredDate { get; set; } = default!;
        public string ImportID { get; set; } = default!;
        public string ExportID { get; set; } = default!;
        [Column("PriceOrg", TypeName = "decimal(22,8)")]
        public decimal? PriceOrg { get; set; }
        [Column("PriceVATOrg", TypeName = "decimal(22,8)")]
        public decimal? PriceVATOrg { get; set; }
        public string CostDebitAccount { get; set; } = default!;
        public string CostCreditAccount { get; set; } = default!;
        [Column("FeeAmount", TypeName = "decimal(1,1)")]
        public decimal FeeAmount { get; set; }
        [Column("FeeAmountVAT", TypeName = "decimal(1,1)")]
        public decimal FeeAmountVAT { get; set; }
        [Column("FeeTaxVatAmount", TypeName = "decimal(1,1)")]
        public decimal FeeTaxVatAmount { get; set; }
        [Column("DiscountRate", TypeName = "decimal(1,1)")]
        public decimal DiscountRate { get; set; }
        [Column("DiscountAmount", TypeName = "decimal(1,1)")]
        public decimal DiscountAmount { get; set; }
        public string DiscountName { get; set; } = default!;
        public string DiscountType { get; set; } = default!;
        [Column("OtherTaxRate", TypeName = "decimal(1,1)")]
        public decimal OtherTaxRate { get; set; }
        [Column("OtherTaxAmount", TypeName = "decimal(1,1)")]
        public decimal OtherTaxAmount { get; set; }
        public string OtherTaxName { get; set; } = default!;
        public string DebitAccount_OtherTaxAmount { get; set; } = default!;
        public string CreditAccount_OtherTaxAmount { get; set; } = default!;
        [Column("PromotionRate", TypeName = "decimal(1,1)")]
        public decimal PromotionRate { get; set; }
        [Column("PromotionAmount", TypeName = "decimal(1,1)")]
        public decimal PromotionAmount { get; set; }
        public string PromotionName { get; set; } = default!;
        public string PromotionType { get; set; } = default!;
        [Column("TransportAmount", TypeName = "decimal(1,1)")]
        public decimal TransportAmount { get; set; }
        public string TransporterID { get; set; } = default!;
        public string TransporterName { get; set; } = default!;
        public string DebitAccount_TransportAmount { get; set; } = default!;
        public string CreditAccount_TransportAmount { get; set; } = default!;
        [Column("TotalPriceOrg", TypeName = "decimal(1,1)")]
        public decimal TotalPriceOrg { get; set; }
        [Column("TotalPriceVATOrg", TypeName = "decimal(1,1)")]
        public decimal TotalPriceVATOrg { get; set; }
        [Column("ProfitPercent", TypeName = "decimal(1,1)")]
        public decimal ProfitPercent { get; set; }
        [Column("TotalProfit", TypeName = "decimal(1,1)")]
        public decimal TotalProfit { get; set; }
        public string PacketID { get; set; } = default!;
        public int QuantityPacket { get; set; }
        public int Accumulation { get; set; }
    }
}
