﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

/// <summary>
/// BÁO CÁO TỔNG HỢP TÌNH HÌNH CHO THÀNH VIÊN VAY VỐN CỦA HTX và BÁO CÁO TÌNH HÌNH TĂNG, GIẢM VỐN CHỦ SỞ HỮU CỦA HỢP TÁC XÃ
/// 
/// </summary>
public partial class Frf04situationOfCooperativeMember
{
    public Guid ItemId { get; set; }

    public int? ItemIndex { get; set; }

    public string ItemCode { get; set; }

    public string ItemName { get; set; }

    public string ItemNameEnglish { get; set; }

    public bool? IsBold { get; set; }

    public bool? IsItalic { get; set; }

    public bool? Hidden { get; set; }

    public string Description { get; set; }

    public int? FormulaType { get; set; }

    public string Formula { get; set; }

    /// <summary>
    /// Tổng số/Đầu năm (F02)
    /// </summary>
    public string Total { get; set; }

    /// <summary>
    /// Trồng trọt/Tăng trong năm (F02)
    /// </summary>
    public string Cropt { get; set; }

    /// <summary>
    /// Chăn nuôi gia súc/Số giảm trong năm (F02)
    /// </summary>
    public string Breed { get; set; }

    /// <summary>
    /// Chế biến/Cuối năm (F02)
    /// </summary>
    public string Processing { get; set; }

    /// <summary>
    /// Thủ công
    /// </summary>
    public string Handmade { get; set; }

    /// <summary>
    /// Khác
    /// </summary>
    public string Other { get; set; }

    /// <summary>
    /// Chăn nuôi gia cầm
    /// </summary>
    public string BreedPoulty { get; set; }

    /// <summary>
    /// Kinh doanh
    /// </summary>
    public string Bussiness { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string ModifiedBy { get; set; }

    public int? AccountingSystem { get; set; }

    public string ReportId { get; set; }

    public string ItemNameChinese { get; set; }

    public string ItemNameKorean { get; set; }
}