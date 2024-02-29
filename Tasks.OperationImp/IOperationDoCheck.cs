using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.OperationImp
{
    public interface IOperationDoCheck
    {
        void SetDone(String idString, bool done);
    }
}
