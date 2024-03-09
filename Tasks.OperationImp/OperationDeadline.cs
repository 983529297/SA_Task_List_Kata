using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationDeadline : OperationBase, IOperateAndEnd
    {
        private readonly string commandLine;

        public OperationDeadline(string commandLine)
        {
            this.commandLine = commandLine;
        }

        public void OperateAndEnd()
        {
            Deadline(commandLine);
        }

        private void Deadline(string commandLine)
        {
            var subcommandRest = commandLine.Split(" ".ToCharArray(), 2);
            var idString = subcommandRest[0];
            var deadlineString = subcommandRest[1];
            int id = int.Parse(idString);
            DateTime deadline = DateTime.Parse(deadlineString);
            taskListData.SetDeadline(id, deadline);
        }
    }
}
