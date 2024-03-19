using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.ExecuteOperationImp.Imp;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.ExecuteOperationImp
{
    public class OperationShowViewByDeadline : OperationBase, IOperationShow
    {
        public ShowOutputDto Show()
        {
            IDictionary<string, IList<TaskListViewByDeadlineArg>> deadlineTasks = taskListData.GetTaskListOrderByDeadline();
            ShowOutputDto showOutputDto = new ShowOutputDto();
            foreach (var deadlineTaskList in deadlineTasks)
            {
                foreach (var task in deadlineTaskList.Value)
                {
                    string deadline = deadlineTaskList.Key;
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
