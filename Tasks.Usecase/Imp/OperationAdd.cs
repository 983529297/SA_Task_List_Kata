using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase
{
    public class OperationAdd : OperationBase
    {
		public void Add(string mode, string projectName, string description = "")
        {
			if (mode == "project")
			{
				AddProject(projectName);
			}
			else if (mode == "task")
			{
				AddTask(projectName, description);
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
