using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class TaskManager
    {

        private readonly List<TaskItem> _tasks = new List<TaskItem>();

        public IReadOnlyList<TaskItem> Tasks => _tasks.AsReadOnly();

      
        public void Add(string description, string notes = "")
        {
            if (!string.IsNullOrWhiteSpace(description))
                _tasks.Add(new TaskItem(description.Trim(), notes.Trim()));
        }


        public void Remove(TaskItem task)
        {
            if (task != null)
                _tasks.Remove(task);
        }


        public void Complete(TaskItem task)
        {
            if (task != null)
                task.IsCompleted = true;
        }

        public void ClearAll()
        {
            _tasks.Clear();
        }
        // ——— Persistence ———

        //Save to JSON file
        public void Save(string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(_tasks, options);
            File.WriteAllText(filePath, json);
        }

        public void Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }

            var json = File.ReadAllText(filePath);
            var items = JsonSerializer.Deserialize<List<TaskItem>>(json);
            _tasks.Clear();
            if (items != null)
            {
                _tasks.AddRange(items);


            }
        }
    }
}
