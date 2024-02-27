using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.Console;
using Tasks.OperationImp;

namespace Tasks.ExecuteImp
{
    public class ExecuteOperationImp : IExecuteOperationImp
    {
		private IConsole console;
		private ITaskListData taskListData = new TaskListData();

		public ExecuteOperationImp(ref IConsole console)
        {
			this.console = console;
        }

		public void Show()
		{
			IOperationShow operationShow = new OperationShow(ref this.console, ref this.taskListData);
			operationShow.Show();
		}

		public void Add(string commandLine)
		{
			IOperationAdd operationAdd = new OperationAdd(this.console, this.taskListData);
			operationAdd.Add(commandLine);
		}

		public void Check(string idString)
		{
			IOperationDoCheck operationDoCheck = new OperationDoCheck(this.console, this.taskListData);
			operationDoCheck.SetDone(idString, true);
		}

		public void Uncheck(string idString)
		{
			IOperationDoCheck operationDoCheck = new OperationDoCheck(this.console, this.taskListData);
			operationDoCheck.SetDone(idString, false);
		}

		public void Help()
		{
			IOperationHelp operationHelp = new OperationHelp(this.console);
			operationHelp.Help();
		}

		public void Error(string command)
		{
			IOperationError operationError = new OperationError(this.console);
			operationError.Error(command);
		}
	}
}
