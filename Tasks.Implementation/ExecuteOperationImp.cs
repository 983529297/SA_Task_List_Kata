using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.Console;

namespace Tasks.Implementation
{
    public class ExecuteOperationImp : IExecuteOperationImp
    {
		private IConsole console;
		private ITaskListData taskListData;
		public ExecuteOperationImp(ref IConsole console, ref ITaskListData taskListData)
        {
			this.console = console;
			this.taskListData = taskListData;
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
			SetDone(idString, true);
		}

		public void Uncheck(string idString)
		{
			SetDone(idString, false);
		}

		private void SetDone(string idString, bool done)
		{
			int id = int.Parse(idString);
			taskListData.findTaskById(id, out Tasks.Data.Task identifiedTask); ;
			if (identifiedTask == null)
			{
				console.WriteLine("Could not find a task with an ID of {0}.", id);
				return;
			}

			taskListData.SetDone(done, ref identifiedTask);
		}

		public void Help()
		{
			console.WriteLine("Commands:");
			console.WriteLine("  show");
			console.WriteLine("  add project <project name>");
			console.WriteLine("  add task <project name> <task description>");
			console.WriteLine("  check <task ID>");
			console.WriteLine("  uncheck <task ID>");
			console.WriteLine();
		}

		public void Error(string command)
		{
			console.WriteLine("I don't know what the command \"{0}\" is.", command);
		}
	}
}
