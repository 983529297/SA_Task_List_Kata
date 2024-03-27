using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase.Output
{
    public class ShowOutputArg : IOutputDto
    {
        public string Id { get; set; }

        public string ProjectName { get; set; }

        public string Description { get; set; }

        public string Done { get; set; }

        public string? Deadline { get; set; }

        public ShowOutputArg()
        {
            Deadline = "";
        }
    }
}
