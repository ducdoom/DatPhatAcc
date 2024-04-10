using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatPhatAcc.Models;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace DatPhatAcc.ViewModels
{
    public partial class CreateSaleInvoiceViewModel : ObservableObject
    {
        private Services.AccountingService accountingService;
        public CreateSaleInvoiceViewModel(Services.AccountingService accountingService)
        {
            this.accountingService = accountingService;
        }

        [ObservableProperty]
        private ObservableCollection<Models.HHDVu> hHDVuList = new();

        [RelayCommand]
        private async Task LoadXmlFile()
        {
            // display open file dialog to select xml file, single option
            OpenFileDialog openFileDialog = new()
            {
                Filter = "XML files (*.xml)|*.xml"
            };

            if (openFileDialog.ShowDialog() != true)
            {
                return;
            }

            // read xml file
            string xmlFilePath = openFileDialog.FileName;
            string xmlContent = await File.ReadAllTextAsync(xmlFilePath);

            // parse xml content into object
            XmlSerializer serializer = new(typeof(HDon));
            using StringReader reader = new(xmlContent);
            using XmlReader xmlReader = XmlReader.Create(reader);

            HDon hDon = null;
            try
            {
                hDon = (HDon)serializer.Deserialize(xmlReader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            //check null
            if (hDon is null)
            {
                MessageBox.Show("File không đúng định dạng");
                return;
            }

            var a = new List<HHDVu>(hDon.DLHDon.NDHDon.DSHHDVu.HHDVu);






        }
    }
}
