using System;

namespace PrioryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            string userInput = string.Empty;

            while (true)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("        PrioryTask - SPR 2.0       ");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Complete Task");
                Console.WriteLine("3. Display Tasks");
                Console.WriteLine("4. View Next Task");
                Console.WriteLine("5. Check if Task List is Empty");
                Console.WriteLine("6. Get Task Count");
                Console.WriteLine("7. Exit");
                Console.WriteLine("===================================");
                Console.Write("Select an option: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        new AddTask(taskManager).Execute();
                        break;
                    case "2":
                        new CompleteTask(taskManager).Execute();
                        break;
                    case "3":
                        new DisplayTasks(taskManager).Execute();
                        break;
                    case "4":
                        new ViewNextTask(taskManager).Execute();
                        break;
                    case "5":
                        new CheckIfTaskListIsEmpty(taskManager).Execute();
                        break;
                    case "6":
                        new GetTaskCount(taskManager).Execute();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
