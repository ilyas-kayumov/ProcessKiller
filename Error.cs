using System;
using System.Diagnostics;

namespace ProcessKiller
{
    public struct Error
    {
        public Exception Exception;
        public Process Process;
    }
}
