﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class NotificationInbot
{
    public Guid NotificationInbotId { get; set; }

    public DateTime NotificationDate { get; set; }

    public string? Description { get; set; }

    public int NotificationType { get; set; }

    public string? UserHasVisited { get; set; }

    public string? Title { get; set; }

    public string? SubContent { get; set; }
}