﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class ThirdPartyServiceConfig
{
    public string ServiceCode { get; set; }

    public Guid BranchId { get; set; }

    public int? BranchType { get; set; }

    public string Config { get; set; }

    public string OptionValue { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string PartnerCode { get; set; }

    public bool? IsActive { get; set; }
}