using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Tasker
    {
        private readonly ILogger logger;
        private readonly IIDProvider idProvider;

        public ICollection<Task> Tasks { get; set; }

        public Tasker(ILogger logger, IIDProvider idProvider)
        {
            this.Tasks = new List<Task>();
            this.logger =  logger;
            this.idProvider = idProvider;
        }

        public void Save(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException();
            }

            task.Id = idProvider.Id;
            this.Tasks.Add(task);
            this.logger.Log($"Added task wiht id  {task.Id}");
        }

        public void Delete(int id)
        {
            var taskFound = this.Tasks.SingleOrDefault(t => t.Id == id);

            if (taskFound == null)
            {
                this.logger.Log($"Task with id {id} is not found!");
                return;
            }

            this.Tasks.Remove(taskFound);
            this.logger.Log($"Task with id {id} has been removed!");
        }
    }
}
