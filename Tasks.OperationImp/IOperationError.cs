using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.OperationImp
{
    public interface IOperationError
    {
        IList<string> Error(String command);
    }
}
