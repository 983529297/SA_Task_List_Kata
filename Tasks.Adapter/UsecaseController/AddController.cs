using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;

namespace Tasks.Controller.UsecaseController
{
    public class AddController
    {
        public void Add(string command)
        {
            IList<string> parameters = command.Split(" ".ToCharArray(), 3);
            if (parameters.Count > 2)
            {
                new OperationAdd().ExecuteOperation(new AddInputDto { Mode = parameters[0], ProjectName = parameters[1], Description = parameters[2] });
                //executeOperationImp.Add(new AddInputDto { Mode = parameters[0], ProjectName = parameters[1], Description = parameters[2] });
            } else
            {
                new OperationAdd().ExecuteOperation(new AddInputDto { Mode = parameters[0], ProjectName = parameters[1] });
                //executeOperationImp.Add(new AddInputDto { Mode = parameters[0], ProjectName = parameters[1] });
            }
        }
    }
}
