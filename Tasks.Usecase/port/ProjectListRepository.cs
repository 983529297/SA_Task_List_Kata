using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tasks.Entity;

namespace Tasks.Usecase
{
    public class ProjectListRepository : IProjectListRepository
    {
        private string DEFAULT_PROJECT_LIST_ID = "1";
        private IList<IProjectListData> projectListDatas = new List<IProjectListData>();

        public string GetDefaultProjecyListID()
        {
            return DEFAULT_PROJECT_LIST_ID;
        }

        public IProjectListData FindByID(string ID = "1")
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
