using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Input;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.ExecuteOperationImp
{
    public class ExecuteOperationImp : IExecuteOperationImp
    {
		public IList<string> Show(ShowInputDto showDto)
		{
			IOperateAndReturn operationShow = new OperationShowFactory().ShowMethod(showDto.Mode);
			return operationShow.OperateAndReturn();
		}

		public void Deadline(DeadlineInputDto deadlineDto)
        {
			IOperateAndEnd operationDeadline = new OperationDeadline(deadlineDto.Id, deadlineDto.Deadline);
			operationDeadline.OperateAndEnd();
        }

		public IList<string> Today()
        {
			IOperateAndReturn operationToday = new OperationToday();
			return operationToday.OperateAndReturn();
        }

		public void Add(AddInputDto addDto)
		{
			IOperateAndEnd operationAdd = new OperationAdd(addDto.Mode, addDto.ProjectName, addDto.Description);
			operationAdd.OperateAndEnd();
		}

		public void Delete(DeleteInputDto deleteDto)
        {
			IOperateAndEnd operationDelete = new OperationDelete(deleteDto.Id);
			operationDelete.OperateAndEnd();
        }

		public void Check(DoCheckInputDto doCheckDto)
		{
			IOperateAndEnd operationDoCheck = new OperationDoCheck(doCheckDto.Id, true);
			operationDoCheck.OperateAndEnd();
		}

		public void Uncheck(DoCheckInputDto doCheckDto)
		{
			IOperateAndEnd operationDoCheck = new OperationDoCheck(doCheckDto.Id, false);
			operationDoCheck.OperateAndEnd();
		}

		public IList<string> Help()
		{
			IOperateAndReturn operationHelp = new OperationHelp();
			return operationHelp.OperateAndReturn();
		}

		public ErrorOutputDto Error(ErrorInputDto errorDto)
		{
			OperationError operationError = new OperationError();
			return operationError.Error(errorDto.Command);
		}
	}
}
