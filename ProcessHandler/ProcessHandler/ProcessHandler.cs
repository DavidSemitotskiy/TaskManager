using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;

namespace ProcessHandler
{
    public class ProcessHandler
    {
        public IEnumerable<Process> ActiveProcesses 
        {
            get => Process.GetProcesses();
        }

        public Process GetProcessById(int id)
        {
            return Process.GetProcessById(id);
        }

        public int GetUsedMemory(Process process)
        {
            return process.WorkingSet / (1000 * 1000); ;
        }

        public void KillProcess(Process process)
        {
            process.Kill();
            process.WaitForExit();
        }

        public int GetParentProcessId(Process process)
        {
            int parentId = 0;
            try
            {
                ManagementObject mo = new ManagementObject($"win32_process.handle='{process.Id}'");
                mo.Get();
                parentId = Convert.ToInt32(mo["ParentProcessId"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                parentId = 0;
            }

            return parentId;
        }

        public void KillChildrenProc(int parentId)
        {
            if (parentId == 0)
            {
                return;
            }

            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                ($"Select * From Win32_Process Where ParentProcessID={parentId}");

            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillChildrenProc(Convert.ToInt32(mo["ProcessID"]));
            }

            try
            {
                Process proc = Process.GetProcessById(parentId);
                KillProcess(proc);
            }
            catch (ArgumentException)
            {
                
            }
        }

        public ProcessThreadCollection GetThreads(Process process)
        {
            return process.Threads;
        }
    }
}
