using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Entity;

namespace Tasks.Usecase
{
    public interface IProjectListRepository
    {
        IProjectListData FindByID(string id);

        void Save(IProjectListData projectListData);
    }
}
