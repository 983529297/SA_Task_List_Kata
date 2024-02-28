using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationShow : IOperationShow
    {
		private readonly ITaskListData taskListData = TaskListData.Instance;

        public IList<string> Show()
        {
            IDictionary<string, IList<TaskListArg>> todayTasks = taskListData.GetTaskList();
            IList<string> showString = new List<string>();
            foreach (var project in todayTasks)
            {
                showString.Add(project.Key);
                foreach (var taskAttribute in project.Value)
                {
                    showString.Add(string.Format("    [{0}] {1}: {2}{3}", taskAttribute.Done, taskAttribute.Id, taskAttribute.Description, taskAttribute.deadline == "" ? "" : " " + taskAttribute.deadline));
                }
                showString.Add("");
            }
            return showString;
        }
    }
}
