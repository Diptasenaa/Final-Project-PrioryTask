using PrioryTask_V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrioryTask_V2
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
