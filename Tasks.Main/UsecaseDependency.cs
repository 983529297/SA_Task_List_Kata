using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Adapter;

namespace Tasks.Main
{
    public class UsecaseDependency : IUsecaseDependency
    {
        public IDictionary<string, OperationBase> usecaseMap;
        public IProjectListRepository projectListRepository;

        public UsecaseDependency()
        {
            usecaseMap = new Dictionary<string, OperationBase>()
            {
                {"show", new OperationShow() },
                {"add", new OperationAdd() },
                {"check", new OperationDoCheck() },
                {"uncheck", new OperationDoCheck() },
                {"help", new OperationHelp() },
                {"error", new OperationError() }
            };

            projectListRepository = new ProjectListRepository();
        }

        public IDictionary<string, OperationBase> GetUsecaseMap()
        {
            return usecaseMap;
        }

        public IProjectListRepository GetRepository()
        {
            return projectListRepository;
        }
    }
}
