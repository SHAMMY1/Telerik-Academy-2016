using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Task
    {
        public Task(string description, DateTime? deadline = null)
        {
  
            this.Description = description;
            this.Deadline = deadline;
            this.IsDone = false;
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime? Deadline { get; set; }

        public bool IsDone { get; set; }
    }
}
