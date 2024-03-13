using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ExecuteOperationImp
{
    public class OperationHelp : OperationBase, IOperateAndReturn
    {
        public IList<string> OperateAndReturn()
        {
            return Help();
        }

        private IList<string> Help()
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

            return helpString;
        }
    }
}
