using System.Diagnostics;
using static System.Console;

namespace ProcessKiller
{
    public class Printer
    {
        public void PrintInvalidArguments()
        {
            WriteLine("Invalid number of arguments");
        }

        public void PrintResult(Result result)
        {
            foreach (var error in result.Errors)
            {
                WriteLine($"Failed to kill process {ToString(error.Process)}: {error.Exception.Message}");
            }

            WriteLine("Killed processes:");

            foreach (var process in result.KilledProcesses)
            {
                WriteLine($"{ToString(process)}");
            }

            WriteLine($"Total killed processes: {result.KilledProcesses.Count}");
        }

        public string ToString(Process p)
        {
            return $"{p.ProcessName} ({p.Id})";
        }
    }
}
