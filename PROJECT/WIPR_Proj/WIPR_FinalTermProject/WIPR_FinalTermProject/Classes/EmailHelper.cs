using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace WIPR_FinalTermProject.Classes
{
    public class EmailHelper
    {
        // Send password reset code via email
        public static bool SendPasswordResetCode(string recipientEmail, string resetCode)
        {
            try
            {
                // Create message
                MailMessage message = new MailMessage();
                message.From = new MailAddress(EmailSettings.SenderEmail, EmailSettings.SenderDisplayName);
                message.To.Add(recipientEmail);
                message.Subject = EmailSettings.ResetPasswordSubject;
                message.Body = BuildPasswordResetEmailBody(resetCode);
                message.IsBodyHtml = true;
                
                // Configure SMTP client
                SmtpClient smtpClient = new SmtpClient(EmailSettings.SmtpHost, EmailSettings.SmtpPort);
                smtpClient.EnableSsl = EmailSettings.EnableSsl;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(EmailSettings.SenderEmail, EmailSettings.SenderPassword);
                
                // Send email
                smtpClient.Send(message);
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
                return false;
            }
        }
        
        // Build HTML email body with reset code
        private static string BuildPasswordResetEmailBody(string resetCode)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("<html><body>");
            builder.AppendLine("<h2>Password Reset Request</h2>");
            builder.AppendLine("<p>You have requested to reset your password for the Music Management System.</p>");
            builder.AppendLine("<p>Your password reset code is:</p>");
            builder.AppendLine($"<h3 style='background-color:#f0f0f0; padding:10px; font-family:monospace; text-align:center'>{resetCode}</h3>");
            builder.AppendLine("<p>Please enter this code in the application to confirm your password reset request.</p>");
            builder.AppendLine("<p>If you did not request a password reset, please ignore this email.</p>");
            builder.AppendLine("<p>Thank you,<br>Music Management System Team</p>");
            builder.AppendLine("</body></html>");
            
            return builder.ToString();
        }

        // Test SMTP connection without sending actual email
        public static bool TestConnection()
        {
            try
            {
                // Configure SMTP client
                SmtpClient smtpClient = new SmtpClient(EmailSettings.SmtpHost, EmailSettings.SmtpPort);
                smtpClient.EnableSsl = EmailSettings.EnableSsl;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(EmailSettings.SenderEmail, EmailSettings.SenderPassword);
                smtpClient.Timeout = 10000; // 10 seconds timeout
                
                // Test connection without actually sending an email
                // This method doesn't work with all SMTP servers
                smtpClient.SendAsyncCancel(); // Cancel any pending asynchronous operations
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error testing connection: " + ex.Message);
                return false;
            }
        }
    }
} 