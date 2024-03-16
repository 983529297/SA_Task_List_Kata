using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteOperationImp.Input
{
    public class AddInputDto
    {
        public string Mode { get; set; }

        public string ProjectName { get; set; }

        public string Description { get; set; }

        public AddInputDto()
        {
            Description = "";
        }
    }
}
