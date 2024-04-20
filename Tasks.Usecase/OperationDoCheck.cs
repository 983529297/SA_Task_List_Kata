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
        public OperationDoCheck(IProjectListRepository projectListRepository)
        {
            this.projectListRepository = projectListRepository;
        }

        public VoidOutputDto ExecuteOperation(DoCheckInputDto doCheckInputDto)
        {
            projectListRepository.FindByID().SetDone(doCheckInputDto.Id, doCheckInputDto.Done);
            return new VoidOutputDto();
        }
    }
}
