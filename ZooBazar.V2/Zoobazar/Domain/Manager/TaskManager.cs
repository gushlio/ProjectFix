using DataAccessLayer;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Manager
{
    public class TaskManager
    {
        private TaskDB taskDB = new TaskDB();

        public void AddTask(Entity.Task task)
        {
            List<string> frequencyList = new List<string>(task.Frequency.Split(','));

            taskDB.AddTask(task.Name, task.Description, task.Location, task.Time, frequencyList); // Update location parameter
        }

        public void UpdateTask(Entity.Task task)
        {
            List<string> frequencyList = new List<string>(task.Frequency.Split(','));

            taskDB.UpdateTask(task.TaskId, task.Name, task.Description, task.Location, task.Time, frequencyList); // Update location parameter
        }

        public List<Entity.Task> GetAllTasks()
        {
            List<Dictionary<string, object>> tasksData = taskDB.GetAllTasks();
            List<Entity.Task> tasks = new List<Entity.Task>();

            foreach (var taskData in tasksData)
            {
                Entity.Task task = new Entity.Task(
                    Convert.ToInt32(taskData["TaskID"]),
                    taskData["Name"].ToString(),
                    taskData["Description"].ToString(),
                    taskData["Location"].ToString(), // Use location as string
                    Convert.ToDateTime(taskData["Time"]),
                    taskData["Frequency"].ToString()
                );
                tasks.Add(task);
            }

            return tasks;
        }

        public void DeleteTask(int taskId)
        {
            taskDB.DeleteTask(taskId);
        }


        public Entity.Task GetTaskById(int taskId)
        {
            Dictionary<string, object> taskData = taskDB.GetTaskById(taskId);

            if (taskData != null)
            {
                return new Entity.Task(
                    Convert.ToInt32(taskData["TaskId"]),
                    taskData["Name"].ToString(),
                    taskData["Description"].ToString(),
                    taskData["Location"].ToString(), // Use location as string
                    Convert.ToDateTime(taskData["Time"]),
                    taskData["Frequency"].ToString()
                );
            }
            else
            {
                return null;
            }
        }

    }
}
