using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPR_FinalProject.Manager_Forms;
using static OOPR_FinalProject.Person;

namespace OOPR_FinalProject
{
    public partial class ManagerForm : Form, IPrintDetails
    {
        public ManagerForm()
        {

            
            InitializeComponent();
            ShowDetails();  
        }
        public string PrintDetails()
        {
            string manager1Name = "Bui Tran Tan Phat";
            string manager1Contact = "090.725.1399";

            string manager2Name = "Nguyen Nhat Phat";
            string manager2Contact = "033.624.3277";

            return $"Manager 1: {manager1Name}, Contact: {manager1Contact}" +
                   $"\r\nManager 2: {manager2Name}, Contact: {manager2Contact}";
        }
        public void ShowDetails()
        {  
            managershow_txtbox.Text=PrintDetails();
           
        }
        private void logo_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
            this.Hide();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private void category_Click(object sender, EventArgs e)
        {
            ManagerCategoryForm managerCategoryForm = new ManagerCategoryForm();
            managerCategoryForm.Show();
            this.Hide();
        }
        private void room_Click(object sender, EventArgs e)
        {
            ManagerRoomForm roomForm = new ManagerRoomForm();
            roomForm.Show();
            this.Hide();
        }
        private void report_Click(object sender, EventArgs e)
        {
            ManagerReportForm reportForm = new ManagerReportForm();
            reportForm.Show();
            this.Hide();
        }
    }
}
