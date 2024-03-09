using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.OperationImp
{
    public class OperationShowFactory
    {
        public IOperateAndReturn ShowMethod(string sortedMethod)
        {
            switch (sortedMethod)
            {
                case "by project":
                    return new OperationShow();
                case "by deadline":
                    return new OperationShowViewByDeadline();
                case "by date":
                    return new OperationShowViewByDate();
                default:
                    throw new Exception("Could not find the command");
            }
        }
    }
}
