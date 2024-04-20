using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Entity;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
    public class OperationShow : OperationBase, IOperation<ShowOutputDto, ShowInputDto>
    {
        public ShowOutputDto ExecuteOperation(ShowInputDto showInputDto)
        {
            IDictionary<string, IList<ReadonlyTask>> Tasks = taskListData.GetTaskList();
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
                    showOutputDto.TaskListWithOrder[projectName].Add(new ShowOutputArg { Done = task.GetDone(), Id = ((int)task.GetID()), Description = task.GetDescription(), Deadline = task.GetDeadline() });
                }
            }
            return showOutputDto;
        }
    }
}
