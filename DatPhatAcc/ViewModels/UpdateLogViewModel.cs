using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.ViewModels
{
    public partial class UpdateLogViewModel: ObservableObject
    {
        public UpdateLogViewModel()
        {
            LoadUpdateLog();
        }

        [ObservableProperty]
        private string updateLogText = string.Empty;

        private void LoadUpdateLog()
        {
            string updateLogTextFile = "Resources\\Txt\\UpdateLog.txt";
            UpdateLogText = System.IO.File.ReadAllText(updateLogTextFile);
        }

    }
}
