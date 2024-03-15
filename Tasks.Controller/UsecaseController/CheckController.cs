using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecaseController
{
    public class CheckController : UsecaseControllerBase
    {
        public void Check(string command)
        {
            executeOperationImp.Check(command);
        }
    }
}
