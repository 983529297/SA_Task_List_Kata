using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Input;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.ExecuteOperationImp
{
    public interface IExecuteOperationImp
    {
        IList<string> Show(ShowInputDto showDto);
        void Deadline(DeadlineInputDto deadlineDto);
        IList<string> Today();
        void Add(AddInputDto addDto);
        void Delete(DeleteInputDto deleteDto);
        void Check(DoCheckInputDto doCheckDto);
        void Uncheck(DoCheckInputDto doCheckDto);
        IList<string> Help();
        ErrorOutputDto Error(ErrorInputDto errorDto);
    }
}
