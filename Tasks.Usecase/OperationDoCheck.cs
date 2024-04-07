using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Entity;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
    public class OperationDoCheck : OperationBase, IOperation<VoidOutputDto, DoCheckInputDto>
    {
        public VoidOutputDto ExecuteOperation(DoCheckInputDto doCheckInputDto)
        {
            taskListData.SetDone(doCheckInputDto.Id, doCheckInputDto.Done);
            return new VoidOutputDto();
        }
    }
}
