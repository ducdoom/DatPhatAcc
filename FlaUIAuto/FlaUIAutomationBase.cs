﻿namespace FlaUIAuto
{
    public abstract class FlaUIAutomationBase
    {
        public abstract string ProcessName { get; }

        public void Attach()
        {
            //find the process by name
            var process = System.Diagnostics.Process.GetProcessesByName(ProcessName).FirstOrDefault();
            if (process == null)
            {
                throw new System.Exception("Process not found");
            }
            //attach to the process
        }

    }
}