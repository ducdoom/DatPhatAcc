using DatPhatAcc.Models;
using Microsoft.Win32;
using OfficeOpenXml;

namespace DatPhatAcc.Helpers
{
    public class Ihoadon
    {
        public async Task<bool> CreateImportExcel(IEnumerable<SaleLedgerDetail> saleLedgerDetails)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FileName = $"{saleLedgerDetails.First().InvNo}.xlsx"
            };

            if (saveFileDialog.ShowDialog() == false)
            {
                return false;
            }

            ExcelPackage fileExcel = CreateWorksheet(saleLedgerDetails);
            await fileExcel.SaveAsAsync(saveFileDialog.FileName).ConfigureAwait(false);

            return true;
        }

        private ExcelPackage CreateWorksheet(IEnumerable<SaleLedgerDetail> saleLedgerDetails)
        {
            ExcelPackage excelPackage = new();
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Bang_ke_hang_hoa_dich_vu");
            /*
             * view_order	management_code	product_code	product_name	is_promotion	is_promotion_new	lot	expiration_date	contract_order	unit_name	product_exchange_rate	product_date	quantity	price	amount	vat_name	amount_vat	other_tax	other_charge	engine_number	chassis_number	is_money_service	is_refund_ticket
             */

            #region Header
            worksheet.Cells["A10"].Value = "view_order";
            worksheet.Cells["B10"].Value = "management_code";
            worksheet.Cells["C10"].Value = "product_code";
            worksheet.Cells["D10"].Value = "product_name";
            worksheet.Cells["E10"].Value = "is_promotion";
            worksheet.Cells["F10"].Value = "is_promotion_new";
            worksheet.Cells["G10"].Value = "lot";
            worksheet.Cells["H10"].Value = "expiration_date";
            worksheet.Cells["I10"].Value = "contract_order";
            worksheet.Cells["J10"].Value = "unit_name";
            worksheet.Cells["K10"].Value = "product_exchange_rate";
            worksheet.Cells["L10"].Value = "product_date";
            worksheet.Cells["M10"].Value = "quantity";
            worksheet.Cells["N10"].Value = "price";
            worksheet.Cells["O10"].Value = "amount";
            worksheet.Cells["P10"].Value = "vat_name";
            worksheet.Cells["Q10"].Value = "amount_vat";
            worksheet.Cells["R10"].Value = "other_tax";
            worksheet.Cells["S10"].Value = "other_charge";
            worksheet.Cells["T10"].Value = "engine_number";
            worksheet.Cells["U10"].Value = "chassis_number";
            worksheet.Cells["V10"].Value = "is_money_service";
            worksheet.Cells["W10"].Value = "is_refund_ticket";
            #endregion

            int startRow = 11;
            int viewOrder = 1;

            foreach (SaleLedgerDetail item in saleLedgerDetails)
            {
                worksheet.Cells[$"A{startRow}"].Value = viewOrder;
                worksheet.Cells[$"C{startRow}"].Value = item.InventoryItemCode;
                worksheet.Cells[$"D{startRow}"].Value = item.InventoryItemName;
                worksheet.Cells[$"J{startRow}"].Value = item.UnitName;
                worksheet.Cells[$"M{startRow}"].Value = item.SaleQuantity;
                worksheet.Cells[$"N{startRow}"].Value = item.UnitPrice;
                worksheet.Cells[$"O{startRow}"].Value = item.SaleAmount;
                worksheet.Cells[$"P{startRow}"].Value = item.VatName;
                worksheet.Cells[$"Q{startRow}"].Value = item.Vatamount;

                startRow++;
                viewOrder++;
            }

            return excelPackage;
        }
    }
}
