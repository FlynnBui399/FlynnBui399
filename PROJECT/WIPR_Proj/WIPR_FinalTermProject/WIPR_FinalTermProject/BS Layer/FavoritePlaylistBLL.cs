using System;
using System.Data;
using System.Data.SqlClient;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.BS_layer
{
    public class FavoritePlaylistBLL
    {
        private DBMain db = new DBMain();
        
        // Helper methods for SQL string formatting
        private string EscapeString(string input)
        {
            if (input == null) return "NULL";
            return "N'" + input.Replace("'", "''") + "'";
        }

        private string FormatDateTime(DateTime dateTime)
        {
            return "'" + dateTime.ToString("yyyy-MM-dd HH:mm:ss") + "'";
        }

        // Get list of favorite playlists for a user
        public DataTable GetByUserId(int userId)
        {
            string sql = $@"SELECT f.FavoriteID, f.UserID, f.PlaylistID, f.DateAdded, 
                          p.Name AS PlaylistName, p.Description AS PlaylistDescription,
                          u.FullName AS CreatorName,
                          COUNT(ps.SongID) AS TotalSongs,
                          ISNULL(AVG(CAST(s.Rating AS FLOAT)), 0) AS AvgRating
                          FROM FavoritePlaylists f
                          INNER JOIN Playlists p ON f.PlaylistID = p.PlaylistID
                          INNER JOIN Users u ON p.CreatorID = u.UserID
                          LEFT JOIN PlaylistSongs ps ON p.PlaylistID = ps.PlaylistID
                          LEFT JOIN Songs s ON ps.SongID = s.SongID
                          WHERE f.UserID = {userId}
                          GROUP BY f.FavoriteID, f.UserID, f.PlaylistID, f.DateAdded, p.Name, p.Description, u.FullName";
            
            return db.ExecuteQuery(sql);
        }
        
        // Get all favorite playlists for a user
        public DataTable GetUserFavorites(int userId)
        {
            string sql = $@"SELECT fp.FavoriteID, fp.UserID, fp.PlaylistID, fp.DateAdded,
                          p.Name AS PlaylistName, p.Description, p.CreatedDate,
                          u.Username AS CreatorName
                          FROM FavoritePlaylists fp
                          INNER JOIN Playlists p ON fp.PlaylistID = p.PlaylistID
                          INNER JOIN Users u ON p.CreatorID = u.UserID
                          WHERE fp.UserID = {userId}
                          ORDER BY fp.DateAdded DESC";
            return db.ExecuteQuery(sql);
        }
        
        // Add playlist to favorites
        public bool Add(int userId, int playlistId)
        {
            try
            {
                // Check if playlist is already in favorites
                if (IsFavorite(userId, playlistId))
                {
                    return false;
                }
                
                string sql = $"INSERT INTO FavoritePlaylists (UserID, PlaylistID, DateAdded) VALUES ({userId}, {playlistId}, {FormatDateTime(DateTime.Now)})";
                
                int result = db.ExecuteNonQuery(sql);
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Add a playlist to favorites
        public bool AddToFavorites(int userId, int playlistId)
        {
            try
            {
                // Check if already favorited
                if (IsAlreadyFavorited(userId, playlistId))
                    return false;

                string sql = $"INSERT INTO FavoritePlaylists (UserID, PlaylistID, DateAdded) VALUES ({userId}, {playlistId}, {FormatDateTime(DateTime.Now)})";
                int result = db.ExecuteNonQuery(sql);
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Remove playlist from favorites
        public bool Remove(int favoriteId)
        {
            try
            {
                string sql = $"DELETE FROM FavoritePlaylists WHERE FavoriteID = {favoriteId}";
                
                int result = db.ExecuteNonQuery(sql);
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Remove a playlist from favorites
        public bool RemoveFromFavorites(int favoriteId)
        {
            try
            {
                string sql = $"DELETE FROM FavoritePlaylists WHERE FavoriteID = {favoriteId}";
                int result = db.ExecuteNonQuery(sql);
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Check if playlist is already favorited by user
        public bool IsFavorite(int userId, int playlistId)
        {
            string sql = $"SELECT COUNT(*) FROM FavoritePlaylists WHERE UserID = {userId} AND PlaylistID = {playlistId}";
            
            int count = Convert.ToInt32(db.ExecuteScalar(sql));
            return count > 0;
        }
        
        // Check if a playlist is already favorited by a user
        public bool IsAlreadyFavorited(int userId, int playlistId)
        {
            string sql = $"SELECT COUNT(*) FROM FavoritePlaylists WHERE UserID = {userId} AND PlaylistID = {playlistId}";
            int count = Convert.ToInt32(db.ExecuteScalar(sql));
            return count > 0;
        }
    }
} 