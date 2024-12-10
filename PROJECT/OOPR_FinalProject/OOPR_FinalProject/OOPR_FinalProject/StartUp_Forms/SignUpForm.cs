using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Data.Common;
using OOPR_FinalProject.StartUp_Forms;

namespace OOPR_FinalProject
{
    public partial class SignUpForm : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dtb_hotel.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public SignUpForm()
        {
            InitializeComponent();

        }

        private void cancel_label_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (txtPassword.Text == "" || txtUsername.Text == "")
            {
                HotelMessageBox.Show("Blank user name or Password. Please try again!", "Sign Up Failed");
            }
            else if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                try {
                   con.Open();
                string signup = "INSERT INTO Accounts VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                cmd = new OleDbCommand(signup, con);
                cmd.ExecuteNonQuery();
                con.Close();

                HotelMessageBox.Show("Your Account has been successfully created!", "Sign Up Success");
                txtPassword.Text = "";
                txtUsername.Text = "";

                 }
                catch(Exception ex)
                {
                    HotelMessageBox.Show(ex.Message);
                    con.Close();
                }
                
               
            }
            else
            {
                HotelMessageBox.Show("Something went wrong. Please try again!", "Sign Up Failed");
                txtPassword.Text = "";
                txtUsername.Text = "";
            }


        }

        private void clear_label_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}
