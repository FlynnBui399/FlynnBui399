using System;
using System.Windows.Forms;
using WIPR_FinalTermProject.BS_layer;
using WIPR_FinalTermProject.Forms_layer;

namespace WIPR_FinalTermProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Ensure admin account exists when application starts
            new UserBLL().EnsureAdminExists();
            
            // Show login form first
            FormLogin loginForm = new FormLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMain());
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
