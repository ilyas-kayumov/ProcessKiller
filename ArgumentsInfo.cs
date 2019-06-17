namespace ProcessKiller
{
    public class ArgumentsInfo
    {
        private readonly string[] args;

        public ArgumentsInfo(string[] args)
        {
            this.args = args;
        }

        public bool IsValid()
        {
            return args.Length != 0;
        }

        public string GetProcessName()
        {
            return args[0];
        }
    }
}
