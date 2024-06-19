namespace PrioryTask
{
    public class ViewNextTask
    {
        private TaskManager taskManager;

        public ViewNextTask(TaskManager taskManager)
        {
            this.taskManager = taskManager;
        }

        public void Execute()
        {
            taskManager.ViewNextTask();
        }
    }
}
