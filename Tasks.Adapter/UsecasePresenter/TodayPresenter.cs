using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Usecase.Output;

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
                    todayString.Add(string.Format("    [{0}] {1}: {2}{3}", taskAttribute.Done ? "x" : " ", taskAttribute.Id, taskAttribute.Description, taskAttribute.Deadline == null ? "" : " " + taskAttribute.Deadline.Value.ToString("yyyy-MM-dd")));
                }
                todayString.Add("");
            }
            return todayString;
        }
    }
}
