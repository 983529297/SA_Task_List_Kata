using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteOperationImp.Output
{
    public class TodayOutputDto
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public string Description { get; set; }

        public bool Check { get; set; }

        public DateTime Date { get; set; }
    }
}
