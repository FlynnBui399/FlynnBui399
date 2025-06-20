using System;

namespace WIPR_FinalTermProject.Classes
{
    public static class EmailSettings
    {
        // SMTP server settings
        public static string SmtpHost { get; set; } = "smtp.gmail.com";
        public static int SmtpPort { get; set; } = 587;
        public static bool EnableSsl { get; set; } = true;
        
        // Sender credentials
        public static string SenderEmail { get; set; } = "poseidont1203@gmail.com"; 
        public static string SenderPassword { get; set; } = "gcjp kknu vabv bevm\r\n";  
        public static string SenderDisplayName { get; set; } = "TEAM03 - Music Management System";
        
        // Email content settings
        public static string ResetPasswordSubject { get; set; } = "Music Management System - Password Reset Code";
    }
} 