using System;
using System.Diagnostics;
using System.Linq;

namespace ProcessKiller
{
    public class ProcessManager
    {
        public Result KillProcesses(string name)
        {
            var result = new Result();

            foreach (var p in Process.GetProcesses().Where(p => p.ProcessName.Contains(name)))
            {
                try
                {
                    p.Kill();
                    result.KilledProcesses.Add(p);
                }
                catch (Exception e)
                {
                    var error = new Error()
                    {
                        Exception = e,
                        Process = p
                    };

                    result.Errors.Add(error);
                }
            }

            return result;
        }
    }
}
