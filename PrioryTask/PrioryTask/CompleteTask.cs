namespace PrioryTask
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
