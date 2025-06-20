using System;
using System.Data;
using System.Data.SqlClient;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.BS_layer
{
    public class ArtistBLL
    {
        private DBMain db = new DBMain();

        // Helper methods for SQL string formatting
        private string EscapeString(string input)
        {
            if (input == null) return "NULL";
            return "N'" + input.Replace("'", "''") + "'";
        }

        private string FormatDate(DateTime? date)
        {
            if (date == null) return "NULL";
            return "'" + date.Value.ToString("yyyy-MM-dd") + "'";
        }

        public DataTable GetAll()
        {
            return db.ExecuteQuery("SELECT * FROM Artists");
        }

        public void Insert(string name, DateTime? birthdate, string nationality)
        {
            string sql = $"INSERT INTO Artists (Name, Birthdate, Nationality) VALUES ({EscapeString(name)}, {FormatDate(birthdate)}, {EscapeString(nationality)})";
            db.ExecuteNonQuery(sql);
        }

        public void Update(int id, string name, DateTime? birthdate, string nationality)
        {
            string sql = $"UPDATE Artists SET Name = {EscapeString(name)}, Birthdate = {FormatDate(birthdate)}, Nationality = {EscapeString(nationality)} WHERE ArtistID = {id}";
            db.ExecuteNonQuery(sql);
        }

        public void Delete(int artistId)
        {
            string sql = $"DELETE FROM Artists WHERE ArtistID = {artistId}";
            db.ExecuteNonQuery(sql);
        }

        public DataTable Search(string keyword)
        {
            string sql = $"SELECT * FROM Artists WHERE Name LIKE {EscapeString("%" + keyword + "%")}";
            return db.ExecuteQuery(sql);
        }

        public DataRow GetArtistById(int artistId)
        {
            string sql = $"SELECT ArtistID, Name, Birthdate, Nationality FROM Artists WHERE ArtistID = {artistId}";
            DataTable dt = db.ExecuteQuery(sql);
            
            if (dt.Rows.Count == 0)
                return null;
                
            return dt.Rows[0];
        }

        // Additional helper methods for getting specific values from DataRow
        public static int GetArtistId(DataRow row)
        {
            return row["ArtistID"] != DBNull.Value ? Convert.ToInt32(row["ArtistID"]) : 0;
        }

        public static string GetArtistName(DataRow row)
        {
            return row["Name"]?.ToString() ?? "";
        }

        public static DateTime? GetArtistBirthdate(DataRow row)
        {
            return row["Birthdate"] != DBNull.Value ? Convert.ToDateTime(row["Birthdate"]) : (DateTime?)null;
        }

        public static string GetArtistNationality(DataRow row)
        {
            return row["Nationality"]?.ToString() ?? "";
        }
    }
}
