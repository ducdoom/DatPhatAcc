﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class SystemStockStockinfo_ducResult
    {
        public string StockID { get; set; } = default!;
        public string GoodID { get; set; } = default!;
        public int? EndQty { get; set; }
        [Column("SumExpQty", TypeName = "decimal(18,6)")]
        public decimal? SumExpQty { get; set; }
        [Column("AvailableEndQty", TypeName = "decimal(38,6)")]
        public decimal? AvailableEndQty { get; set; }
    }
}
