using System;

namespace PrioryTask
{
    public class AddTask
    {
        private TaskManager taskManager;

        public AddTask(TaskManager taskManager)
        {
            this.taskManager = taskManager;
        }

        public void Execute()
        {
            Console.Write("Enter task description: ");
            string taskDescription = Console.ReadLine();
            taskManager.AddTask(taskDescription);
        }
    }
}
