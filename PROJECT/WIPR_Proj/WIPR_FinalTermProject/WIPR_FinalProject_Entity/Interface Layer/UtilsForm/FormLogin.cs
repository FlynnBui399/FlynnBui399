using System;
using System.Windows.Forms;
using WIPR_FinalProject_Entity.BS_Layer;

namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormLogin : Form
    {
        private BL_Users userBLL = new BL_Users();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userBLL.Login(username, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Registration successful. You can now log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgotPassword form = new FormForgotPassword();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Password reset successful. You can now log in with your new password.", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '•';
        }
    }
}