using System;
using System.Windows.Forms;
using WIPR_FinalProject_Entity.BS_Layer;

namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormForgotPassword : Form
    {
        private BL_Users userBLL = new BL_Users();

        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void btnRequestReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Call RequestPasswordReset method from UserBLL
            string resetCode = userBLL.RequestPasswordReset(email);
            
            if (resetCode != null)
            {
                // Display message that reset code has been sent to email
                MessageBox.Show($"A password reset code has been sent to {email}. Please check your email and enter the code to reset your password.", 
                    "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open reset password form
                FormResetPassword resetForm = new FormResetPassword(email, resetCode);
                if (resetForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Your password has been reset successfully. You can now login with your new password.", 
                        "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Email address not found in our system. Please check your email address or contact support.", 
                    "Email Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}