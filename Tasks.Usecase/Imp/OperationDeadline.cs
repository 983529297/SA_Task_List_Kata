using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Data;
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

        public void Deadline(int id, DateTime deadline)
        {
            taskListData.SetDeadline(id, deadline);
        }
    }
}
