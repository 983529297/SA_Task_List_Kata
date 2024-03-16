using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.ExecuteOperationImp.Imp;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.ExecuteOperationImp
{
    public class OperationShowViewByDate : OperationBase, IOperationShow
    {
        public ShowOutputDto Show()
        {
            IDictionary<string, IList<TaskListViewByDateArg>> todayTasks = taskListData.GetTaskListOrderByDate();
            //IList<string> showString = new List<string>();
            //foreach (var project in todayTasks)
            //{
            //    showString.Add(project.Key);
            //    foreach (var taskAttribute in project.Value)
            //    {
            //        showString.Add(string.Format("    [{0}] {1}: {2}", taskAttribute.Done, taskAttribute.Id, taskAttribute.Description));
            //    }
            //    showString.Add("");
            //}
            ///
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
            ////
            return showOutputDto;
        }
    }
}
