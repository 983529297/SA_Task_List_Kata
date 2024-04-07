using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Entity;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
    public class OperationDelete : OperationBase, IOperation<VoidOutputDto, DeleteInputDto>
    {
        public VoidOutputDto ExecuteOperation(DeleteInputDto deleteInputDto)
        {
            taskListData.DeleteTask(deleteInputDto.Id);
            return new VoidOutputDto();
        }
    }
}
