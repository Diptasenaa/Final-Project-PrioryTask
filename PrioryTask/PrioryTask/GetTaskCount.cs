namespace PrioryTask
{
    public class GetTaskCount
    {
        private TaskManager taskManager;

        public GetTaskCount(TaskManager taskManager)
        {
            this.taskManager = taskManager;
        }

        public void Execute()
        {
            taskManager.GetTaskCount();
        }
    }
}
