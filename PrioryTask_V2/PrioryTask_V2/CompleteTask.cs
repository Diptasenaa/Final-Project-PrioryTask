using PrioryTask_V2;

namespace PrioryTask_V2
{
    public class CompleteTask
    {
        private TaskManager taskManager;

        public CompleteTask(TaskManager taskManager)
        {
            this.taskManager = taskManager;
        }

        public void Execute()
        {
            taskManager.CompleteTask();
        }
    }
}
