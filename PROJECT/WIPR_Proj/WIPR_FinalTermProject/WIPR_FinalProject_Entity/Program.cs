using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIPR_FinalProject_Entity.BS_Layer;
using WIPR_FinalProject_Entity.Interface_Layer;

namespace WIPR_FinalProject_Entity
{
    internal static class Program
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
            new BL_Users().EnsureAdminExists();

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
