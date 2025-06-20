using System;
using System.Windows.Forms;
using WIPR_FinalProject_Entity.BS_Layer;

namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormResetPassword : Form
    {
        private BL_Users userBLL = new BL_Users();
        private string email;
        private string resetCode;

        public FormResetPassword(string email, string resetCode)
        {
            InitializeComponent();
            this.email = email;
            this.resetCode = resetCode;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string enteredCode = txtResetCode.Text.Trim();
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(enteredCode) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            if (enteredCode != resetCode)
            {
                MessageBox.Show("The reset code you entered is incorrect.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResetCode.Focus();
                return;
            }

            // Call ResetPassword method from UserBLL
            if (userBLL.ResetPassword(email, newPassword))
            {
                MessageBox.Show("Your password has been reset successfully.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occurred while resetting your password.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}