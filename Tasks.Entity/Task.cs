using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Entity
{
    public class Task
    {
        internal long ID { get; set; }

        internal string Description { get; set; }

        internal bool Done { get; set; }

        internal DateTime Date { get; set; }

        internal DateTime? Deadline { get; set; }
    }
}
