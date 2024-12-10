using Microsoft.Win32.SafeHandles;
using OOPR_FinalProject.StartUp_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPR_FinalProject
{
    public partial class GuestBookingForm : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dtb_hotel.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        int Price = 1;
        int Key = 0;
        public GuestBookingForm()
        {
            InitializeComponent();
            populate();
            GetRooms();
            GetGuest();
            guestname_txtbox.Text = GuestInfoForm.CurrentGuest;
            guestID_txtbox.Text = GuestInfoForm.CurrentGuestID.ToString();

        }
        private void populate()
        {
            conn.Open();
            string populate = "SELECT * FROM Bookings";
            da = new OleDbDataAdapter(populate, conn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            rooms_table.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void GetRooms()
        {
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM Rooms WHERE RoomStatus ='Available'", conn);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomID", typeof(int));
            dt.Load(rdr);
            roomchose_cbbox.ValueMember = "RoomID";
            roomchose_cbbox.DataSource = dt;
            conn.Close();
        }
        private void GetGuest()
        {
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM Guests", conn);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("GuestID", typeof(int));
            dt.Load(rdr);
            conn.Close();
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
        private void info_Click(object sender, EventArgs e)
        {
            GuestInfoForm info = new GuestInfoForm();
            info.Show();
            this.Hide();
        }

        private void FetchCost()
        {
            try
            {
                conn.Open();
                string fectcost = "SELECT TypeCost FROM Rooms INNER JOIN Types ON Rooms.RoomType = Types.TypeNum WHERE RoomID = @RoomID";
                cmd = new OleDbCommand(fectcost, conn);
                cmd.Parameters.AddWithValue("@RoomID", roomchose_cbbox.SelectedValue);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Price = Convert.ToInt32(result);
                }
                else
                {
                    Price = 0;
                    HotelMessageBox.Show("No cost data found for the selected room.");
                }
            }
            catch (Exception ex)
            {
                HotelMessageBox.Show("Error fetching cost: " + ex.Message);
                Price = 0;
            }
            finally
            {
                conn.Close();
            }
        }
        private void book_btn_Click(object sender, EventArgs e)
        {
            int guestID = int.Parse(guestID_txtbox.Text);
            if (roomchose_cbbox.SelectedIndex == -1 || amount_txtbox.Text == "" || duration_txtbox.Text == "")
            {
                HotelMessageBox.Show("Missing information!");
            }
            else
            {
                try
                {
                    conn.Open();
                    string inser_booking = "INSERT INTO Bookings (Room, GuestID, CheckInDate,CheckOutDate,Duration, Cost) VALUES (@Room, @Guest, @CheckInDate,@CheckOutDate,@Duration, @Cost) ";
                    cmd = new OleDbCommand(inser_booking, conn);
                    cmd.Parameters.AddWithValue("@Room", roomchose_cbbox.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Guest", guestID);
                    cmd.Parameters.AddWithValue("@ChecKInDate", checkin_datepicker.Value.Date);
                    cmd.Parameters.AddWithValue("@ChecKOutDate", checkout_datepicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Dura", duration_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Cost", amount_txtbox.Text);
                    cmd.ExecuteNonQuery();
                    HotelMessageBox.Show("Room booked!!!");
                    conn.Close();
                    populate();
                    setBooked();
                    GetRooms();
                }
                catch (Exception ex)
                {

                    HotelMessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();

                }
            }
        }
        private void cancelroom_btn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                HotelMessageBox.Show("Select a Room!!!");
            }
            else
            {
                try
                {
                    conn.Open();
                    string cancel_booking = "DELETE FROM Bookings WHERE BookNum = @Bkey";
                    cmd = new OleDbCommand(cancel_booking, conn);
                    cmd.Parameters.AddWithValue("@BKey", Key);
                    cmd.ExecuteNonQuery();
                    HotelMessageBox.Show("Booking has been canceled!!!");
                    conn.Close();
                    populate();
                    setAvailable();
                    GetRooms();
                }
                catch (Exception ex)
                {
                    HotelMessageBox.Show(ex.Message);
                }
            }
        }
        private void checkin_datepicker_ValueChanged(object sender, EventArgs e)
        {
            checkout_datepicker.MinDate = checkin_datepicker.Value.AddDays(1);
            TimeSpan duration = checkout_datepicker.Value.Date - checkin_datepicker.Value.Date;
            duration_txtbox.Text = duration.Days.ToString();
            UpdateTotalCost();
        }
        private void roomchose_cbbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchCost();
        }
        private void duration_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateTotalCost();
            }
            catch (Exception ex)
            {
                HotelMessageBox.Show(ex.Message);
            }
        }
        private void rooms_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomchose_cbbox.Text = rooms_table.SelectedRows[0].Cells[1].Value.ToString();
            guestID_txtbox.Text = rooms_table.SelectedRows[0].Cells[2].Value.ToString();
            checkin_datepicker.Text = rooms_table.SelectedRows[0].Cells[3].Value.ToString();
            checkout_datepicker.Text = rooms_table.SelectedRows[0].Cells[4].Value.ToString();
            duration_txtbox.Text = rooms_table.SelectedRows[0].Cells[4].Value.ToString();
            amount_txtbox.Text = rooms_table.SelectedRows[0].Cells[5].Value.ToString();
            if (amount_txtbox.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(rooms_table.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void rooms_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < rooms_table.Rows.Count)
            {
                var selectedRow = rooms_table.Rows[e.RowIndex];
                roomchose_cbbox.Text = selectedRow.Cells[1].Value.ToString() ?? string.Empty;
                guestID_txtbox.Text = selectedRow.Cells[2].Value.ToString() ?? string.Empty;
                checkin_datepicker.Text = selectedRow.Cells[3].Value.ToString() ?? string.Empty;
                checkout_datepicker.Text = selectedRow.Cells[4].Value.ToString() ?? string.Empty;
                duration_txtbox.Text = selectedRow.Cells[5].Value.ToString() ?? string.Empty;
                amount_txtbox.Text = selectedRow.Cells[6].Value.ToString() ?? string.Empty;

                duration_txtbox.Text = selectedRow.Cells[3].Value.ToString() ?? string.Empty; ;
                if (guestID_txtbox.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    if (int.TryParse(selectedRow.Cells[0].Value?.ToString(), out int keyValue))
                    {
                        Key = keyValue;
                    }
                    else
                    {
                        Key = 0;
                    }
                }
            }
        }
        private void UpdateTotalCost()
        {
            try
            {
                if (int.TryParse(duration_txtbox.Text, out int duration) && Price > 0)
                {
                    int totalCost = Price * duration;
                    amount_txtbox.Text = totalCost.ToString("C0", CultureInfo.CurrentCulture);
                }
                else
                {
                    amount_txtbox.Text = "Rs 0";
                }
            }
            catch (Exception ex)
            {
                HotelMessageBox.Show("Error calculating total cost: " + ex.Message);
            }
        }
        private void checkout_datepicker_ValueChanged(object sender, EventArgs e)
        {
            checkout_datepicker.MinDate = checkin_datepicker.Value.AddDays(1);
            TimeSpan duration = checkout_datepicker.Value.Date - checkin_datepicker.Value.Date;
            duration_txtbox.Text = duration.Days.ToString();
            UpdateTotalCost();
        }

        private void setBooked()
        {
            try
            {
                conn.Open();
                string editroom = "UPDATE ROOMS SET RoomStatus=@RS WHERE RoomID = @RKey";
                cmd = new OleDbCommand(editroom, conn);
                cmd.Parameters.AddWithValue("@RS", "Booked");
                cmd.Parameters.AddWithValue("@RKey", roomchose_cbbox.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                HotelMessageBox.Show("Room Updated!!!");
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                HotelMessageBox.Show(ex.Message);
            }
        }
        private void setAvailable()
        {
            try
            {
                conn.Open();
                string editroom = "UPDATE ROOMS SET RoomStatus=@RS WHERE RoomID = @RKey";
                cmd = new OleDbCommand(editroom, conn);
                cmd.Parameters.AddWithValue("@RS", "Available");
                cmd.Parameters.AddWithValue("@RKey", roomchose_cbbox.Text);
                cmd.ExecuteNonQuery();
                HotelMessageBox.Show("Room Updated!!!");
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                HotelMessageBox.Show(ex.Message);
            }
        }

        private void roomchose_cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
