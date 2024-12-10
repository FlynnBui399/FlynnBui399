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
using OOPR_FinalProject.StartUp_Forms;

namespace OOPR_FinalProject.Manager_Forms
{
    public partial class ManagerCategoryForm : Form
    {
        public ManagerCategoryForm()
        {
            InitializeComponent();
            populate();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dtb_hotel.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void populate()
        {
            con.Open();
            string populate = "SELECT * FROM Types";
            da = new OleDbDataAdapter(populate, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            category_table.DataSource = ds.Tables[0];
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
        private void room_Click(object sender, EventArgs e)
        {
            ManagerRoomForm roomForm = new ManagerRoomForm();
            roomForm.Show();
            this.Hide();
        }
        private void report_Click(object sender, EventArgs e)
        {
            ManagerReportForm reportForm = new ManagerReportForm();
            reportForm.Show();
            this.Hide();
        }
        private void InsertCategories()
        {
            if (category_txtbox.Text == "" || cost_txtbox.Text == "")
            {
                HotelMessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    string insert_category = "INSERT INTO TYPES(TypeName,TypeCost) VALUES(@TN, @TC) ";
                    cmd = new OleDbCommand(insert_category, con);
                    cmd.Parameters.AddWithValue("@TN", category_txtbox.Text);
                    cmd.Parameters.AddWithValue("@TC", cost_txtbox.Text);
                    cmd.ExecuteNonQuery();
                    HotelMessageBox.Show("Category has been added!!!");
                    con.Close();
                }
                catch (Exception ex)
                {
                    HotelMessageBox.Show(ex.Message);
                }
            }

        }
        private void EditCategories()
        {
            if (category_txtbox.Text == "" || cost_txtbox.Text == "")
            {
                HotelMessageBox.Show("Missing information!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    string insert_category = "UPDATE Types set TypeName= @TN,TypeCost = @TC WHERE TypeNum =  @TKey";
                    cmd = new OleDbCommand(insert_category, con);
                    cmd.Parameters.AddWithValue("@TN", category_txtbox.Text);
                    cmd.Parameters.AddWithValue("@TC", cost_txtbox.Text);
                    cmd.Parameters.AddWithValue("@TKey", Key);

                    cmd.ExecuteNonQuery();
                    HotelMessageBox.Show("Category has been editted!!!");
                    con.Close();
                }
                catch (Exception ex)
                {
                    HotelMessageBox.Show(ex.Message);
                }
            }
        }
        private void DeleteCategories()
        {
            if (Key == 0)
            {
                HotelMessageBox.Show("Select a Category!!");
            }
            else
            {
                try
                {
                    con.Open();
                    string deletetroom = "DELETE FROM Types WHERE TypeNum = @TKey";
                    cmd = new OleDbCommand(deletetroom, con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    HotelMessageBox.Show("Category has been deleted!!!");

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
            InsertCategories();
            populate();
        }
        int Key = 0;

        private void category_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < category_table.Rows.Count)
            {
                var selectedRow = category_table.Rows[e.RowIndex];
                category_txtbox.Text = selectedRow.Cells[1].Value.ToString() ?? string.Empty; ;
                cost_txtbox.Text = selectedRow.Cells[2].Value.ToString() ?? string.Empty; ;
                if (category_txtbox.Text == "")
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
            EditCategories();
            populate();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DeleteCategories();
            populate();
        }

    }
}
