using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.OperationImp
{
    public class OperationShowFactory
    {
        public IOperationShow ShowMethod(string sortedMethod)
        {
            if (sortedMethod == "by project")
            {
                return new OperationShow();
            }else
            {
                return new OperationShowViewByDeadline();
            }
        }
    }
}
