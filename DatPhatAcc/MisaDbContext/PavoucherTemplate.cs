﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DatPhatAcc.MisaDbContext;

public partial class PavoucherTemplate
{
    public Guid TemplateId { get; set; }

    public int? TaxHoldingConfigId { get; set; }

    /// <summary>
    /// ID chi nhánh đơn vị
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// ID công ty
    /// </summary>
    public Guid? TenantId { get; set; }

    /// <summary>
    /// Thông tin chi nhánh đơn vị
    /// </summary>
    public string OrganizationJson { get; set; }

    /// <summary>
    /// Năm
    /// </summary>
    public int? Year { get; set; }

    /// <summary>
    /// Mã số
    /// </summary>
    public string FormNo { get; set; }

    /// <summary>
    /// Kiểu mẫu số
    /// </summary>
    public string OrganizationSymbol { get; set; }

    /// <summary>
    /// Kiểu văn bản mẫu số
    /// </summary>
    public string DocumentSymbol { get; set; }

    /// <summary>
    /// Kí hiệu
    /// </summary>
    public string SerialNo { get; set; }

    /// <summary>
    /// Số
    /// </summary>
    public string No { get; set; }

    /// <summary>
    /// Trạng thái của chứng từ 0: Chưa phát hành, 1: Đã phát hành, 2: Ngừng phát hành
    /// </summary>
    public int? TaxHoldingStatus { get; set; }

    /// <summary>
    /// Người tạo
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Ngày tạo
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Người sửa
    /// </summary>
    public string ModifiedBy { get; set; }

    /// <summary>
    /// Ngày sửa
    /// </summary>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Biến lưu config xem hiển thị tên hay logo hoặc cả 2 -- 1 là chỉ hiện tên, 2 là chỉ hiện logo, 0 là hiện cả 2
    /// </summary>
    public int? TaxHoldingLogoConfig { get; set; }

    /// <summary>
    /// Vị trí logo 1:trên, 2: dưới,3:trái, 4:phải
    /// </summary>
    public int? TaxHoldingLogoPositionConfig { get; set; }

    /// <summary>
    /// Loại mẫu 1-theo tt 37, 2 - theo tt 78
    /// </summary>
    public int? TaxHoldingConfigType { get; set; }

    /// <summary>
    /// Thông tin thêm
    /// </summary>
    public string TaxHoldingMoreInfor { get; set; }

    /// <summary>
    /// Tên đơn bị trên logo
    /// </summary>
    public string ReplaceOrgName { get; set; }

    /// <summary>
    /// Tên mẫu
    /// </summary>
    public string TemplateName { get; set; }

    /// <summary>
    /// Tên file mẫu
    /// </summary>
    public string TemplateFileName { get; set; }

    /// <summary>
    /// Là mẫu custom hay mẫu mặc địch
    /// </summary>
    public bool? IsCustomTemplate { get; set; }

    /// <summary>
    /// Tên file mặc định lấy ở folder default
    /// </summary>
    public string FileNameDefault { get; set; }

    /// <summary>
    /// Khổ giấy (A4, A5, nằm dọc, nằm ngang)
    /// </summary>
    public int? TypePaper { get; set; }

    public string OrganizationLogo { get; set; }

    public string BackgroundColor { get; set; }

    public string BackgroundCode { get; set; }

    public string ImageCode { get; set; }

    public string ImageColor { get; set; }

    public int? ImageType { get; set; }
}