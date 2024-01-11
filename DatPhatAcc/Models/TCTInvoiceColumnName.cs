using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Models
{
    public class TCTInvoiceColumnName
    {
        //STT	Ký hiệu mẫu số	Ký hiệu hóa đơn	Số hóa đơn	Ngày lập	MST người bán/MST người xuất hàng	Tên người bán/Tên người xuất hàng	Tổng tiền chưa thuế	Tổng tiền thuế	Tổng tiền chiết khấu thương mại	Tổng tiền phí	Tổng tiền thanh toán	Đơn vị tiền tệ	Trạng thái hóa đơn	Kết quả kiểm tra hóa đơn
        public const string STT = "STT";
        public const string InvoiceTemplateCode = "Ký hiệu mẫu số";
        public const string InvoiceCode = "Ký hiệu hóa đơn";
        public const string InvoiceNumber = "Số hóa đơn";
        public const string InvoiceDate = "Ngày lập";
        public const string SellerTaxCode = "MST người bán/MST người xuất hàng";
        public const string SellerName = "Tên người bán/Tên người xuất hàng";
        public const string TotalAmountWithoutTax = "Tổng tiền chưa thuế";
        public const string TotalTaxAmount = "Tổng tiền thuế";
        public const string TotalDiscountAmount = "Tổng tiền chiết khấu thương mại";
        public const string TotalFeeAmount = "Tổng tiền phí";
        public const string TotalAmount = "Tổng tiền thanh toán";
        public const string CurrencyUnit = "Đơn vị tiền tệ";
        public const string InvoiceStatus = "Trạng thái hóa đơn";
        public const string InvoiceCheckResult = "Kết quả kiểm tra hóa đơn";
    }
}
