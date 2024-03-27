using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;

namespace Tasks.Main
{
    public class UsecaseDependency
    {
        public IDictionary<string, object> usecaseMap;
        public UsecaseDependency()
        {
            usecaseMap = new Dictionary<string, object>()
            {
                {"show", new OperationShow() },
                {"add", new OperationAdd() },
                {"check", new OperationDoCheck() },
                {"uncheck", new OperationDoCheck() },
                {"today", new OperationToday() },
                {"help", new OperationHelp() },
                {"deadline", new OperationDeadline() },
                {"delete", new OperationDelete() },
                {"error", new OperationError() }
            };
        }
    }
}
