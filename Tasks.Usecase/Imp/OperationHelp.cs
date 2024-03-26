using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Usecase
{
    public class OperationHelp : OperationBase, IOperation<HelpOutputDto, EmptyInputDto>
    {
        public HelpOutputDto ExecuteOperation(EmptyInputDto emptyInputDto = null)
        {
            IList<string> helpString = new List<string>();

            helpString.Add("Commands:");
            helpString.Add("  show");
            helpString.Add("  view by project");
            helpString.Add("  view by deadline");
            helpString.Add("  view by date");
            helpString.Add("  add project <project name>");
            helpString.Add("  add task <project name> <task description>");
            helpString.Add("  deadline <task ID> <yyyy-MM-dd>");
            helpString.Add("  today");
            helpString.Add("  check <task ID>");
            helpString.Add("  uncheck <task ID>");
            helpString.Add("");

            return new HelpOutputDto { ListOfCommand = helpString };
        }

        public HelpOutputDto Help()
        {
            IList<string> helpString = new List<string> ();

            helpString.Add("Commands:");
            helpString.Add("  show");
            helpString.Add("  view by project");
            helpString.Add("  view by deadline");
            helpString.Add("  view by date");
            helpString.Add("  add project <project name>");
            helpString.Add("  add task <project name> <task description>");
            helpString.Add("  deadline <task ID> <yyyy-MM-dd>");
            helpString.Add("  today");
            helpString.Add("  check <task ID>");
            helpString.Add("  uncheck <task ID>");
            helpString.Add("");

            return new HelpOutputDto { ListOfCommand = helpString };
        }
    }
}
