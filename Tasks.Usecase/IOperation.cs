using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Usecase
{
    public interface IOperation<Output, Input>
    {
        Output ExecuteOperation(Input input);
    }
}