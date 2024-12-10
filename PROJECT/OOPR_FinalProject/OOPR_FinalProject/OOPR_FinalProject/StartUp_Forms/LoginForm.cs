using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPR_FinalProject.StartUp_Forms;

namespace OOPR_FinalProject
{
    public partial class LoginForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dtb_hotel.accdb;";
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dtb_hotel.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private Dictionary<string, string> managers = new Dictionary<string, string>()
        {
            { "manager", "manager" }

        };
        private Dictionary<string, string> receptionists = new Dictionary<string, string>()
        {

            { "receptionist", "receptionist" }

        };
        public LoginForm()
        {
            InitializeComponent();

        }


        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            con.Open();
            string login = "SELECT * FROM Accounts WHERE Username = '" + username + "' and Password = '" + password + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true && guest_rdbtn.Checked)
            {
                HotelMessageBox.Show("Login successful!");
                GuestInfoForm guestInfoForm = new GuestInfoForm();
                guestInfoForm.Show();
                this.Hide();
                con.Close();
            }
            else if (managers.ContainsKey(username) && managers[username] == password && manager_rdbtn.Checked)
            {
                HotelMessageBox.Show("Login successful!");
                ManagerForm managerForm = new ManagerForm();
                managerForm.Show();
                this.Hide();
            }
            else if (receptionists.ContainsKey(username) && receptionists[username] == password && receptionist_rdbtn.Checked)
            {
                HotelMessageBox.Show("Login successful!");
                ReceptionistForm receptionistForm = new ReceptionistForm();
                receptionistForm.Show();
                this.Hide();
            }
            else
            {
                HotelMessageBox.Show("Invalid username or password.");
                con.Close();
            }

        }

        private void show_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (show_cb.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

            }
        }

        private void guest_rdbtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
