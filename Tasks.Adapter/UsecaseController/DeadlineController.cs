using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;

namespace Tasks.Controller.UsecaseController
{
    public class deadlineController : UsecaseControllerBase
    {
        public void Deadline(string command)
        {
            IList<string> parameters = command.Split(" ".ToCharArray(), 2);
            executeOperationImp.Deadline(new DeadlineInputDto { Id = int.Parse(parameters[0]), Deadline = DateTime.Parse(parameters[1]) });
        }
    }
}
