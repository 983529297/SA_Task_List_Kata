using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase.Input
{
    public class AddInputDto : IInputDto
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
