using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase;

namespace Tasks.Adapter
{
    public interface IUsecaseDependency
    {
        IDictionary<string, OperationBase> GetUsecaseMap();
        IProjectListRepository GetRepository();
    }
}
