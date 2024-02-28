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
            IDictionary<string, IList<IList<string>>> todayTasks = taskListData.GetTaskList();
            IList<string> showString = new List<string>();
            foreach (var project in todayTasks)
            {
                showString.Add(project.Key);
                foreach (var taskAttribute in project.Value)
                {
                    showString.Add(string.Format("    [{0}] {1}: {2}{3}", taskAttribute[0], taskAttribute[1], taskAttribute[2], taskAttribute[3]));
                }
                showString.Add("");
            }
            return showString;
        }
    }
}
