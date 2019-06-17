namespace ProcessKiller
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var argsInfo = new ArgumentsInfo(args);
            var printer = new Printer();

            if (!argsInfo.IsValid())
            {
                printer.PrintInvalidArguments();
            }

            var manager = new ProcessManager();
            var name = argsInfo.GetProcessName();
            var result = manager.KillProcesses(name);

            printer.PrintResult(result);
        }
    }
}
