using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Entity;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
    public class OperationDeadline : OperationBase, IOperation<VoidOutputDto, DeadlineInputDto>
    {
        public VoidOutputDto ExecuteOperation(DeadlineInputDto deadlineInputDto)
        {
            taskListData.SetDeadline(deadlineInputDto.Id, deadlineInputDto.Deadline);

            return new VoidOutputDto();
        }
    }
}
