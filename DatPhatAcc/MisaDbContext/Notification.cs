﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Notification
{
    public Guid NotificationId { get; set; }

    public Guid? RefId { get; set; }

    public string? RefNo { get; set; }

    public int? RefType { get; set; }

    public string? UserName { get; set; }

    public DateTime? RefDate { get; set; }

    public string? Description { get; set; }

    public int? NotificationType { get; set; }

    public Guid? BranchId { get; set; }

    public int? DisplayOnBook { get; set; }

    public string? UserHasVisited { get; set; }

    public string? NotificationIsmacId { get; set; }

    public string? Title { get; set; }

    public string? SubContent { get; set; }

    public string? ThumbnailsImage { get; set; }

    public int? SubNotificationType { get; set; }
}