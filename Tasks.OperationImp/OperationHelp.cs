using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Console;

namespace Tasks.OperationImp
{
    public class OperationHelp : IOperationHelp
    {
        private readonly IConsole console;

        public OperationHelp(IConsole console)
        {
            this.console = console;
        }

        public IList<string> Help()
        {
            IList<string> helpString = new List<string> ();
            //console.WriteLine("Commands:");
            //console.WriteLine("  show");
            //console.WriteLine("  add project <project name>");
            //console.WriteLine("  add task <project name> <task description>");
            //console.WriteLine("  check <task ID>");
            //console.WriteLine("  uncheck <task ID>");
            //console.WriteLine();

            helpString.Add("Commands:");
            helpString.Add("  show");
            helpString.Add("  add project <project name>");
            helpString.Add("  add task <project name> <task description>");
            helpString.Add("  check <task ID>");
            helpString.Add("  uncheck <task ID>");
            helpString.Add("");

            return helpString;
        }
    }
}
