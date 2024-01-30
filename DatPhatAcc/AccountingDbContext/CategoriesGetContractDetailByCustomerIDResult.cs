﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class CategoriesGetContractDetailByCustomerIDResult
    {
        public Guid ContractID { get; set; }
        public string? ContractName { get; set; }
        public string? ContractNumber { get; set; }
        [Column("TotalContractAmount", TypeName = "decimal(22,8)")]
        public decimal? TotalContractAmount { get; set; }
        public string CustomerID { get; set; } = default!;
        public string? AgentName { get; set; }
        public string? AgentPosition { get; set; }
        public DateTime? ContractSignDate { get; set; }
        public DateTime? ContractExpiredDate { get; set; }
        public Guid AppendixContractID { get; set; }
        public string? AppendixNumber { get; set; }
        public string? AppendixName { get; set; }
        public string? AppendixSignDate { get; set; }
        public string? AppendixExpiredDate { get; set; }
        public string? ExtentDate { get; set; }
        public int? ExtentNumberDay { get; set; }
        [Column("TotalAppendixAmount", TypeName = "decimal(22,8)")]
        public decimal? TotalAppendixAmount { get; set; }
        [Column("TotalAppendixAmountOC", TypeName = "decimal(22,8)")]
        public decimal? TotalAppendixAmountOC { get; set; }
        public int? AppendixDebtDay { get; set; }
        [Column("AppendixDebtLimit", TypeName = "decimal(18,6)")]
        public decimal? AppendixDebtLimit { get; set; }
        [Column("AppendixDebtLimitOC", TypeName = "decimal(18,6)")]
        public decimal? AppendixDebtLimitOC { get; set; }
        public string? AppendixDetail { get; set; }
        public bool? EnableSchedule { get; set; }
        public string? ScheduleType { get; set; }
        public string? ScheduleValue { get; set; }
        public string? AppendixStatus { get; set; }
    }
}