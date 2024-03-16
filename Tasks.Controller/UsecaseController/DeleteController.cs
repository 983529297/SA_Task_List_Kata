using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ExecuteOperationImp.Input;

namespace Tasks.Controller.UsecaseController
{
    public class DeleteController : UsecaseControllerBase
    {
        public void Delete(string idString)
        {
            executeOperationImp.Delete(new DeleteInputDto { Id = int.Parse(idString) });
        }
    }
}
