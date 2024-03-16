using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.Controller.UsecasePresenter
{
    public class ShowPresenter : IShowPresenter
    {
        public IList<string> OutputResult(ShowOutputDto showOutputDto)
        {
            IList<string> showString = new List<string>();
            foreach (var project in showOutputDto.TaskListWithOrder)
            {
                showString.Add(project.Key);
                foreach (var taskAttribute in project.Value)
                {
                    showString.Add(string.Format("    [{0}] {1}: {2}{3}", taskAttribute.Done, taskAttribute.Id, taskAttribute.Description, taskAttribute.Deadline == "" ? "" : " " + taskAttribute.Deadline));
                }
                showString.Add("");
            }
            return showString;
        }
    }
}
