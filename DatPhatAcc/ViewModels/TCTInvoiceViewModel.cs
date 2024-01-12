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
        }

        #region Properties
        [ObservableProperty]
        private ObservableCollection<Invoice> invoices = new();


        #endregion

        #region Commands
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
                var a = await excelHelper.ReadExcelFile(file);
                if (!a.Any())
                {
                    MessageBox.Show(Application.Current.MainWindow, $"Không đọc được dữ liệu trong file {file}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                invoices.AddRange(a);
            }

            List<Task> tasks = new();
            foreach (var invoice in invoices)
            {
                Task t = misaService.CheckInvoice(invoice);
                tasks.Add(t);
                Debug.WriteLine($"Task added: {t.Id}");
            }

            await Task.WhenAll(tasks);
            Invoices = new(invoices);

            MessageBox.Show(Application.Current.MainWindow, $"Đọc dữ liệu thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

        }


        #endregion

    }
}
