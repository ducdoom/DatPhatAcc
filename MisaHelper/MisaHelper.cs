using OfficeOpenXml;

namespace MisaHelper
{
    public class MisaHelper
    {
        public MisaHelper()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public Purchase Purchase { get; set; } = new();

        public ImportExcel ImportExcel { get; set; } = new();
    }
}
