using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationShowViewByDeadline : IOperationShow
    {
        private readonly ITaskListData taskListData = TaskListData.Instance;

        public IList<string> Show()
        {
            IDictionary<string, IList<TaskListViewByDeadlineArg>> todayTasks = taskListData.GetTaskListOrderByDeadline();
            IList<string> showString = new List<string>();
            foreach (var project in todayTasks)
            {
                showString.Add(project.Key);
                foreach (var taskAttribute in project.Value)
                {
                    showString.Add(string.Format("    [{0}] {1}: {2}", taskAttribute.Done, taskAttribute.Id, taskAttribute.Description));
                }
                showString.Add("");
            }
            return showString;
        }
    }
}
