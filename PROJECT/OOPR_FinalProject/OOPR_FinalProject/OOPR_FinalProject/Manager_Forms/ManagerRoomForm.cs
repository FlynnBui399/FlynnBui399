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
using OOPR_FinalProject.Manager_Forms;
using OOPR_FinalProject.StartUp_Forms;

namespace OOPR_FinalProject
{
    public partial class ManagerRoomForm : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dtb_hotel.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public ManagerRoomForm()
        {
            InitializeComponent();
            populate();
            GetCategories();
        }
        private void populate()
        {
            con.Open();
            string populate = "SELECT * FROM Rooms";
            da = new OleDbDataAdapter(populate, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            room_table.DataSource = ds.Tables[0];
            con.Close();
        }
        private void GetCategories()
        {
            con.Open();
            string get_category = "SELECT * FROM Types";
            cmd = new OleDbCommand(get_category, con);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TypeNum", typeof(int));
            dt.Load(rdr);
            rtype_cbbox.ValueMember = "TypeNum";
            rtype_cbbox.DataSource = dt;
            con.Close();
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
        private void report_Click(object sender, EventArgs e)
        {
            ManagerReportForm reportForm = new ManagerReportForm();
            reportForm.Show();
            this.Hide();
        }
        private void EditRoom()
        {
            if (rname_txtbox.Text == "" || rtype_cbbox.SelectedIndex == -1 || rstatus_cbbox.SelectedIndex == -1)
            {
                HotelMessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    string editroom = "UPDATE ROOMS SET RoomName=@RN,RoomType=@RT,RoomStatus=@RS WHERE RoomID = @RKey";
                    cmd = new OleDbCommand(editroom, con);
                    cmd.Parameters.AddWithValue("@RN", rname_txtbox.Text);
                    cmd.Parameters.AddWithValue("@RT", rtype_cbbox.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@RS", rstatus_cbbox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    HotelMessageBox.Show("Room has been editted!!!");

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception ex)
                {
                    HotelMessageBox.Show(ex.Message);
                }
            }

        }
        private void DeleteRoom()
        {
            if (Key == 0)
            {
                HotelMessageBox.Show("Select a Room!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    string deletetroom = "DELETE FROM Rooms WHERE RoomID = @RKey";
                    cmd = new OleDbCommand(deletetroom, con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    HotelMessageBox.Show("Room has been deleted!!!");

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception ex)
                {
                    HotelMessageBox.Show(ex.Message);
                }
            }

        }
        private void InsertRoom()
        {
            if (rname_txtbox.Text == "" || rtype_cbbox.SelectedIndex == -1 || rstatus_cbbox.SelectedIndex == -1)
            {
                HotelMessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    string insertroom = "INSERT INTO ROOMS(RoomName,RoomType,RoomStatus) VALUES(@RN, @RT, @RS) ";
                    cmd = new OleDbCommand(insertroom, con);
                    cmd.Parameters.AddWithValue("@RN", rname_txtbox.Text);
                    cmd.Parameters.AddWithValue("@RT", rtype_cbbox.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@RS", "Available");
                    HotelMessageBox.Show("Room has been added!!!");

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                catch (Exception ex)
                {
                    HotelMessageBox.Show(ex.Message);
                }
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            InsertRoom();
            populate();
        }
        int Key = 0;

        private void room_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < room_table.Rows.Count)
            {
                var selectedRow = room_table.Rows[e.RowIndex];
                rname_txtbox.Text = selectedRow.Cells[1].Value.ToString() ?? string.Empty; ;
                rtype_cbbox.Text = selectedRow.Cells[2].Value.ToString() ?? string.Empty; ;
                rstatus_cbbox.Text = selectedRow.Cells[3].Value.ToString() ?? string.Empty; ;
                if (rname_txtbox.Text == "")
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

        private void edit_btn_Click(object sender, EventArgs e)
        {
            EditRoom();
            populate();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DeleteRoom();
            populate();
        }

        private void room_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
