using System;
using System.Collections.Generic;

namespace Tasks.Data
{
    public class TaskListData
    {
        private readonly IDictionary<string, IList<Task>> tasks = new Dictionary<string, IList<Task>>();

    }
}
