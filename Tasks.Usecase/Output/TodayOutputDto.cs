using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Entity;

namespace Tasks.Usecase.Output
{
    public class TodayOutputDto
    {
        public IDictionary<string, IList<ReadonlyTask>> TaskListOfToday { get; set; }

        public TodayOutputDto()
        {
            TaskListOfToday = new Dictionary<string, IList<ReadonlyTask>>();
        }
    }
}
