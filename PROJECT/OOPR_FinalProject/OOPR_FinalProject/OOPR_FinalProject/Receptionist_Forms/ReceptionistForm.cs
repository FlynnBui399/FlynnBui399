using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPR_FinalProject.Receptionist_Forms;
using static OOPR_FinalProject.Person;

namespace OOPR_FinalProject
{
    public partial class ReceptionistForm : Form, IPrintDetails
    {
        public ReceptionistForm()
        {
            InitializeComponent();
            ShowDetails();
        }

        public string PrintDetails()
        {
            string recep1Name = "Bui Tran Tan Phat";
            string recep1Contact = "090.725.1399";

            string recep2Name = "Nguyen Nhat Phat";
            string recep2Contact = "033.624.3277";

            return $"Receptionist 1: {recep1Name}, Contact: {recep1Contact}" +
                   $"\r\nReceptionist 2: {recep2Name}, Contact: {recep2Contact}";
        }
        public void ShowDetails()
        {
            recepshow_txtbox.Text = PrintDetails();

        }
        private void logo_Click(object sender, EventArgs e)
        {
            ReceptionistForm recptForm = new ReceptionistForm();
            recptForm.Show();
            this.Hide();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private void checkout_Click(object sender, EventArgs e)
        {
            ReceptionistCheckOutForm checkoutForm = new ReceptionistCheckOutForm();
            checkoutForm.Show();
            this.Hide();
        }
        private void checkin_Click(object sender, EventArgs e)
        {
            ReceptionistCheckInForm checkinForm = new ReceptionistCheckInForm();
            checkinForm.Show();
            this.Hide();
        }

    }
}
