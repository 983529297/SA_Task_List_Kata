using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Controller.UsecaseController
{
    public class deadlineController
    {
        public void Deadline(IOperation<VoidOutputDto, DeadlineInputDto> operation, string command)
        {
            IList<string> parameters = command.Split(" ".ToCharArray(), 2);
            operation.ExecuteOperation(new DeadlineInputDto { Id = int.Parse(parameters[0]), Deadline = DateTime.Parse(parameters[1]) });
        }
    }
}
