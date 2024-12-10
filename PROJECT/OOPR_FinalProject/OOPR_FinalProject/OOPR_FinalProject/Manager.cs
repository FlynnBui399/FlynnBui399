using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using OOPR_FinalProject.StartUp_Forms;

namespace OOPR_FinalProject
{
    public class Manager : Person
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dtb_hotel.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void InsertCategories(string category, string cost)
        {
            if (category == "" || cost == "")
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
                    cmd.Parameters.AddWithValue("@TN", category);
                    cmd.Parameters.AddWithValue("@TC", cost);
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
        private void InsertRoom(string rname, string rtype, string rstatus)
        {
            if (rname == "" || rtype == "" || rstatus == "")
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
                    cmd.Parameters.AddWithValue("@RN", rname);
                    cmd.Parameters.AddWithValue("@RT", rtype);
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

        public override string PrintDetails()
        {
            return ($"Manager: {Name}, Contact: {ContactInfo}");
        }
    }
}