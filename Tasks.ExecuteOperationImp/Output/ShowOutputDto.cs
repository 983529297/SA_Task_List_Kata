using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteOperationImp.Output
{
    public class ShowOutputDto
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public string Description { get; set; }

        public bool DoCheck { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? Deadline { get; set; }

        public ShowOutputDto()
        {
            Date = null;
            Deadline = null;
        }
    }
}
