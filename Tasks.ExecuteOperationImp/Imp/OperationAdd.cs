using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.ExecuteOperationImp
{
    public class OperationAdd : OperationBase, IOperateAndEnd
    {
		private readonly string commandLine;
		
		public OperationAdd(string commandLine)
        {
			this.commandLine = commandLine;
        }

		public void OperateAndEnd()
        {
			Add(commandLine);
        }

		private void Add(string commandLine)
        {
			var subcommandRest = commandLine.Split(" ".ToCharArray(), 2);
			var subcommand = subcommandRest[0];
			if (subcommand == "project")
			{
				AddProject(subcommandRest[1]);
			}
			else if (subcommand == "task")
			{
				var projectTask = subcommandRest[1].Split(" ".ToCharArray(), 2);
				AddTask(projectTask[0], projectTask[1]);
			}
		}

		private void AddProject(string name)
		{
			taskListData.AddProject(name);
		}

		private void AddTask(string project, string description)
		{
			if (!taskListData.CheckProject(project))
			{
				throw new Exception(string.Format("Could not find a project with the name \"{0}\".", project));
			}
			taskListData.AddTask(project, description);
		}
	}
}
