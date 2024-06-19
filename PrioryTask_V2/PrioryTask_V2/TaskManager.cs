using System;
using System.Collections.Generic;

namespace PrioryTask_V2
{
    public class Task
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        public Task(string description, DateTime deadline)
        {
            Description = description;
            Deadline = deadline;
        }

        public override string ToString()
        {
            return $"{Description} (Deadline: {Deadline.ToString("yyyy-MM-dd")})";
        }
    }

    public class TaskManager
    {
        private SortedDictionary<DateTime, LinkedList<Task>> tasks;

        public TaskManager()
        {
            tasks = new SortedDictionary<DateTime, LinkedList<Task>>();
        }

        public void AddTask(string description, DateTime deadline)
        {
            var newTask = new Task(description, deadline);
            if (!tasks.ContainsKey(deadline))
            {
                tasks[deadline] = new LinkedList<Task>();
            }
            tasks[deadline].AddLast(newTask);
            Console.WriteLine("Task added successfully.");
        }

        public void CompleteTask()
        {
            if (tasks.Count > 0)
            {
                var firstKey = tasks.Keys.Min();
                var taskToComplete = tasks[firstKey].First;
                tasks[firstKey].RemoveFirst();
                if (tasks[firstKey].Count == 0)
                {
                    tasks.Remove(firstKey);
                }
                Console.WriteLine($"Task '{taskToComplete.Value.Description}' completed and removed from the list.");
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
                foreach (var taskList in tasks)
                {
                    foreach (var task in taskList.Value)
                    {
                        Console.WriteLine($"- {task}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No tasks available.");
            }
        }

        public void ViewNextTask()
        {
            if (tasks.Count > 0)
            {
                var firstKey = tasks.Keys.Min();
                var nextTask = tasks[firstKey].First.Value;
                Console.WriteLine($"Next task: {nextTask}");
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
            int count = 0;
            foreach (var taskList in tasks)
            {
                count += taskList.Value.Count;
            }
            Console.WriteLine($"Number of tasks in the list: {count}");
        }
    }
}
