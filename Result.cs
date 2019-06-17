using System.Collections.Generic;
using System.Diagnostics;

namespace ProcessKiller
{
    public class Result
    {
        public IList<Process> KilledProcesses = new List<Process>();
        public IList<Error> Errors = new List<Error>();
    }
}
