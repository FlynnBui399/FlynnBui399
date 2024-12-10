using Microsoft.VisualBasic.Logging;
using OOPR_FinalProject.StartUp_Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOPR_FinalProject.Person;

namespace OOPR_FinalProject
{
    public partial class GuestInfoForm : Form, IPrintDetails
    {
        int Key = 0;
        public static int CurrentGuestID { get; private set; }
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dtb_hotel.accdb;";
        private OleDbConnection conn;
        private OleDbCommand cmd;
        OleDbDataAdapter da = new OleDbDataAdapter();
        public static string CurrentGuest { get; private set; }
        public GuestInfoForm()
        {
            conn = new OleDbConnection(connectionString);
           
            InitializeComponent(); detail_txtbox.Visible = false;

        }
        public string PrintDetails()
        {
            string gender = gender_cbbox.SelectedItem.ToString();
            return $"Name: {txtFullname.Text}. \nContact: {contact_txtbox.Text}. \nGender: {gender}.";
        }


        private void logo_Click(object sender, EventArgs e)
        {
            GuestForm guestForm = new GuestForm();
            guestForm.Show();
            this.Hide();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private void booking_Click(object sender, EventArgs e)
        {
            GuestBookingForm info = new GuestBookingForm();
            info.Show();
            this.Hide();
        }

        private void SaveGuestInfor()
        {

            string fullname = txtFullname.Text;
            string contact = contact_txtbox.Text;
            string gender = gender_cbbox.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(gender))
            {
                HotelMessageBox.Show("Please enter both Full Name and Contact.");
                return;
            }

            try
            {
                conn.Open();
                string inser_guest_name = "INSERT INTO Guests (GuestName, GuestPhone, GuestGender) VALUES (@Fullname, @Contact,@Gender)";
                cmd = new OleDbCommand(inser_guest_name, conn);
                cmd.Parameters.AddWithValue("@FullName", fullname);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@Gender", gender_cbbox.SelectedItem.ToString());
                HotelMessageBox.Show("Data saved successfully.");
                cmd.ExecuteNonQuery();
                string getGuestID = "SELECT @@IDENTITY";
                cmd = new OleDbCommand(getGuestID, conn);
                int guestID = Convert.ToInt32(cmd.ExecuteScalar());
                CurrentGuestID = guestID;
                CurrentGuest = fullname;
                detail_txtbox.Text = PrintDetails();
            }
            catch (Exception ex)
            {
                HotelMessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveGuestInfor();
            txtFullname.Enabled = false;
            contact_txtbox.Enabled = false;
            gender_cbbox.Enabled = false;
            HotelMessageBox.Show(PrintDetails(), "Guest Information");
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (txtFullname.Enabled == false && contact_txtbox.Enabled == false && gender_cbbox.Enabled == false)
            {
                txtFullname.Enabled = true;
                contact_txtbox.Enabled = true;
                gender_cbbox.Enabled = true;

            }
            else if (txtFullname.Text == "" || gender_cbbox.SelectedIndex == -1 || contact_txtbox.Text == "")
            {
                HotelMessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    conn.Open();
                    string editinfor = "UPDATE Guests SET GuestName=@GN,GuestPhone=@GP,GuestGender=@GG";
                    cmd = new OleDbCommand(editinfor, conn);
                    cmd.Parameters.AddWithValue("@GN", txtFullname.Text.ToString());
                    cmd.Parameters.AddWithValue("@GP", contact_txtbox.Text.ToString());
                    cmd.Parameters.AddWithValue("@GG", Key);
                    HotelMessageBox.Show("User Information has been editted!!!");
                    txtFullname.Enabled = false;
                    contact_txtbox.Enabled = false;
                    gender_cbbox.Enabled = false;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    HotelMessageBox.Show(ex.Message);
                }
            }
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
