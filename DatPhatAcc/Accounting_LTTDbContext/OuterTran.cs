﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class OuterTran
{
    public string ExpTranId { get; set; }

    public string ImpTranId { get; set; }

    public string ImportId { get; set; }

    public string ExportId { get; set; }

    /// <summary>
    /// Trạng thái điều chuyển ngoài vùng (sang kho trung chuyển) 0: chưa nhận hàng; 1: đã nhận hàng
    /// </summary>
    public string TranStatus { get; set; }

    public string SyncTime { get; set; }
}