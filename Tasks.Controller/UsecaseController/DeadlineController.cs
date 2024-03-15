using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecaseController
{
    public class deadlineController : UsecaseControllerBase
    {
        public void Deadline(string command)
        {
            IList<string> parameters = command.Split(" ".ToCharArray(), 2);
            executeOperationImp.Deadline(parameters[0], parameters[1]);
        }
    }
}
