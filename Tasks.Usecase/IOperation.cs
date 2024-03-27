using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;
namespace Tasks.Usecase
{
    public interface IOperation<Output, Input> where Output : IOutputDto where Input : IInputDto
    {
        Output ExecuteOperation(Input input);
    }
}