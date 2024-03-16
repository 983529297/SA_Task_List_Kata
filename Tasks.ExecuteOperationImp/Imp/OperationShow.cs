using System;
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
            //IList<string> showString = new List<string>();
            //foreach (var project in todayTasks)
            //{
            //    showString.Add(project.Key);
            //    foreach (var taskAttribute in project.Value)
            //    {
            //        showString.Add(string.Format("    [{0}] {1}: {2}{3}", taskAttribute.Done, taskAttribute.Id, taskAttribute.Description, taskAttribute.deadline == "" ? "" : " " + taskAttribute.deadline));
            //    }
            //    showString.Add("");
            //}
            ///
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
            ////
            return showOutputDto;
        }
    }
}
