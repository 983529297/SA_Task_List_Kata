using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;

namespace Tasks.Usecase.Output
{
    public class TodayOutputDto : IOutputDto
    {
        public IDictionary<string, IList<TaskListTodayArg>> TaskListOfToday { get; set; }

        public TodayOutputDto()
        {
            TaskListOfToday = new Dictionary<string, IList<TaskListTodayArg>>();
        }
    }
}
