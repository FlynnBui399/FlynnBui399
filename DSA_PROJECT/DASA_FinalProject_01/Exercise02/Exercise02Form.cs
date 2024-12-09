using DASA_FinalProject_01.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DASA_FinalProject_01
{
    public partial class Exercise02Form : Form
    {
        private Queue task = new Queue();
        private Queue.Task selectedTask = null;
        public Exercise02Form()
        {
            InitializeComponent();
            txtId.Text = task.GetNextID().ToString();
            txtId.Enabled = false;
            txtName.Enabled = true;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = txtName.Text;
            if (taskName.Length > 20)
            {
                OurMessageBox.Show("Task name can not >= 20 characters");
                return;
            }
            if (lstTask.Items.Cast<string>().Any(item => item.Split("- Task:")[1].Trim().Equals(taskName, StringComparison.OrdinalIgnoreCase)))
            {
                OurMessageBox.Show("A task with the same name already exists");
                return;
            }
            txtId.Text = task.GetNextID().ToString();
            if (!string.IsNullOrEmpty(taskName))
            {

                task.Enqueue(taskName);
                OurMessageBox.Show($"Task '{taskName}' was added");
                lstTask.Items.Add($"{txtId.Text} - Task: {taskName}");
                txtName.Clear();
                txtId.Text = task.GetNextID().ToString();
            }
            else
            {
                OurMessageBox.Show("Please enter valid task details!!!");
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string completedTask = task.Dequeue();
            if (completedTask != null)
            {
                OurMessageBox.Show($"Task '{completedTask}' is completed");
                txtName.Clear();
                txtId.Clear();
                task.SortQueue();
                //task.ReassignIDs();
                lstTask.Items.Clear();
                List<Queue.Task> tasks = task.GetTasks();
                for (int i = 0; i < tasks.Count; i++)
                {
                    tasks[i].ID = i + 1;
                }
                foreach (var t in tasks)
                {
                    lstTask.Items.Add($"{t.ID} - Task: {t.Name}");
                }
            }
        }
        private void lstTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTask.SelectedIndex != -1)
            {
                var selectedItem = lstTask.SelectedItem.ToString();
                int taskId = int.Parse(selectedItem.Split(new string[] { " - Task: " }, StringSplitOptions.None)[0].Trim());

                if (selectedTask != null && selectedTask.ID == taskId)
                {
                    lstTask.SelectedIndex = -1;
                    txtId.Clear();
                    txtName.Clear();
                    txtId.Enabled = false;
                    selectedTask = null;
                }
                else
                {
                    selectedTask = task.GetTasks().FirstOrDefault(t => t.ID == taskId);
                    if (selectedTask != null)
                    {
                        txtId.Enabled = true;
                        txtId.Text = selectedTask.ID.ToString();
                        txtName.Text = selectedTask.Name;
                    }
                }
            }
            else
            {
                txtId.Enabled = false;
                txtId.Clear();
                txtName.Clear();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedTask != null)
            {
                int newId;
                string updatedName = txtName.Text;

                if (string.IsNullOrEmpty(updatedName))
                {
                    OurMessageBox.Show("Please enter a valid task name");
                    return;
                }
                if (updatedName != selectedTask.Name)
                {
                    selectedTask.Name = txtName.Text;
                }
                bool idChanged = int.TryParse(txtId.Text, out newId) && newId > 0;
                if (!idChanged || newId <= 0)
                {
                    OurMessageBox.Show("Please enter a priority greater than 0");
                    return;
                }
                List<Queue.Task> tasks = task.GetTasks();
                if (newId > tasks.Count)
                {
                    OurMessageBox.Show($"Priority cannot exceed the number of tasks ({tasks.Count})");
                    return;
                }
                if (idChanged && newId != selectedTask.ID)
                {
                    var existingTask = tasks.FirstOrDefault(t => t.ID == newId);
                    if (existingTask != null)
                    {
                        string tempName = existingTask.Name;
                        existingTask.Name = selectedTask.Name;
                        selectedTask.Name = tempName;
                        selectedTask.ID = newId;
                        existingTask.ID = selectedTask.ID == newId ? existingTask.ID : selectedTask.ID;
                    }
                    else
                    {
                        selectedTask.ID = newId;
                    }
                }
                task.SortQueue();
                lstTask.Items.Clear();
                foreach (var t in task.GetTasks())
                {
                    lstTask.Items.Add($"{t.ID} - Task: {t.Name}");
                }
                OurMessageBox.Show($"Task has been updated");
                txtId.Enabled = false;
                txtName.Clear();
                txtId.Clear();
                selectedTask = null;
            }
            else
            {
                OurMessageBox.Show("Please select a task to edit");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstTask.SelectedIndex >= 0)
            {
                List<Queue.Task> tasks = task.GetTasks();
                Queue.Task taskToRemove = tasks[lstTask.SelectedIndex];
                task.Remove(taskToRemove);
                task.ReassignIDs();
                task.SortQueue();
                lstTask.Items.Clear();
                foreach (var t in task.GetTasks())
                {
                    lstTask.Items.Add($"{t.ID} - Task: {t.Name}");
                }
                OurMessageBox.Show("Task has been deleted");
                txtId.Enabled = false;
                txtName.Clear();
                txtId.Clear();
            }
            else
            {
                OurMessageBox.Show("Please select a task to delete");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            task.Clear();
            OurMessageBox.Show("The list is empty right now!");
            task.ReassignIDs();
            lstTask.Items.Clear();
            txtId.Clear();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            StartUpForm startUpForm = new StartUpForm();
            startUpForm.Show();
        }
    }
}
