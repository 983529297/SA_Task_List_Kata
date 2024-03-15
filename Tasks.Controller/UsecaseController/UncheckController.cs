using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecaseController
{
    public class UncheckController : UsecaseControllerBase
    {
        public void Uncheck(string command)
        {
            executeOperationImp.Uncheck(command);
        }
    }
}
