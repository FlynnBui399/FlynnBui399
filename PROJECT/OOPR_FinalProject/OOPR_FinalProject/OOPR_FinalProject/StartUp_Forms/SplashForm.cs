using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPR_FinalProject
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            percentage_label.Text = "0%";
            
            // Note: This is where progressing bar begins
            Thread loadingThread = new Thread(new ThreadStart(SimulateLoading));
            loadingThread.Start();
        }

        private void SimulateLoading()
        {
            for (int i = 0; i <= 100; i++)
            {
                // Simulate work being done
                Thread.Sleep(50); // Simulate time delay for loading
              
                this.Invoke((MethodInvoker)delegate {
                    progressBar.Value = i;
                    percentage_label.Text = i + "%";
                });
            }

            this.Invoke((MethodInvoker)delegate {
                GuestForm guestForm = new GuestForm();
                guestForm.Show();
                this.Hide();
                
            });
        }
    }
}
