using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase.Output
{
    public class HelpOutputDto : IOutputDto
    {
        public IList<string> ListOfCommand { get; set; }
    }
}
