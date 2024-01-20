﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class CategoriesGetContractDetailByContractNumberResult
    {
        public Guid ContractID { get; set; }
        public string? ContractName { get; set; }
        public string? ZoneID { get; set; }
        public string? CustomBranchCode { get; set; }
        public string? ContractNumber { get; set; }
        public bool? ConTractType { get; set; }
        public int? ConTractGroupType { get; set; }
        public string? ContractSignDate { get; set; }
        public string? ContractExpiredDate { get; set; }
        public string? ExtentDate { get; set; }
        public int? ExtentNumberDay { get; set; }
        [Column("TotalContractAmount", TypeName = "decimal(22,8)")]
        public decimal? TotalContractAmount { get; set; }
        [Column("TotalContractAmountOC", TypeName = "decimal(22,8)")]
        public decimal? TotalContractAmountOC { get; set; }
        public string? CurrencyID { get; set; }
        public string CustomerID { get; set; } = default!;
        public string? AgentName { get; set; }
        public string? AgentPosition { get; set; }
        public string? ContractDetail { get; set; }
        public string? Status { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int? AppendixCount { get; set; }
        public Guid AppendixContractID { get; set; }
        public string? AppendixNumber { get; set; }
        public string? AppendixName { get; set; }
        public string? AppendixSignDate { get; set; }
        public string GoodID { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public string HSCode { get; set; } = default!;
        public string ItemtName { get; set; } = default!;
        [Column("Quantity", TypeName = "decimal(22,8)")]
        public decimal Quantity { get; set; }
        [Column("ImpPrice", TypeName = "decimal(22,8)")]
        public decimal ImpPrice { get; set; }
        [Column("ImpPriceOC", TypeName = "decimal(22,8)")]
        public decimal ImpPriceOC { get; set; }
        [Column("ImpPriceVAT", TypeName = "decimal(22,8)")]
        public decimal ImpPriceVAT { get; set; }
        [Column("ImpPriceVATOC", TypeName = "decimal(22,8)")]
        public decimal ImpPriceVATOC { get; set; }
        public string VatID { get; set; } = default!;
        [Column("TaxVatRate", TypeName = "decimal(22,8)")]
        public decimal TaxVatRate { get; set; }
        [Column("TaxVatAmount", TypeName = "decimal(22,8)")]
        public decimal TaxVatAmount { get; set; }
        [Column("TaxVatAmountOC", TypeName = "decimal(22,8)")]
        public decimal TaxVatAmountOC { get; set; }
        [Column("TotalAmount", TypeName = "decimal(22,8)")]
        public decimal TotalAmount { get; set; }
        [Column("TotalAmountOC", TypeName = "decimal(22,8)")]
        public decimal TotalAmountOC { get; set; }
        [Column("TotalAmountVAT", TypeName = "decimal(22,8)")]
        public decimal TotalAmountVAT { get; set; }
        [Column("TotalAmountVATOC", TypeName = "decimal(22,8)")]
        public decimal TotalAmountVATOC { get; set; }
        public string UnitID { get; set; } = default!;
        public string BigUnitID { get; set; } = default!;
        [Column("ExchangeRate", TypeName = "decimal(22,8)")]
        public decimal ExchangeRate { get; set; }
        public int ConvertNumber { get; set; }
        public string ContainNumber { get; set; } = default!;
        public string LocationInStock { get; set; } = default!;
        public int PackageQty { get; set; }
        public string BranchID { get; set; } = default!;
    }
}
