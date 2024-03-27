using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
	public class OperationAdd : OperationBase, IOperation<VoidOutputDto, AddInputDto>
    {
        public VoidOutputDto ExecuteOperation(AddInputDto addInputDto)
        {
            if (addInputDto.Mode == "project")
            {
                AddProject(addInputDto.ProjectName);
            }
            else if (addInputDto.Mode == "task")
            {
                AddTask(addInputDto.ProjectName, addInputDto.Description);
            }

            return new VoidOutputDto();
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
