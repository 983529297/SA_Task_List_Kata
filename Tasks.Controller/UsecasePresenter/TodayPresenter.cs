using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Output;

namespace Tasks.Controller.UsecasePresenter
{
    public class TodayPresenter
    {
        public IList<string> OutputResult(TodayOutputDto todayOutputDto)
        {
            IList<string> todayString = new List<string>();
            foreach (var project in todayOutputDto.TaskListOfToday)
            {
                todayString.Add(project.Key);
                foreach (var taskAttribute in project.Value)
                {
                    todayString.Add(string.Format("    [{0}] {1}: {2}{3}", taskAttribute.Done, taskAttribute.Id, taskAttribute.Description, taskAttribute.Deadline == "" ? "" : " " + taskAttribute.Deadline));
                }
                todayString.Add("");
            }
            return todayString;
        }
    }
}
