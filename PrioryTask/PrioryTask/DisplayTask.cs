namespace PrioryTask
{
    public class DisplayTasks
    {
        private TaskManager taskManager;

        public DisplayTasks(TaskManager taskManager)
        {
            this.taskManager = taskManager;
        }

        public void Execute()
        {
            taskManager.DisplayTasks();
        }
    }
}
