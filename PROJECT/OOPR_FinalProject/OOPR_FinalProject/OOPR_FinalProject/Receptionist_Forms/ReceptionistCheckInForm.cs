using OOPR_FinalProject.StartUp_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPR_FinalProject.Receptionist_Forms
{
    public partial class ReceptionistCheckInForm : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dtb_hotel.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public ReceptionistCheckInForm()
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
        private void checkout_Click(object sender, EventArgs e)
        {
            ReceptionistCheckOutForm checkoutForm = new ReceptionistCheckOutForm();
            checkoutForm.Show();
            this.Hide();

        }

        private void find_button_Click(object sender, EventArgs e)
        {

            con.Open();
            
            string find = "SELECT * FROM Bookings WHERE Room = @RKey AND GuestID =  @GI AND CheckInDate=@CI";
            cmd = new OleDbCommand(find, con);

            cmd.Parameters.AddWithValue("@Rkey", int.Parse(roomid_cbbox.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@GI", int.Parse(customer_cbbox.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@CI", checkin_datepicker.Value.Date);

            da = new OleDbDataAdapter(cmd);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();

            da.Fill(ds);
            reservation_table.DataSource = ds.Tables[0];
            con.Close();
        }
           

        }
    }

