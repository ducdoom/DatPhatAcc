﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class InvoiceTypeAutoId
{
    public Guid InvoiceTypeAutoId1 { get; set; }

    public string InvTemplateNo { get; set; }

    public string CurrentInvSerial { get; set; }

    public string CurrentInvNo { get; set; }

    public string LastInvSerial { get; set; }

    public string LastInvNo { get; set; }

    public Guid? BranchId { get; set; }

    public DateTime? InvDate { get; set; }

    public int? InvoiceCategory { get; set; }

    public DateTime? Lastest { get; set; }
}