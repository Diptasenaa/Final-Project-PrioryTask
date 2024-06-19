using System;
using System.Collections.Generic;

namespace PrioryTask
{
    public class TaskManager
    {
        private LinkedList<string> tasks;
        private Queue<LinkedListNode<string>> taskQueue;

        public TaskManager()
        {
            tasks = new LinkedList<string>();
            taskQueue = new Queue<LinkedListNode<string>>();
        }

        public void AddTask(string taskDescription)
        {
            var newTask = tasks.AddLast(taskDescription);
            taskQueue.Enqueue(newTask);
            Console.WriteLine("Task added successfully.");
        }

        public void CompleteTask()
        {
            if (taskQueue.Count > 0)
            {
                var completedTask = taskQueue.Dequeue();
                tasks.Remove(completedTask);
                Console.WriteLine($"Task '{completedTask.Value}' completed and removed from the list.");
            }
            else
            {
                Console.WriteLine("No tasks to complete.");
            }
        }

        public void DisplayTasks()
        {
            if (tasks.Count > 0)
            {
                Console.WriteLine("Current tasks:");
                foreach (var task in tasks)
                {
                    Console.WriteLine($"- {task}");
                }
            }
            else
            {
                Console.WriteLine("No tasks available.");
            }
        }

        public void ViewNextTask()
        {
            if (taskQueue.Count > 0)
            {
                Console.WriteLine($"Next task: {taskQueue.Peek().Value}");
            }
            else
            {
                Console.WriteLine("No tasks available.");
            }
        }

        public void CheckIfTaskListIsEmpty()
        {
            if (tasks.Count > 0)
            {
                Console.WriteLine("Task list is not empty.");
            }
            else
            {
                Console.WriteLine("Task list is empty.");
            }
        }

        public void GetTaskCount()
        {
            Console.WriteLine($"Number of tasks in the list: {tasks.Count}");
        }
    }
}
