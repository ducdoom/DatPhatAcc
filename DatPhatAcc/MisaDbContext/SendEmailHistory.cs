﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class SendEmailHistory
{
    public Guid HistoryId { get; set; }

    public int SendStatus { get; set; }

    public DateTime SendTime { get; set; }

    public string? ReceiverName { get; set; }

    public string? ReceiverEmail { get; set; }

    public string? SenderName { get; set; }

    public string? SenderEmail { get; set; }

    public string? EmailSubject { get; set; }

    public int? Type { get; set; }

    public string? EmailTemplate { get; set; }

    public string? TempContent { get; set; }

    public Guid? UserId { get; set; }

    public Guid? BranchId { get; set; }

    public int? SendType { get; set; }

    public string? EmailName { get; set; }

    public string? VoucherNo { get; set; }

    public string? SubSystemCode { get; set; }
}