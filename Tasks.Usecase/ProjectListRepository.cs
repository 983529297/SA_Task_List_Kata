using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tasks.Entity;

namespace Tasks.Usecase
{
    public class ProjectListRepository : IProjectListRepository
    {
        private IList<IProjectListData> projectListDatas = new List<IProjectListData>();

        public IProjectListData FindByID(string ID)
        {
            return projectListDatas.Where(obj => obj.GetID() == ID).FirstOrDefault();
        }

        public void Save(IProjectListData projectListData)
        {
            projectListDatas.Remove(projectListData);
            projectListDatas.Add(projectListData);
        }
    }
}
