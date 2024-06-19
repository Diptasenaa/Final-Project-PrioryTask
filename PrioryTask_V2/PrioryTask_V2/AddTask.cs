using PrioryTask_V2;
using System;

namespace PrioryTask_V2
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

            Console.Write("Enter deadline (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime deadline))
            {
                taskManager.AddTask(taskDescription, deadline);
            }
            else
            {
                Console.WriteLine("Invalid date format. Task not added.");
            }
        }
    }
}
