using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Entity
{
    public class TaskListTodayArg
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }

        public DateTime? Deadline { get; set; }
    }
}
