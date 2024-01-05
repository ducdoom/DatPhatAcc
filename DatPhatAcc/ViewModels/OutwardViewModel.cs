using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Helpers;
using DatPhatAcc.Models;
using DatPhatAcc.Services;
using System.Collections.ObjectModel;
using System.Windows;

namespace DatPhatAcc.ViewModels
{
    public partial class OutwardViewModel : ObservableObject
    {
        private readonly MisaService misaService;
        private readonly Ihoadon Ihoadon;

        public OutwardViewModel(MisaService misaService, Ihoadon ihoadon)
        {
            this.misaService = misaService;
            Ihoadon = ihoadon;
        }

        #region Properties

        [ObservableProperty]
        private DateTime fromDate = DateTime.Now;
        [ObservableProperty]
        private DateTime toDate = DateTime.Now;

        [ObservableProperty]
        private ObservableCollection<MisaDbContext.SaleLedger> saleLedgersSummary = new();

        #endregion

        #region Commands

        [RelayCommand]
        private async Task SearchSaleLedger()
        {
            IEnumerable<MisaDbContext.SaleLedger> arr = await misaService.GetSaleLedgersSummary(FromDate, ToDate);
            SaleLedgersSummary = new ObservableCollection<MisaDbContext.SaleLedger>(arr);
        }

        [RelayCommand]
        private async Task ExportSaleLedgerToExcelIhoadon(MisaDbContext.SaleLedger saleLedgerSummary)
        {
            IEnumerable<SaleLedgerDetail> saleLedgerDetails = await misaService.GetSaleLedgersDetail(saleLedgerSummary.RefId);
            bool export = await Ihoadon.CreateImportExcel(saleLedgerDetails);

            if (export)
            {
                MessageBox.Show("Xuất file excel thành công","Thông báo");
            }
            else
            {
                //MessageBox.Show("Xuất file excel thất bại");
            }
        }

        #endregion
    }
}
