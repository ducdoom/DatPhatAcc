﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Relationship
{
    public Guid RelationshipId { get; set; }

    public string RelationshipName { get; set; } = null!;

    public bool IsSystem { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? DictionaryKey { get; set; }

    public int SortOrder { get; set; }

    public int? GroupId { get; set; }
}