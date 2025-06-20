using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.BS_layer
{
    public class SongBLL
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
            string sql = @"SELECT s.SongID, s.Title, s.Duration, s.Year, s.Rating, 
                          s.ArtistID, a.Name AS ArtistName, 
                          s.AlbumID, al.Title AS AlbumTitle, 
                          s.GenreID, g.Name AS GenreName, 
                          s.FilePath
                          FROM Songs s
                          LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
                          LEFT JOIN Albums al ON s.AlbumID = al.AlbumID
                          LEFT JOIN Genres g ON s.GenreID = g.GenreID";
            return db.ExecuteQuery(sql);
        }

        public void Insert(string title, int duration, int year, int rating, int artistId, int albumId, int genreId, string filePath)
        {
            string sql = $"INSERT INTO Songs (Title, Duration, Year, Rating, ArtistID, AlbumID, GenreID, FilePath) VALUES ({EscapeString(title)}, {duration}, {year}, {rating}, {artistId}, {albumId}, {genreId}, {EscapeString(filePath)})";
            db.ExecuteNonQuery(sql);
        }

        public void Update(int id, string title, int duration, int year, int rating, int artistId, int albumId, int genreId, string filePath)
        {
            string sql = $"UPDATE Songs SET Title = {EscapeString(title)}, Duration = {duration}, Year = {year}, Rating = {rating}, ArtistID = {artistId}, AlbumID = {albumId}, GenreID = {genreId}, FilePath = {EscapeString(filePath)} WHERE SongID = {id}";
            db.ExecuteNonQuery(sql);
        }

        public void Delete(int id)
        {
            string sql = $"DELETE FROM Songs WHERE SongID = {id}";
            db.ExecuteNonQuery(sql);
        }

        public DataTable Search(string keyword)
        {
            string sql = $@"SELECT s.SongID, s.Title, s.Duration, s.Year, s.Rating, 
                          s.ArtistID, a.Name AS ArtistName, 
                          s.AlbumID, al.Title AS AlbumTitle, 
                          s.GenreID, g.Name AS GenreName, 
                          s.FilePath
                          FROM Songs s
                          LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
                          LEFT JOIN Albums al ON s.AlbumID = al.AlbumID
                          LEFT JOIN Genres g ON s.GenreID = g.GenreID
                          WHERE s.Title LIKE {EscapeString("%" + keyword + "%")}";
            return db.ExecuteQuery(sql);
        }

        public DataTable GetAllSongsWithFilePath()
        {
            string sql = @"SELECT s.SongID, s.Title, s.Duration, s.Year, s.Rating, 
                          s.ArtistID, a.Name AS ArtistName, 
                          s.AlbumID, al.Title AS AlbumTitle, 
                          s.GenreID, g.Name AS GenreName, 
                          s.FilePath
                          FROM Songs s
                          LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
                          LEFT JOIN Albums al ON s.AlbumID = al.AlbumID
                          LEFT JOIN Genres g ON s.GenreID = g.GenreID
                          WHERE s.FilePath IS NOT NULL AND s.FilePath <> ''";
                          
            return db.ExecuteQuery(sql);
        }

        public DataRow GetSongById(int songId)
        {
            string sql = $@"SELECT s.SongID, s.Title, s.Duration, s.Year, s.Rating, 
                          s.ArtistID, a.Name AS ArtistName, 
                          s.AlbumID, al.Title AS AlbumTitle, 
                          s.GenreID, g.Name AS GenreName, 
                          s.FilePath
                          FROM Songs s
                          LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
                          LEFT JOIN Albums al ON s.AlbumID = al.AlbumID
                          LEFT JOIN Genres g ON s.GenreID = g.GenreID
                          WHERE s.SongID = {songId}";
            
            DataTable dt = db.ExecuteQuery(sql);
            
            if (dt.Rows.Count == 0)
                return null;
                
            return dt.Rows[0];
        }

        // Additional helper methods for getting specific values from DataRow
        public static int GetSongId(DataRow row)
        {
            return row["SongID"] != DBNull.Value ? Convert.ToInt32(row["SongID"]) : 0;
        }

        public static string GetSongTitle(DataRow row)
        {
            return row["Title"]?.ToString() ?? "";
        }

        public static string GetSongFilePath(DataRow row)
        {
            return row["FilePath"]?.ToString() ?? "";
        }

        public static int GetSongDuration(DataRow row)
        {
            return row["Duration"] != DBNull.Value ? Convert.ToInt32(row["Duration"]) : 0;
        }

        public static int GetSongYear(DataRow row)
        {
            return row["Year"] != DBNull.Value ? Convert.ToInt32(row["Year"]) : 0;
        }

        public static int GetSongRating(DataRow row)
        {
            return row["Rating"] != DBNull.Value ? Convert.ToInt32(row["Rating"]) : 0;
        }

        public static string GetArtistName(DataRow row)
        {
            return row["ArtistName"]?.ToString() ?? "";
        }

        public static string GetAlbumTitle(DataRow row)
        {
            return row["AlbumTitle"]?.ToString() ?? "";
        }

        public static string GetGenreName(DataRow row)
        {
            return row["GenreName"]?.ToString() ?? "";
        }
    }
}
