using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Entity;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
    public class OperationToday : OperationBase, IOperation<TodayOutputDto, EmptyInputDto>
    {
        public TodayOutputDto ExecuteOperation(EmptyInputDto emptyInputDto = null)
        {
            IDictionary<string, IList<ReadonlyTask>> todayTasks = taskListData.GetTasksByDate(DateTime.Now);

            return new TodayOutputDto { TaskListOfToday = todayTasks };
        }
    }
}
