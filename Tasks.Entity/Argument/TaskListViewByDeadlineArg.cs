using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Entity
{
    public class TaskListViewByDeadlineArg
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }

    }
}
