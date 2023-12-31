﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class Jcopnconfig
{
    /// <summary>
    /// PK
    /// </summary>
    public Guid JcopnconfigId { get; set; }

    /// <summary>
    /// Chi tiết Đối tượng THCP theo yếu tố chi phí
    /// </summary>
    public bool IsDetailJobByExpense { get; set; }

    /// <summary>
    /// Chi tiết Công trình theo yếu tố chi phí
    /// </summary>
    public bool IsDetailProjectWorkByExpense { get; set; }

    /// <summary>
    /// Chi tiết Đơn hàng theo yếu tố chi phí
    /// </summary>
    public bool IsDetailOrderByExpense { get; set; }

    /// <summary>
    /// Chi tiết Hợp đồng theo yếu tố chi phí
    /// </summary>
    public bool IsDetailContractByExpense { get; set; }
}