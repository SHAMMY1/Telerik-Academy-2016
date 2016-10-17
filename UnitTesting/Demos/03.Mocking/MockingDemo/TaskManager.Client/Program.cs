using System;
using System.Linq;
using TaskManager.Models;

namespace TaskManager.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var conaosleLogger = new ConsoleLoger();
            var idProvider = new IDProvider();
            var taskManager = new Tasker(conaosleLogger,idProvider);

            var task1 = new Task("Kupi hliab");
            var task2 = new Task("Izmii kolata", DateTime.Now.AddDays(2));
            var task3 = new Task("Kupi bira", DateTime.Now);

            taskManager.Save(task1);
            taskManager.Save(task2);

            taskManager.Delete(2);

            taskManager.Save(task3);
        }
    }
}
