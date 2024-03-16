using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteOperationImp.Output
{
    public class ShowOutputDto
    {
        public IDictionary<string, IList<ShowOutputArg>> TaskListWithOrder { get; set; }

        public ShowOutputDto()
        {
            TaskListWithOrder = new Dictionary<string, IList<ShowOutputArg>>();
        }
    }
}
