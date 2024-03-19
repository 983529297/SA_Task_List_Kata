using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.ExecuteOperationImp
{
    public class OperationHelp : OperationBase
    {
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
