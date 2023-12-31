﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class InproductionOrderDetail
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid RefDetailId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public Guid ProductionId { get; set; }

    /// <summary>
    /// Mã nguyên vật liệu
    /// </summary>
    public Guid InventoryItemId { get; set; }

    /// <summary>
    /// Tên nguyên vật liệu
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// Số lượng NVL
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Đối tượng THCP
    /// </summary>
    public Guid? JobId { get; set; }

    /// <summary>
    /// Số thứ tự dòng
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// Số lượng NVL trên 1 đon vị SP
    /// </summary>
    public decimal QuantityOnUnit { get; set; }

    public Guid? ExpenseItemId { get; set; }

    /// <summary>
    /// Số đã xuất năm trước
    /// </summary>
    public decimal OutwardQuantityLastYear { get; set; }

    public Guid? ListItemId { get; set; }

    public string? CustomField1 { get; set; }

    public string? CustomField2 { get; set; }

    public string? CustomField3 { get; set; }

    public string? CustomField4 { get; set; }

    public string? CustomField5 { get; set; }

    public string? CustomField6 { get; set; }

    public string? CustomField7 { get; set; }

    public string? CustomField8 { get; set; }

    public string? CustomField9 { get; set; }

    public string? CustomField10 { get; set; }

    public virtual ExpenseItem? ExpenseItem { get; set; }

    public virtual InventoryItem InventoryItem { get; set; } = null!;

    public virtual Job? Job { get; set; }

    public virtual ListItem? ListItem { get; set; }

    public virtual InproductionOrderProduct Production { get; set; } = null!;

    public virtual Unit? Unit { get; set; }
}