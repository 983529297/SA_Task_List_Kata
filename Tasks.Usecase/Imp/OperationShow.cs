﻿using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.ExecuteOperationImp.Imp;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.ExecuteOperationImp
{
    public class OperationShow : OperationBase, IOperationShow
    {
        public ShowOutputDto Show()
        {
            IDictionary<string, IList<TaskListArg>> Tasks = taskListData.GetTaskList();
            ShowOutputDto showOutputDto = new ShowOutputDto();
            foreach (var TaskList in Tasks)
            {
                foreach (var task in TaskList.Value)
                {
                    string projectName = TaskList.Key;
                    if (!showOutputDto.TaskListWithOrder.ContainsKey(projectName))
                    {
                        showOutputDto.TaskListWithOrder[projectName] = new List<ShowOutputArg>();
                    }
                    showOutputDto.TaskListWithOrder[projectName].Add(new ShowOutputArg { Done = task.Done, Id = task.Id, Description = task.Description, Deadline = task.deadline });
                }
            }
            return showOutputDto;
        }
    }
}