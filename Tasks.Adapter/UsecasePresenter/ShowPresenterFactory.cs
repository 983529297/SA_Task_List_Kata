using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Controller.UsecasePresenter
{
    public class ShowPresenterFactory
    {
        public IShowPresenter ShowPresenterMethod(string sortedMethod = "by project")
        {
            switch (sortedMethod)
            {
                case "by project":
                    return new ShowPresenter();
                case "by deadline":
                    return new ViewByDeadlinePresenter();
                case "by date":
                    return new ViewByDatePresenter();
                default:
                    throw new Exception("Could not find the command");
            }
        }
    }
}
