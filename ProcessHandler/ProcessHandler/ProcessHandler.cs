using System.Collections.Generic;
using System.Diagnostics;

namespace ProcessHandler
{
    public class ProcessHandler
    {
        private IReadOnlyCollection<Process> ActiveProcesses 
        {
            get => Process.GetProcesses();
        }
    }
}
