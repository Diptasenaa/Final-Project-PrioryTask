using PrioryTask_V2;

namespace PrioryTask_V2
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
