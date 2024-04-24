using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;
using Tasks.Adapter;
using Tasks.Entity;

namespace Tasks.Main
{
    public class UsecaseDependency : IUsecaseDependency
    {
        public IDictionary<string, OperationBase> usecaseMap;
        public IProjectListRepository projectListRepository;

        public UsecaseDependency()
        {
            projectListRepository = new ProjectListRepository();
            projectListRepository.Save(new ProjectListData());

            usecaseMap = new Dictionary<string, OperationBase>()
            {
                {"show", new OperationShow(projectListRepository) },
                {"add", new OperationAdd(projectListRepository) },
                {"check", new OperationDoCheck(projectListRepository) },
                {"uncheck", new OperationDoCheck(projectListRepository) },
                {"help", new OperationHelp() },
                {"error", new OperationError() }
            };
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
