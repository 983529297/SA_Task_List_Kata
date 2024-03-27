using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Usecase.Input;
using Tasks.Usecase.Output;

namespace Tasks.Main
{
    public class UsecaseDependency
    {
        public IDictionary<string, OperationBase> usecaseMap;
        public UsecaseDependency()
        {
            usecaseMap = new Dictionary<string, OperationBase>()
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
