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
            //IList<string> showString = new List<string>();
            //foreach (var project in deadlineTasks)
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
            ////
            return showOutputDto;
        }
    }
}
