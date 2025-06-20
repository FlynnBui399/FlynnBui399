using System;
using System.Data;
using System.Data.SqlClient;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.BS_layer
{
    public class GenreBLL
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
            return db.ExecuteQuery("SELECT * FROM Genres");
        }

        public DataTable GetGenresWithSongCount()
        {
            string sql = @"SELECT g.GenreID, g.Name, COUNT(s.SongID) AS SongCount 
                          FROM Genres g 
                          LEFT JOIN Songs s ON g.GenreID = s.GenreID 
                          GROUP BY g.GenreID, g.Name 
                          ORDER BY g.Name";
            return db.ExecuteQuery(sql);
        }

        public DataTable GetAllWithTotalSongs()
        {
            string sql = @"SELECT g.GenreID, g.Name, COUNT(s.SongID) AS TotalSongs 
                          FROM Genres g 
                          LEFT JOIN Songs s ON g.GenreID = s.GenreID 
                          GROUP BY g.GenreID, g.Name 
                          ORDER BY g.Name";
            return db.ExecuteQuery(sql);
        }

        public void Insert(string name)
        {
            string sql = $"INSERT INTO Genres (Name) VALUES ({EscapeString(name)})";
            db.ExecuteNonQuery(sql);
        }

        public void Update(int id, string name)
        {
            string sql = $"UPDATE Genres SET Name = {EscapeString(name)} WHERE GenreID = {id}";
            db.ExecuteNonQuery(sql);
        }

        public void Delete(int genreId)
        {
            string sql = $"DELETE FROM Genres WHERE GenreID = {genreId}";
            db.ExecuteNonQuery(sql);
        }

        public DataTable Search(string keyword)
        {
            string sql = $@"SELECT g.GenreID, g.Name, COUNT(s.SongID) AS SongCount 
                           FROM Genres g 
                           LEFT JOIN Songs s ON g.GenreID = s.GenreID 
                           WHERE g.Name LIKE {EscapeString("%" + keyword + "%")}
                           GROUP BY g.GenreID, g.Name 
                           ORDER BY g.Name";
            return db.ExecuteQuery(sql);
        }

        public DataRow GetGenreById(int genreId)
        {
            string sql = $"SELECT GenreID, Name FROM Genres WHERE GenreID = {genreId}";
            DataTable dt = db.ExecuteQuery(sql);
            
            if (dt.Rows.Count == 0)
                return null;
                
            return dt.Rows[0];
        }

        // Additional helper methods for getting specific values from DataRow
        public static int GetGenreId(DataRow row)
        {
            return row["GenreID"] != DBNull.Value ? Convert.ToInt32(row["GenreID"]) : 0;
        }

        public static string GetGenreName(DataRow row)
        {
            return row["Name"]?.ToString() ?? "";
        }

        public static int GetGenreSongCount(DataRow row)
        {
            if (row.Table.Columns.Contains("SongCount"))
                return row["SongCount"] != DBNull.Value ? Convert.ToInt32(row["SongCount"]) : 0;
            return 0;
        }

        public static int GetGenreTotalSongs(DataRow row)
        {
            if (row.Table.Columns.Contains("TotalSongs"))
                return row["TotalSongs"] != DBNull.Value ? Convert.ToInt32(row["TotalSongs"]) : 0;
            return 0;
        }
    }
}
