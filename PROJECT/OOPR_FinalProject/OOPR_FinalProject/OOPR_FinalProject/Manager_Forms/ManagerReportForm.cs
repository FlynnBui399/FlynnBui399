using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPR_FinalProject.Manager_Forms;

namespace OOPR_FinalProject
{
    public partial class ManagerReportForm : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dtb_hotel.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public ManagerReportForm()
        {
            InitializeComponent();
            Count_Rooms();
            Count_Customers();
            Total_Finance();
            Get_Customers();

        }
        private void Count_Rooms()
        {
            con.Open();
            string count = "SELECT COUNT(*) FROM Rooms";
            OleDbDataAdapter sda = new OleDbDataAdapter(count, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rp_room_label.Text = dt.Rows[0][0].ToString() + "\t Room(s)";
            con.Close();
        }
        private void Count_Customers()
        {
            con.Open();
            string count = "SELECT COUNT(*) FROM Guests";
            OleDbDataAdapter sda = new OleDbDataAdapter(count, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rp_customer_label.Text = dt.Rows[0][0].ToString() + "\t Customer(s)";
            con.Close();
        }
        private void Total_Finance()
        {
            con.Open();
            string sum = "SELECT SUM(Cost) FROM Bookings";
            OleDbDataAdapter sda = new OleDbDataAdapter(sum, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rp_finance_label.Text = dt.Rows[0][0].ToString() + "\t Currency";
            con.Close();
        }
        private void Total_Daily()
        {
            con.Close();
            con.Open();
            string sum = "SELECT SUM(Cost) FROM Bookings WHERE CheckInDate = @CI";
            cmd = new OleDbCommand(sum, con);
            cmd.Parameters.AddWithValue("@CI", income_date.Value.Date);
            DataTable dt = new DataTable();
            object result = cmd.ExecuteScalar();

            // Check for null to handle cases where there’s no matching record
            if (result != DBNull.Value)
            {
                rp_dailyincome_label.Text = result.ToString() + "\t Currency";
            }
            else
            {
                rp_dailyincome_label.Text = "0\t Currency";
            }
        }
        private void Get_Customers()
        {
            con.Open();
            string getcus = "SELECT * FROM Guests";
            cmd = new OleDbCommand(getcus, con);
            OleDbDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("GuestID", typeof(int));
            dt.Load(rdr);
            rp_customer_cbbox.ValueMember = "GuestID";
            rp_customer_cbbox.DataSource = dt;
            con.Close();
        }
        private void Total_IncomebyCustomers()
        {
            con.Close();
            con.Open();
            string sum = "SELECT SUM(Cost) FROM Bookings WHERE GuestID = @GI";
            cmd=new OleDbCommand(sum,con);
            cmd.Parameters.AddWithValue("@GI", int.Parse(rp_customer_cbbox.SelectedValue.ToString()));
            DataTable dt = new DataTable();
            object result = cmd.ExecuteScalar();

            // Check for null to handle cases where there’s no matching record
            if (result != DBNull.Value)
            {
                rp_cusincome_label.Text = result.ToString() + "\t Currency";
            }
            else
            {
                rp_cusincome_label.Text = "0\t Currency"; // Default value if there’s no income
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
            this.Hide();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private void category_Click(object sender, EventArgs e)
        {
            ManagerCategoryForm managerCategoryForm = new ManagerCategoryForm();
            managerCategoryForm.Show();
            this.Hide();
        }
        private void room_Click(object sender, EventArgs e)
        {
            ManagerRoomForm roomForm = new ManagerRoomForm();
            roomForm.Show();
            this.Hide();
        }

        private void income_date_ValueChanged(object sender, EventArgs e)
        {
            Total_Daily();
        }

        private void rp_customer_cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Total_IncomebyCustomers();
        }
    }
}
