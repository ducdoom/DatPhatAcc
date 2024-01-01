﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// Bảng chi tiết hạch toán giá trị phân bổ
/// </summary>
public partial class SuallocationDetailPost
{
    public Guid RefDetailId { get; set; }

    public Guid RefId { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// TK chi phí
    /// </summary>
    public string? DebitAccount { get; set; }

    /// <summary>
    /// TK chờ phân bổ
    /// </summary>
    public string? CreditAccount { get; set; }

    /// <summary>
    /// Số tiền
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Đối tượng Nợ
    /// </summary>
    public Guid? DebitAccountObjectId { get; set; }

    /// <summary>
    /// Đối tượng Có
    /// </summary>
    public Guid? CreditAccountObjectId { get; set; }

    /// <summary>
    /// Đơn vị
    /// </summary>
    public Guid? OrganizationUnitId { get; set; }

    /// <summary>
    /// ĐT tập hợp chi phí
    /// </summary>
    public Guid? JobId { get; set; }

    /// <summary>
    /// Công trình/vụ việc
    /// </summary>
    public Guid? ProjectWorkId { get; set; }

    /// <summary>
    /// Đơn hàng
    /// </summary>
    public Guid? OrderId { get; set; }

    /// <summary>
    /// Hợp đồng
    /// </summary>
    public Guid? ContractId { get; set; }

    /// <summary>
    /// Chi phí không hợp lý
    /// </summary>
    public bool UnResonableCost { get; set; }

    /// <summary>
    /// Mã thống kê
    /// </summary>
    public Guid? ListItemId { get; set; }

    public Guid? ExpenseItemId { get; set; }

    /// <summary>
    /// Sắp xếp
    /// </summary>
    public int? SortOrder { get; set; }

    public virtual Contract? Contract { get; set; }

    public virtual Account? CreditAccountNavigation { get; set; }

    public virtual AccountObject? CreditAccountObject { get; set; }

    public virtual Account? DebitAccountNavigation { get; set; }

    public virtual AccountObject? DebitAccountObject { get; set; }

    public virtual ExpenseItem? ExpenseItem { get; set; }

    public virtual Job? Job { get; set; }

    public virtual ListItem? ListItem { get; set; }

    public virtual Saorder? Order { get; set; }

    public virtual OrganizationUnit? OrganizationUnit { get; set; }

    public virtual ProjectWork? ProjectWork { get; set; }

    public virtual Suallocation Ref { get; set; } = null!;
}