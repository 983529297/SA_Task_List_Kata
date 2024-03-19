using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.ExecuteOperationImp
{
    public class OperationToday : OperationBase
    {
        public TodayOutputDto Today()
        {
            IDictionary<string, IList<TaskListTodayArg>> todayTasks = taskListData.GetTasksByDate(DateTime.Now);

            return new TodayOutputDto { TaskListOfToday = todayTasks};
        }
    }
}
