using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;
namespace Tasks.Usecase
{
    public interface IOperation<Output, Input>
    {
        Output ExecuteOperation(Input input);
    }
}