namespace FlaUIAutomation
{
    public abstract class FlaUIAutomationBase
    {
        public abstract string ProcessName { get; }

        public void Attach()
        {
            //get process by name
            var process = System.Diagnostics.Process.GetProcessesByName(ProcessName).FirstOrDefault();
            if (process == null)
            {
                throw new System.Exception($"Process {ProcessName} not found");
            }
           
            FlaUI.Core.Application.Attach(process.Id);
        }
    }
}
