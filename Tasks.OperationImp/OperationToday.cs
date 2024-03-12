using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.OperationImp
{
    public class OperationToday : OperationBase, IOperateAndReturn
    {
        public IList<string> OperateAndReturn()
        {
            return Today();
        }

        private IList<string> Today()
        {
            IDictionary<string, IList<TaskListTodayArg>> todayTasks = taskListData.GetTasksByDate(DateTime.Now);
            IList<string> todayString = new List<string>();
            foreach (var project in todayTasks)
            {
                todayString.Add(project.Key);
                foreach (var taskAttribute in project.Value)
                {
                    todayString.Add(string.Format("    [{0}] {1}: {2}{3}", taskAttribute.Done, taskAttribute.Id, taskAttribute.Description, taskAttribute.Deadline == "" ? "" : " " + taskAttribute.Deadline));
                }
                todayString.Add("");
            }
            return todayString;
        }
    }
}
