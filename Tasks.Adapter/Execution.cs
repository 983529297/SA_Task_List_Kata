using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Controller.UsecaseController;
using Tasks.Controller.UsecasePresenter;
using Tasks.Usecase;
using Tasks.Usecase.Output;
using Tasks.Usecase.Input;

namespace Tasks.Controller
{
    public class Execution : IExecution
    {

        public IList<string> Execute(IDictionary<string, OperationBase> usecaseMap, string commandLine)
        {
            var commandRest = commandLine.Split(" ".ToCharArray(), 2);
            var command = commandRest[0];
            switch (command)
            {
                case "show":
                    ShowOutputDto showOutputDtoShow = new ShowController().Show((IOperation<ShowOutputDto, ShowInputDto>) usecaseMap[command]);
                    IShowPresenter showPresenter = new ShowPresenter();
                    return showPresenter.OutputResult(showOutputDtoShow);
                case "add":
                    new AddController().Add((IOperation<VoidOutputDto, AddInputDto>) usecaseMap[command], commandRest[1]);
                    break;
                case "check":
                    new CheckController().Check((IOperation<VoidOutputDto, DoCheckInputDto>) usecaseMap[command], commandRest[1]);
                    break;
                case "uncheck":
                    new UncheckController().Uncheck((IOperation<VoidOutputDto, DoCheckInputDto>) usecaseMap[command], commandRest[1]);
                    break;
                case "help":
                    HelpOutputDto helpOutputDto = new HelpController().Help((IOperation<HelpOutputDto, EmptyInputDto>) usecaseMap[command]);
                    return new HelpPresenter().OutputResult(helpOutputDto);
                default:
                    ErrorOutputDto errorOutputDto = new ErrorController().Error((IOperation<ErrorOutputDto, ErrorInputDto>) usecaseMap[command], command);
                    return new ErrorPresenter().OutputResult(errorOutputDto);
            }

            return new List<string>();
        }
    }
}
