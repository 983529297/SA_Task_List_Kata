using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Implementation
{
    public interface IOperationDoCheck
    {
        void SetDone(String idString, bool done);
    }
}
