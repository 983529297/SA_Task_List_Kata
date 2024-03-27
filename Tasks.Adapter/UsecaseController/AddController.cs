using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecaseController
{
    public class AddController
    {
        public void Add(IOperation<VoidOutputDto, AddInputDto> operation, string command)
        {
            IList<string> parameters = command.Split(" ".ToCharArray(), 3);
            if (parameters.Count > 2)
            {
                operation.ExecuteOperation(new AddInputDto { Mode = parameters[0], ProjectName = parameters[1], Description = parameters[2] });
                //executeOperationImp.Add(new AddInputDto { Mode = parameters[0], ProjectName = parameters[1], Description = parameters[2] });
            } else
            {
                operation.ExecuteOperation(new AddInputDto { Mode = parameters[0], ProjectName = parameters[1] });
                //executeOperationImp.Add(new AddInputDto { Mode = parameters[0], ProjectName = parameters[1] });
            }
        }
    }
}
