using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Helpers
{
    public  static class ExcelPlusExtension
    {
        public static Dictionary<string, int> CreateHeaderDictionary(this ExcelWorksheet worksheet, int rowIndex)
        {
            Dictionary<string, int> headerDictionary = new();

            int lastColumn = worksheet.Dimension.End.Column;

            for (int columnNumber = 1; columnNumber <= lastColumn; columnNumber++)
            {
                string header = worksheet.Cells[rowIndex, columnNumber].GetValue<string>() ?? string.Empty;

                if (string.IsNullOrEmpty(header))
                {
                    continue;
                }

                //check if header is already in dictionary
                if (headerDictionary.ContainsKey(header))
                {
                    throw new Exception("Header is duplicated");
                }
                else
                {
                    headerDictionary.Add(header, columnNumber);
                }
            }
           
            return headerDictionary;
        }
    }
}
