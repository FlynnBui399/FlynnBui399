using System;
using System.Data;
using System.Data.SqlClient;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.BS_layer
{
    public class AlbumBLL
    {
        private DBMain db = new DBMain();

        // Helper methods for SQL string formatting
        private string EscapeString(string input)
        {
            if (input == null) return "NULL";
            return "N'" + input.Replace("'", "''") + "'";
        }

        public DataTable GetAll()
        {
            string sql = @"SELECT a.AlbumID, a.Title, a.Year, a.ArtistID, ar.Name AS ArtistName 
                          FROM Albums a 
                          LEFT JOIN Artists ar ON a.ArtistID = ar.ArtistID";
            return db.ExecuteQuery(sql);
        }

        public void Insert(string title, int year, int artistId)
        {
            string sql = $"INSERT INTO Albums (Title, Year, ArtistID) VALUES ({EscapeString(title)}, {year}, {artistId})";
            db.ExecuteNonQuery(sql);
        }
        
        public void Update(int id, string title, int year, int artistId)
        {
            string sql = $"UPDATE Albums SET Title = {EscapeString(title)}, Year = {year}, ArtistID = {artistId} WHERE AlbumID = {id}";
            db.ExecuteNonQuery(sql);
        }

        public DataTable GetAlbumsByArtist(int artistId)
        {
            string sql = $"SELECT * FROM Albums WHERE ArtistID = {artistId}";
            return db.ExecuteQuery(sql);
        }

        public void Delete(int id)
        {
            string sql = $"DELETE FROM Albums WHERE AlbumID = {id}";
            db.ExecuteNonQuery(sql);
        }

        public DataTable GetByName(string name)
        {
            string sql = $"SELECT * FROM Albums WHERE Title LIKE {EscapeString("%" + name + "%")}";
            return db.ExecuteQuery(sql);
        }

        public DataTable Search(string keyword)
        {
            string sql = $@"SELECT a.AlbumID, a.Title, a.Year, a.ArtistID, ar.Name AS ArtistName 
                           FROM Albums a 
                           LEFT JOIN Artists ar ON a.ArtistID = ar.ArtistID 
                           WHERE a.Title LIKE {EscapeString("%" + keyword + "%")}";
            return db.ExecuteQuery(sql);
        }

        public DataRow GetAlbumById(int albumId)
        {
            string sql = $@"SELECT a.AlbumID, a.Title, a.Year, a.ArtistID, ar.Name AS ArtistName
                          FROM Albums a
                          LEFT JOIN Artists ar ON a.ArtistID = ar.ArtistID
                          WHERE a.AlbumID = {albumId}";
            DataTable dt = db.ExecuteQuery(sql);
            
            if (dt.Rows.Count == 0)
                return null;
                
            return dt.Rows[0];
        }

        // Additional helper methods for getting specific values from DataRow
        public static int GetAlbumId(DataRow row)
        {
            return row["AlbumID"] != DBNull.Value ? Convert.ToInt32(row["AlbumID"]) : 0;
        }

        public static string GetAlbumTitle(DataRow row)
        {
            return row["Title"]?.ToString() ?? "";
        }

        public static int GetAlbumYear(DataRow row)
        {
            return row["Year"] != DBNull.Value ? Convert.ToInt32(row["Year"]) : 0;
        }

        public static int GetAlbumArtistId(DataRow row)
        {
            return row["ArtistID"] != DBNull.Value ? Convert.ToInt32(row["ArtistID"]) : 0;
        }

        public static string GetAlbumArtistName(DataRow row)
        {
            return row["ArtistName"]?.ToString() ?? "";
        }
    }
}
