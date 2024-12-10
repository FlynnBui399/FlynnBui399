using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPR_FinalProject.StartUp_Forms;

namespace OOPR_FinalProject.Receptionist_Forms
{
    public partial class ReceptionistCheckOutForm : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dtb_hotel.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public ReceptionistCheckOutForm()
        {
            InitializeComponent();
            populate();
            GetRooms();
            GetCustomers();
        }
        private void populate()
        {
            con.Open();
            string populate = "SELECT * FROM Bookings";
            da = new OleDbDataAdapter(populate, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            reservation_table.DataSource = ds.Tables[0];
            con.Close();
        }
        private void GetRooms()
        {
            con.Open();
            string get_room = "SELECT * FROM Rooms WHERE RoomStatus = 'Booked'";
            cmd = new OleDbCommand(get_room, con);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomID", typeof(int));
            dt.Load(rdr);
            roomid_cbbox.ValueMember = "RoomID";
            roomid_cbbox.DataSource = dt;
            con.Close();
        }
        private void GetCustomers()
        {
            con.Open();
            string get_customers = "SELECT * FROM Guests";
            cmd = new OleDbCommand(get_customers, con);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("GuestID", typeof(int));
            dt.Load(rdr);
            customer_cbbox.ValueMember = "GuestID";
            customer_cbbox.DataSource = dt;
            con.Close();
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
        private void checkin_Click(object sender, EventArgs e)
        {
            ReceptionistCheckInForm checkinForm = new ReceptionistCheckInForm();
            checkinForm.Show();
            this.Hide();
        }
        private void find_button_Click(object sender, EventArgs e)
        {
            con.Open();

            string find = "SELECT * FROM Bookings WHERE Room = @RKey AND GuestID =  @GI AND CheckOutDate=@CO";
            cmd = new OleDbCommand(find, con);

            cmd.Parameters.AddWithValue("@Rkey", int.Parse(roomid_cbbox.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@GI", int.Parse(customer_cbbox.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@CO", checkout_datepicker.Value.Date);

            da = new OleDbDataAdapter(cmd);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();

            da.Fill(ds);
            reservation_table.DataSource = ds.Tables[0];
            con.Close();
        }

        private void invoice_btn_Click(object sender, EventArgs e)
        {


           
            string invoice = "SELECT Guests.GuestName, Bookings.Room, " +
                 "SUM(Bookings.Cost) AS TotalCost, Bookings.CheckOutDate, Bookings.GuestID " +
                 "FROM Bookings, Guests " +
                 "WHERE Bookings.GuestID = Guests.GuestID " +
                 "AND Bookings.Room = @RoomID " +
                 "AND Bookings.GuestID = @GuestID " +
                 "AND Bookings.CheckOutDate = @CheckOutDate " +
                 "GROUP BY Guests.GuestName, Bookings.Room, Bookings.CheckOutDate, Bookings.GuestID";
            try
            {
                con.Open();
                cmd = new OleDbCommand(invoice, con);
                cmd.Parameters.AddWithValue("@RoomID", roomid_cbbox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@GuestID", customer_cbbox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@CheckOutDate", checkout_datepicker.Value.Date);
            }
            catch (Exception ex)
            {
                HotelMessageBox.Show(ex.Message);
            }
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (s, ev) =>
                {
                    float startX = 100;
                    float startY = 100;
                    float lineSpacing = 30;
                    
                    ev.Graphics.DrawString("INVOICE", new Font("Candara", 20, FontStyle.Bold), Brushes.Black, new PointF(startX, startY));
                    startY += lineSpacing;
                    ev.Graphics.DrawString("Customer ID: " + reader["GuestID"].ToString(), new Font("Candara", 12), Brushes.Black, new PointF(startX, startY));
                    startY += lineSpacing;
                    ev.Graphics.DrawString("Customer Name: " + reader["GuestName"].ToString(), new Font("Candara", 12), Brushes.Black, new PointF(startX, startY));
                    startY += lineSpacing;
                    ev.Graphics.DrawString("Room ID: " + reader["Room"].ToString(), new Font("Candara", 12), Brushes.Black, new PointF(startX, startY));
                    startY += lineSpacing;
                    ev.Graphics.DrawString("Check Out Date: " + reader["CheckOutDate"].ToString(), new Font("Candara", 12), Brushes.Black, new PointF(startX, startY));
                    startY += lineSpacing;
                    ev.Graphics.DrawString( "Total Price: $" + (reader["TotalCost"] != DBNull.Value ? reader["TotalCost"].ToString() : "0"),   new Font("Candara", 12),Brushes.Black, new PointF(startX, startY));
                };

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            else
            {
                HotelMessageBox.Show("Cannot find the room!!!");
            }
            con.Close();
        }
    }
}
