using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Data
{
    public class Task
    {
        public long ID { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }

        public DateTime Date { get; set; }

        public DateTime? Deadline { get; set; }
    }
}
