HW2
========
1. 重新命名專案以及檔案 (Tasks -> Tasks.Controller, TaskList -> TaskController, Tasks.ExecuteImp -> Tasks.ExeciteOperationImp)
2. 對OperationImp創建共用的Base class (OperationBase)
3. 將OperationImp中的各IOperation...整合成IOperateAndReturn以及IOperationAndEnd
4. 將ExecuteImp從Tasks.ExecuteImp project移到Tasks.Controller project，並更名為ExecuteOperation
5. 新增data class包裝TaskListData中的回傳資料
6. 刪除Tasks.Service project