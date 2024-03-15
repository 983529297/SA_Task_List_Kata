using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.ExecuteOperationImp
{
    public class OperationAdd : OperationBase, IOperateAndEnd
    {
		private readonly string mode;
		private readonly string projectName;
		private readonly string description;

		public OperationAdd(string mode, string projectName, string description = "")
        {
            this.mode = mode;
			this.projectName = projectName;
			this.description = description;
        }

        public void OperateAndEnd()
        {
			Add(mode, projectName, description);
        }

		private void Add(string mode, string projectName, string description = "")
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
