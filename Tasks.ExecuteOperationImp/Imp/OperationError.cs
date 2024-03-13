using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteOperationImp
{
    public class OperationError : OperationBase, IOperateAndReturn
    {
        private readonly string command;

        public OperationError(string command)
        {
            this.command = command;
        }

        public IList<string> OperateAndReturn()
        {
            return Error(command);
        }

        private IList<string> Error(string command)
        {
            return new List<string> { string.Format("I don't know what the command \"{0}\" is.", command) };
        }
    }
}
