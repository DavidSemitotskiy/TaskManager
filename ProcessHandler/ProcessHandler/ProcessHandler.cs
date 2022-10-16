using System.Collections.Generic;
using System.Diagnostics;

namespace ProcessHandler
{
    public class ProcessHandler
    {
        public IEnumerable<Process> ActiveProcesses 
        {
            get => Process.GetProcesses();
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

        public ProcessThreadCollection GetThreads(Process process)
        {
            return process.Threads;
        }
    }
}
