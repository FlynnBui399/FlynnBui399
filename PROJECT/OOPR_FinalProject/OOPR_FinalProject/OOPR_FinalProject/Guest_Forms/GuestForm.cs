using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPR_FinalProject
{
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }


        private void info_Click(object sender, EventArgs e)
        {
            GuestInfoForm info = new GuestInfoForm();
            info.Show();
            this.Hide();
        }

        private void booking_Click(object sender, EventArgs e)
        {
            GuestInfoForm info = new GuestInfoForm();
            info.Show();
            this.Hide();
        }
        private void services_Click(object sender, EventArgs e)
        {
            GuestInfoForm info = new GuestInfoForm();
            info.Show();
            this.Hide();
        }


        private void logout_icon_Click(object sender, EventArgs e)//Take this as Log Out
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void viewroom_btn_Click(object sender, EventArgs e)
        {

            OOPR_FinalProject.Guest_Forms.RoomAvailableForm availableRoomForm = new OOPR_FinalProject.Guest_Forms.RoomAvailableForm();
            availableRoomForm.Show(); 
            this.Hide(); 
            
           
        }
    }
}
