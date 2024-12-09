using DASA_FinalProject_01.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DASA_FinalProject_01.Queue;


namespace DASA_FinalProject_01
{
    public class Queue
    {   
        private Task pFront; 
        private Task pRear;
        private int nextID;
        public class Task
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public Task Next;
        }
        public Queue()
        {
            pFront = null;
            pRear = null;
            nextID = 1;
        }
        public void SortQueue()
        {
            List<Task> tasks = GetTasks();

            tasks.Sort((t1, t2) => t1.ID.CompareTo(t2.ID));

            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].ID = i + 1;
            }

            pFront = null;
            pRear = null;
            nextID = 1;

            foreach (var task in tasks)
            {
                Enqueue(task.Name);
            }
        }
        public int GetNextID()
        {
            return nextID;
        }
        public bool IsEmpty()
        {
            return pFront == null;
        }

        public void Enqueue(string taskName)
        {
            Task newTask = new Task { Name = taskName, ID = nextID++, Next = null };

            if (IsEmpty())
            {
                pFront = newTask;
                pRear = newTask;
            }
            else
            {
                pRear.Next = newTask;
                pRear = newTask;
            }
        }
        public string Dequeue()
        {
            if (IsEmpty())
            {
                OurMessageBox.Show("No task to finish");
                return null;
            }
            string dequeuedTask = pFront.Name;
            pFront = pFront.Next;
            if (pFront == null)
            {
                pRear = null;
            }
            return dequeuedTask;
        }
        public void Remove(Task taskToRemove)
        {
            if (IsEmpty())
            {
                OurMessageBox.Show("No tasks to remove");
                return;
            }
            if (pFront == taskToRemove)
            {
                pFront = pFront.Next;
                if (pFront == null) 
                {
                    pRear = null;
                }
                return;
            }
            Task current = pFront;
            while (current != null && current.Next != taskToRemove)
            {
                current = current.Next;
            }
            if (current == null || current.Next == null)
            {
                OurMessageBox.Show("Task not found");
                return;
            }
            current.Next = current.Next.Next;
            if (current.Next == null)
            {
                pRear = current;
            }
        }
        public string FrontTask()
        {
            if (IsEmpty())
            {
                OurMessageBox.Show("No task was added");
                return null;
            }

            return pFront.Name;
        }
        public List<Task> GetTasks()
        {
            List<Task> tasks = new List<Task>();
            Task current = pFront;
            while (current != null)
            {
                tasks.Add(current);
                current = current.Next;
            }
            return tasks;
        }
        public void ReassignIDs()
        {
            int newID = 1;
            Task current = pFront;

            while (current != null)
            {
                current.ID = newID++;
                current = current.Next;
            }
            nextID = 1;
        }
        public void Clear()
        {
            pFront = null;
            pRear = null;
        }
    }
}
