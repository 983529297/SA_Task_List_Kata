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

        public IList<string> Execute(IDictionary<string, object> usecaseMap, string commandLine)
        {
            var commandRest = commandLine.Split(" ".ToCharArray(), 2);
            var command = commandRest[0];
            switch (command)
            {
                case "show":
                    ShowOutputDto showOutputDtoShow = new ShowController().Show(usecaseMap[command] is IOperation<ShowOutputDto, ShowInputDto> ? (IOperation<ShowOutputDto, ShowInputDto>)usecaseMap[command] : null);
                    IShowPresenter showPresenter = new ShowPresenterFactory().ShowPresenterMethod();
                    return showPresenter.OutputResult(showOutputDtoShow);
                case "view":
                    ShowOutputDto showOutputDtoView = new ShowController().Show(usecaseMap[command] is IOperation<ShowOutputDto, ShowInputDto> ? (IOperation<ShowOutputDto, ShowInputDto>)usecaseMap[command] : null, commandRest[1]);
                    IShowPresenter viewPresenter = new ShowPresenterFactory().ShowPresenterMethod(commandRest[1]);
                    return viewPresenter.OutputResult(showOutputDtoView);
                case "deadline":
                    new deadlineController().Deadline(usecaseMap[command] is IOperation<VoidOutputDto, DeadlineInputDto> ? (IOperation<VoidOutputDto, DeadlineInputDto>)usecaseMap[command] : null, commandRest[1]);
                    break;
                case "today":
                    TodayOutputDto todayOutputDto = new TodayController().Today(usecaseMap[command] is IOperation<TodayOutputDto, EmptyInputDto> ? (IOperation<TodayOutputDto, EmptyInputDto>)usecaseMap[command] : null);
                    return new TodayPresenter().OutputResult(todayOutputDto);
                case "add":
                    new AddController().Add(usecaseMap[command] is IOperation<VoidOutputDto, AddInputDto> ? (IOperation<VoidOutputDto, AddInputDto>)usecaseMap[command] : null, commandRest[1]);
                    break;
                case "delete":
                    new DeleteController().Delete(usecaseMap[command] is IOperation<VoidOutputDto, DeleteInputDto> ? (IOperation<VoidOutputDto, DeleteInputDto>)usecaseMap[command] : null, commandRest[1]);
                    break;
                case "check":
                    new CheckController().Check(usecaseMap[command] is IOperation<VoidOutputDto, DoCheckInputDto> ? (IOperation<VoidOutputDto, DoCheckInputDto>)usecaseMap[command] : null, commandRest[1]);
                    break;
                case "uncheck":
                    new UncheckController().Uncheck(usecaseMap[command] is IOperation<VoidOutputDto, DoCheckInputDto> ? (IOperation<VoidOutputDto, DoCheckInputDto>)usecaseMap[command] : null, commandRest[1]);
                    break;
                case "help":
                    HelpOutputDto helpOutputDto = new HelpController().Help(usecaseMap[command] is IOperation<HelpOutputDto, EmptyInputDto> ? (IOperation<HelpOutputDto, EmptyInputDto>)usecaseMap[command] : null);
                    return new HelpPresenter().OutputResult(helpOutputDto);
                default:
                    ErrorOutputDto errorOutputDto = new ErrorController().Error(usecaseMap[command] is IOperation<ErrorOutputDto, ErrorInputDto> ? (IOperation<ErrorOutputDto, ErrorInputDto>)usecaseMap[command] : null, command);
                    return new ErrorPresenter().OutputResult(errorOutputDto);
            }

            return new List<string>();
        }
    }
}
