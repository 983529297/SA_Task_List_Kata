using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationToday : IOperationToday
    {
        private readonly ITaskListData taskListData = TaskListData.Instance;

        public IList<string> Today()
        {
            IDictionary<string, IList<IList<string>>> todayTasks = taskListData.GetTasksByDate(DateTime.Now);
            IList<string> todayString = new List<string>();
            foreach (var project in todayTasks)
            {
                todayString.Add(project.Key);
                foreach (var taskAttribute in project.Value)
                {
                    todayString.Add(string.Format("    [{0}] {1}: {2}{3}", taskAttribute[0], taskAttribute[1], taskAttribute[2], taskAttribute[3]));
                }
                todayString.Add("");
            }
            return todayString;
        }
    }
}
