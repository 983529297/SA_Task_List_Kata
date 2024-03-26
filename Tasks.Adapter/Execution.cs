using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Controller.UsecaseController;
using Tasks.Controller.UsecasePresenter;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.Controller
{
    public class Execution : IExecution
    {

        public IList<string> Execute(string commandLine)
        {
            var commandRest = commandLine.Split(" ".ToCharArray(), 2);
            var command = commandRest[0];
            switch (command)
            {
                case "show":
                    ShowOutputDto showOutputDtoShow = new ShowController().Show();
                    IShowPresenter showPresenter = new ShowPresenterFactory().ShowPresenterMethod();
                    return showPresenter.OutputResult(showOutputDtoShow);
                case "view":
                    ShowOutputDto showOutputDtoView = new ShowController().Show(commandRest[1]);
                    IShowPresenter viewPresenter = new ShowPresenterFactory().ShowPresenterMethod(commandRest[1]);
                    return viewPresenter.OutputResult(showOutputDtoView);
                case "deadline":
                    new deadlineController().Deadline(commandRest[1]);
                    break;
                case "today":
                    TodayOutputDto todayOutputDto = new TodayController().Today();
                    return new TodayPresenter().OutputResult(todayOutputDto);
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
                    HelpOutputDto helpOutputDto = new HelpController().Help();
                    return new HelpPresenter().OutputResult(helpOutputDto);
                default:
                    ErrorOutputDto errorOutputDto = new ErrorController().Error(command);
                    return new ErrorPresenter().OutputResult(errorOutputDto);
            }

            return new List<string>();
        }
    }
}
