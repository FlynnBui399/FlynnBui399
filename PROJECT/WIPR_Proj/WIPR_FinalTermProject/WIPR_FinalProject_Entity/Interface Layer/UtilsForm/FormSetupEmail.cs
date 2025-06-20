using System;
using System.Windows.Forms;
using WIPR_FinalProject_Entity.Classes;

namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormSetupEmail : Form
    {
        public FormSetupEmail()
        {
            InitializeComponent();
        }

        private void FormSetupEmail_Load(object sender, EventArgs e)
        {
            // Load current email configuration
            txtSmtpHost.Text = EmailSettings.SmtpHost;
            txtSmtpPort.Text = EmailSettings.SmtpPort.ToString();
            chkEnableSsl.Checked = EmailSettings.EnableSsl;

            txtSenderEmail.Text = EmailSettings.SenderEmail;
            txtSenderName.Text = EmailSettings.SenderDisplayName;
            txtPassword.Text = EmailSettings.SenderPassword;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input data
            if (string.IsNullOrEmpty(txtSmtpHost.Text) || string.IsNullOrEmpty(txtSmtpPort.Text) ||
                string.IsNullOrEmpty(txtSenderEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSmtpPort.Text, out int port))
            {
                MessageBox.Show("SMTP Port must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSmtpPort.Focus();
                return;
            }

            // Save email configuration
            EmailSettings.SmtpHost = txtSmtpHost.Text;
            EmailSettings.SmtpPort = port;
            EmailSettings.EnableSsl = chkEnableSsl.Checked;

            EmailSettings.SenderEmail = txtSenderEmail.Text;
            EmailSettings.SenderDisplayName = txtSenderName.Text;
            EmailSettings.SenderPassword = txtPassword.Text;

            MessageBox.Show("Email settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            // Save current configuration temporarily
            string originalHost = EmailSettings.SmtpHost;
            int originalPort = EmailSettings.SmtpPort;
            bool originalSsl = EmailSettings.EnableSsl;
            string originalEmail = EmailSettings.SenderEmail;
            string originalName = EmailSettings.SenderDisplayName;
            string originalPassword = EmailSettings.SenderPassword;

            // Apply new configuration for testing
            if (!int.TryParse(txtSmtpPort.Text, out int port))
            {
                MessageBox.Show("SMTP Port must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSmtpPort.Focus();
                return;
            }

            EmailSettings.SmtpHost = txtSmtpHost.Text;
            EmailSettings.SmtpPort = port;
            EmailSettings.EnableSsl = chkEnableSsl.Checked;
            EmailSettings.SenderEmail = txtSenderEmail.Text;
            EmailSettings.SenderDisplayName = txtSenderName.Text;
            EmailSettings.SenderPassword = txtPassword.Text;

            // Test connection
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bool success = EmailHelper.TestConnection();
                this.Cursor = Cursors.Default;

                if (success)
                {
                    MessageBox.Show("Connection test successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Connection test failed. Please check your settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show($"Error: {ex.Message}", "Connection Test Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restore original configuration if not saved
                EmailSettings.SmtpHost = originalHost;
                EmailSettings.SmtpPort = originalPort;
                EmailSettings.EnableSsl = originalSsl;
                EmailSettings.SenderEmail = originalEmail;
                EmailSettings.SenderDisplayName = originalName;
                EmailSettings.SenderPassword = originalPassword;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}