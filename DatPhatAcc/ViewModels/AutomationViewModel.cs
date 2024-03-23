using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.UIA2;
using System.Diagnostics;

namespace DatPhatAcc.ViewModels
{
    public partial class AutomationViewModel : ObservableObject
    {
        public AutomationViewModel()
        {

        }

        [RelayCommand]
        private async Task RunAutomation()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "C:\\Users\\ducdo\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Thinh\\Thinh\\Thanh Cong Accounting.appref-ms";
            processStartInfo.UseShellExecute = true;
            //Process.Start(processStartInfo);

            
            await Task.Delay(5000);

            var app = FlaUI.Core.Application.Attach(processStartInfo);
            var mainWindow = app.GetMainWindow(new FlaUI.UIA2.UIA2Automation());

            ConditionFactory cf = new ConditionFactory(new UIA2PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtUserName")).AsTextBox().Enter("PTBICH");
            mainWindow.FindFirstDescendant(cf.ByAutomationId("cboZone")).AsComboBox().Select(2);
            mainWindow.FindFirstDescendant(cf.ByAutomationId("btnLogin")).AsButton().Click();
        }
    }
}
