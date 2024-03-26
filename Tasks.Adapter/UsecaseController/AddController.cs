using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;

namespace Tasks.Controller.UsecaseController
{
    public class AddController : UsecaseControllerBase
    {
        public void Add(string command)
        {
            IList<string> parameters = command.Split(" ".ToCharArray(), 3);
            if (parameters.Count > 2)
            {
                executeOperationImp.Add(new AddInputDto { Mode = parameters[0], ProjectName = parameters[1], Description = parameters[2] });
            } else
            {
                executeOperationImp.Add(new AddInputDto { Mode = parameters[0], ProjectName = parameters[1] });
            }
        }
    }
}
