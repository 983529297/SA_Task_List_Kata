using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase.Output
{
    public class ShowOutputArg
    {
        public long Id { get; set; }

        public string ProjectName { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }

        public DateTime? Deadline { get; set; }

        public ShowOutputArg()
        {
            Deadline = null;
        }
    }
}
