﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace DatPhatAcc.AccountingDbContext
{
    public partial class SystemMenusgetMenusByUserIDMenuIDResult
    {
        public string MenuID { get; set; } = default!;
        public string? MenuName { get; set; }
        public string? Icon { get; set; }
        public string? PMenuID { get; set; }
        public int? Sort { get; set; }
        public string? Note { get; set; }
        public string? SyncTime { get; set; }
    }
}
