using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Entity;

namespace Tasks.Usecase
{
    public interface IProjectListRepository
    {
        IProjectListData FindByID(string id = "1");

        void Save(IProjectListData projectListData);
    }
}
