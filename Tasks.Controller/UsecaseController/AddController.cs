using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecaseController
{
    public class AddController : UsecaseControllerBase
    {
        public void Add(string command)
        {
            IList<string> parameters = command.Split(" ".ToCharArray(), 3);
            executeOperationImp.Add(parameters[0], parameters[1], parameters.Count > 2 ? parameters[2] : "");
        }
    }
}
