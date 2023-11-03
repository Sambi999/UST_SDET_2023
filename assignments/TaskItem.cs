using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class TaskItem
    {

        public int TaskId { get; set; }
        public string? TaskDescripion { get; set; }
        public string? IsCompleted { get; set; }
        public static List<TaskItem> toDoList = new List<TaskItem>();

        public TaskItem(int taskId, string? taskDescripion, string? isCompleted)
        {
            TaskId = taskId;
            TaskDescripion = taskDescripion;
            IsCompleted = isCompleted;
        }
        public static void AddTodo(TaskItem taskItem)
        {
            toDoList.Add(taskItem);

        }

        public static void updateList(int taskid, string? isCompleted)
        {
            var data = toDoList.Find(x => x.TaskId == taskid);
            if (data != null)
            {
                data.IsCompleted = isCompleted;
                Console.WriteLine($"{data.TaskId}\n{data.TaskDescripion}\n{data.IsCompleted}");
            }
        }
        public static void Remove(int task_id)
        {
            var data = toDoList.RemoveAll(y => y.TaskId == task_id);

        }
        public static void Display(string? msg)
        {
            var data = toDoList.FindAll(s => s.IsCompleted == msg);
            if (data != null)
            {
                foreach (var item in data)
                {
                    Console.WriteLine($"Task Id:{item.TaskId}\nTask Description:{item.TaskDescripion}\n");
                }
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
    }
}
