using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecaseController
{
    public class ErrorController : UsecaseControllerBase
    {
        public IList<string> Error(string command)
        {
            return executeOperationImp.Error(command);
        }
    }
}
