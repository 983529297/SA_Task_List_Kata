using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Controller.UsecaseController;
using Tasks.Controller.UsecasePresenter;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.Controller
{
    public class ExecuteOperation : IExecuteOperation
    {

        public IList<string> Execute(string commandLine)
        {
            var commandRest = commandLine.Split(" ".ToCharArray(), 2);
            var command = commandRest[0];
            switch (command)
            {
                case "show":
                    return new ShowController().Show();
                case "view":
                    return new ShowController().Show(commandRest[1]);
                case "deadline":
                    new deadlineController().Deadline(commandRest[1]);
                    break;
                case "today":
                    return new TodayController().Today();
                case "add":
                    new AddController().Add(commandRest[1]);
                    break;
                case "delete":
                    new DeleteController().Delete(commandRest[1]);
                    break;
                case "check":
                    new CheckController().Check(commandRest[1]);
                    break;
                case "uncheck":
                    new UncheckController().Uncheck(commandRest[1]);
                    break;
                case "help":
                    return new HelpController().Help();
                default:
                    ErrorOutputDto errorOutputDto = new ErrorController().Error(command);
                    return new ErrorPresenter().OutputResult(errorOutputDto);
            }

            return new List<string>();
        }
    }
}
