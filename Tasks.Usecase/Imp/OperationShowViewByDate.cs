using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
    public class OperationShowViewByDate : OperationBase, IOperationShow, IOperation<ShowOutputDto, EmptyInputDto>
    {
        public ShowOutputDto ExecuteOperation(EmptyInputDto emptyInputDto = null)
        {
            IDictionary<string, IList<TaskListViewByDateArg>> todayTasks = taskListData.GetTaskListOrderByDate();
            ShowOutputDto showOutputDto = new ShowOutputDto();
            foreach (var todayTaskList in todayTasks)
            {
                foreach (var task in todayTaskList.Value)
                {
                    string deadline = todayTaskList.Key;
                    if (!showOutputDto.TaskListWithOrder.ContainsKey(deadline))
                    {
                        showOutputDto.TaskListWithOrder[deadline] = new List<ShowOutputArg>();
                    }
                    showOutputDto.TaskListWithOrder[deadline].Add(new ShowOutputArg { Done = task.Done, Id = task.Id, Description = task.Description });
                }
            }
            return showOutputDto;
        }

        public ShowOutputDto Show()
        {
            IDictionary<string, IList<TaskListViewByDateArg>> todayTasks = taskListData.GetTaskListOrderByDate();
            ShowOutputDto showOutputDto = new ShowOutputDto();
            foreach (var todayTaskList in todayTasks)
            {
                foreach (var task in todayTaskList.Value)
                {
                    string deadline = todayTaskList.Key;
                    if (!showOutputDto.TaskListWithOrder.ContainsKey(deadline))
                    {
                        showOutputDto.TaskListWithOrder[deadline] = new List<ShowOutputArg>();
                    }
                    showOutputDto.TaskListWithOrder[deadline].Add(new ShowOutputArg { Done = task.Done, Id = task.Id, Description = task.Description });
                }
            }
            return showOutputDto;
        }
    }
}
