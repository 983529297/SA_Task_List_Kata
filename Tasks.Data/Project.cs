using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Data
{
    public class Project
    {
        public string ID { get; set; }

        public IList<Task> TaskList { get; set; }
    }
}
