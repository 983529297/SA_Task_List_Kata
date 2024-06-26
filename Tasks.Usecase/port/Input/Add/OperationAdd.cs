﻿using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Entity;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
	public class OperationAdd : OperationBase, IOperation<VoidOutputDto, AddInputDto>
    {
        public OperationAdd(IProjectListRepository projectListRepository)
        {
            this.projectListRepository = projectListRepository;
        }

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
            projectListRepository.FindByID().AddProject(name);
		}

		private void AddTask(string project, string description)
		{
            projectListRepository.FindByID().AddTask(project, description);
		}
	}
}
