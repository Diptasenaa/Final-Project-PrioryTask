namespace PrioryTask
{
    public class CheckIfTaskListIsEmpty
    {
        private TaskManager taskManager;

        public CheckIfTaskListIsEmpty(TaskManager taskManager)
        {
            this.taskManager = taskManager;
        }

        public void Execute()
        {
            taskManager.CheckIfTaskListIsEmpty();
        }
    }
}
