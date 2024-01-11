using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Helpers;
using DatPhatAcc.MisaDbContext;
using DatPhatAcc.Models;
using Microsoft.Win32;
using System.Collections.ObjectModel;

namespace DatPhatAcc.ViewModels
{
    public partial class TCTInvoiceViewModel : ObservableObject
    {
        private readonly ExcelHelper excelHelper;
        public TCTInvoiceViewModel(ExcelHelper excelHelper)
        {
            this.excelHelper = excelHelper;
        }

        #region Properties
        [ObservableProperty]
        private ObservableCollection<Invoice> invoices = new();


        #endregion

        #region Commands
        [RelayCommand]
        private async Task ReadExcelFiles()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Select an Excel File";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == false)
            {
                return;
            }

            string[] fileNames = openFileDialog.FileNames;
            List<Invoice> invoices = new();
            foreach (string file in fileNames)
            {
                var a = await excelHelper.ReadExcelFile(file);
                invoices.AddRange(a);
            }

            Invoices = new(invoices);

        }


        #endregion

    }
}
