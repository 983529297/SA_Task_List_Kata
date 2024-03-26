using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase.Imp
{
    public interface IOperation<output, input>
    {
        output ExecuteOperation(input input);
    }
}
