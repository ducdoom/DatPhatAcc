﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.Accounting_LTTDbContext;

public partial class Packet
{
    public string PacketId { get; set; }

    public string ZoneId { get; set; }

    public string PacketName { get; set; }

    public decimal? TotalRetailPrice { get; set; }

    public decimal? TotalRetailPriceVat { get; set; }

    public decimal? TotalRetailDiscount { get; set; }

    public decimal? TotalWholesalePrice { get; set; }

    public decimal? TotalWholesalePriceVat { get; set; }

    public decimal? TotalWholesaleDiscount { get; set; }

    public string Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string CreatedBy { get; set; }

    public string UpdatedBy { get; set; }

    public string PacketType { get; set; }

    public string Status { get; set; }

    public string SynStatus { get; set; }

    public string SyncTime { get; set; }

    public virtual ICollection<PacketDetail> PacketDetails { get; set; } = new List<PacketDetail>();
}