using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Input;
using Tasks.ExecuteOperationImp.Output;
using Tasks.ExecuteOperationImp.Imp;

namespace Tasks.ExecuteOperationImp
{
    public class ExecuteOperationImp : IExecuteOperationImp
    {
		public ShowOutputDto Show(ShowInputDto showDto)
		{
			IOperationShow operationShow = new OperationShowFactory().ShowMethod(showDto.Mode);
			return operationShow.Show();
		}

		public void Deadline(DeadlineInputDto deadlineDto)
        {
			OperationDeadline operationDeadline = new OperationDeadline();
			operationDeadline.Deadline(deadlineDto.Id, deadlineDto.Deadline);
        }

		public TodayOutputDto Today()
        {
			OperationToday operationToday = new OperationToday();
			return operationToday.Today();
        }

		public void Add(AddInputDto addDto)
		{
			OperationAdd operationAdd = new OperationAdd();
			operationAdd.Add(addDto.Mode, addDto.ProjectName, addDto.Description);
		}

		public void Delete(DeleteInputDto deleteDto)
        {
			OperationDelete operationDelete = new OperationDelete();
			operationDelete.Delete(deleteDto.Id);
        }

		public void Check(DoCheckInputDto doCheckDto)
		{
			OperationDoCheck operationDoCheck = new OperationDoCheck();
			operationDoCheck.SetDone(doCheckDto.Id, true);
		}

		public void Uncheck(DoCheckInputDto doCheckDto)
		{
			OperationDoCheck operationDoCheck = new OperationDoCheck();
			operationDoCheck.SetDone(doCheckDto.Id, false);
		}

		public HelpOutputDto Help()
		{
			OperationHelp operationHelp = new OperationHelp();
			return operationHelp.Help();
		}

		public ErrorOutputDto Error(ErrorInputDto errorDto)
		{
			OperationError operationError = new OperationError();
			return operationError.Error(errorDto.Command);
		}
	}
}
