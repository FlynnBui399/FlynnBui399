using System;
using System.Data;
using System.Data.SqlClient;

namespace WIPR_FinalTermProject.DB_layer
{
    public class DBMain
    {
        private string connectionString = "Data Source=.;Initial Catalog=MusicLibraryDB;Integrated Security=True";

        public DataTable ExecuteQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
