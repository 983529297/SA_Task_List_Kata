using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase.Input
{
    public class ErrorInputDto : IInputDto
    {
        public string Command { get; set; }
    }
}
