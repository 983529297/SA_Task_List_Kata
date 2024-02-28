using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Console;

namespace Tasks.OperationImp
{
    public class OperationError : IOperationError
    {
        private readonly IConsole console;

        public OperationError(IConsole console)
        {
            this.console = console;
        }

        public IList<string> Error(String command)
        {
            return new List<string> { string.Format("I don't know what the command \"{0}\" is.", command) };
        }
    }
}
