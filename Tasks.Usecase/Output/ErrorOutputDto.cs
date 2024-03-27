using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase.Output
{
    public class ErrorOutputDto : IOutputDto
    {
        public string ErrorCommand { get; set; }
    }
}
