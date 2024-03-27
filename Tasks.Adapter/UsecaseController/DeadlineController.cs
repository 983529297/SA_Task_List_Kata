using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;

namespace Tasks.Controller.UsecaseController
{
    public class deadlineController
    {
        public void Deadline(string command)
        {
            IList<string> parameters = command.Split(" ".ToCharArray(), 2);
            new OperationDeadline().ExecuteOperation(new DeadlineInputDto { Id = int.Parse(parameters[0]), Deadline = DateTime.Parse(parameters[1]) });
            //executeOperationImp.Deadline(new DeadlineInputDto { Id = int.Parse(parameters[0]), Deadline = DateTime.Parse(parameters[1]) });
        }
    }
}
