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
            switch (showInputDto.Mode)
            {
                case "by project":
                    return Show();
                case "by deadline":
                    return ViewByDeadline();
                case "by date":
                    return ViewByDate();
                default:
                    throw new Exception("Could not find the command");
            }
        }

        private ShowOutputDto Show()
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

        private ShowOutputDto ViewByDate()
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

        private ShowOutputDto ViewByDeadline()
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
