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

namespace OOPR_FinalProject.Guest_Forms
{
    public partial class RoomAvailableForm : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dtb_hotel.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        int Price = 1;
        int Key = 0;
        public RoomAvailableForm()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            con.Open();
            string populate = "SELECT * FROM Rooms WHERE RoomStatus = 'Available'";
            da = new OleDbDataAdapter(populate, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            rooms_table.DataSource = ds.Tables[0];
            rooms_table.ReadOnly = true;
            rooms_table.MultiSelect = false;
            con.Close();
        }

        private void logout_panel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
