using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Helpers;
using DatPhatAcc.Models;
using DatPhatAcc.Services;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace DatPhatAcc.ViewModels
{
    public partial class TCTInvoiceViewModel : ObservableObject
    {
        private readonly ExcelHelper excelHelper;
        private readonly MisaService misaService;
        public TCTInvoiceViewModel(ExcelHelper excelHelper, MisaService misaService)
        {
            this.excelHelper = excelHelper;
            this.misaService = misaService;
            LoadExplainNote();
        }

        #region Properties
        [ObservableProperty]
        private ObservableCollection<Invoice> invoices = new();

        [ObservableProperty]
        private string explainNote = string.Empty;


        #endregion

        #region Commands
        private void LoadExplainNote()
        {
            string ExplainNoteTextFile = "Resources\\Txt\\TCTExplainNote.txt";
            ExplainNote = System.IO.File.ReadAllText(ExplainNoteTextFile);
        }

        [RelayCommand]
        private async Task ReadExcelFiles()
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                Title = "Chọn một hoặc nhiều file",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == false)
            {
                return;
            }

            string[] fileNames = openFileDialog.FileNames;
            List<Invoice> invoices = new();
            Invoices.Clear();
            foreach (string file in fileNames)
            {
                var invoiceList = await excelHelper.ReadExcelFile(file);
                if (!invoiceList.Any())
                {
                    MessageBox.Show(Application.Current.MainWindow, $"Không đọc được dữ liệu trong file {file}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                invoices.AddRange(invoiceList);
            }

            List<Task> tasks = new();
            foreach (var invoice in invoices)
            {
                //Task t = Task.Run(() => misaService.CheckInvoice(invoice));
                await misaService.CheckInvoice(invoice);
                //tasks.Add(t);
                //Debug.WriteLine($"Task added: {t.Id}");
            }

            //await Task.WhenAll(tasks);

            await misaService.AddMoreInvoiceThatDoesNotExistInTCT(invoices);

            Invoices = new(invoices);

            MessageBox.Show(Application.Current.MainWindow, $"Đọc dữ liệu thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

        }


        #endregion

    }
}
