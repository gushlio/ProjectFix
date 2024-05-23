using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Task
    {
        public int TaskId { get; }
        public string Name { get; }
        public string Description { get; }
        public string Location { get; }
        public DateTime Time { get; }
        public string Frequency { get; }

        public Task(int taskId, string name, string description, string location, DateTime time, string frequency)
        {
            TaskId = taskId;
            Name = name;
            Description = description;
            Location = location;
            Time = time;
            Frequency = frequency;
        }
    }
}
