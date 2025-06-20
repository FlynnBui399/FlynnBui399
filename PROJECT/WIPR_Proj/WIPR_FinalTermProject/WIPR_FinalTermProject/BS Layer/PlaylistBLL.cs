using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.BS_layer
{
    public class PlaylistBLL
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
            string sql = "SELECT * FROM Playlists";
            return db.ExecuteQuery(sql);
        }

        public void Insert(string name, string description)
        {
            string sql = $"INSERT INTO Playlists (Name, Description, CreatedDate, CreatorID) VALUES ({EscapeString(name)}, {EscapeString(description)}, GETDATE(), {UserBLL.CurrentUser.UserID ?? 0})";
            db.ExecuteNonQuery(sql);
        }

        public void Update(int id, string name, string description)
        {
            string sql = $"UPDATE Playlists SET Name = {EscapeString(name)}, Description = {EscapeString(description)} WHERE PlaylistID = {id}";
            db.ExecuteNonQuery(sql);
        }

        public void Delete(int id)
        {
            // Delete related records in correct order to avoid foreign key constraint violations
            string sql1 = $"DELETE FROM PlaylistSongs WHERE PlaylistID = {id}";
            string sql2 = $"DELETE FROM FavoritePlaylists WHERE PlaylistID = {id}";
            string sql3 = $"DELETE FROM Playlists WHERE PlaylistID = {id}";
            
            db.ExecuteNonQuery(sql1);
            db.ExecuteNonQuery(sql2);
            db.ExecuteNonQuery(sql3);
        }

        public DataTable Search(string keyword)
        {
            string sql = $"SELECT * FROM Playlists WHERE Name LIKE {EscapeString("%" + keyword + "%")}";
            return db.ExecuteQuery(sql);
        }

        public DataTable GetPlaylistSongs(int playlistId)
        {
            string sql = $@"SELECT ps.PlaylistID, ps.SongID, ps.OrderIndex, s.Title, s.Duration, a.Name AS ArtistName 
                           FROM PlaylistSongs ps 
                           INNER JOIN Songs s ON ps.SongID = s.SongID 
                           LEFT JOIN Artists a ON s.ArtistID = a.ArtistID 
                           WHERE ps.PlaylistID = {playlistId} 
                           ORDER BY ps.OrderIndex";
            return db.ExecuteQuery(sql);
        }

        public void AddSongToPlaylist(int playlistId, int songId)
        {
            // Get the next order index
            string getOrderSql = $"SELECT ISNULL(MAX(OrderIndex), 0) + 1 FROM PlaylistSongs WHERE PlaylistID = {playlistId}";
            int nextOrder = Convert.ToInt32(db.ExecuteScalar(getOrderSql));

            // Add the song to the playlist
            string sql = $"INSERT INTO PlaylistSongs (PlaylistID, SongID, OrderIndex) VALUES ({playlistId}, {songId}, {nextOrder})";
            db.ExecuteNonQuery(sql);
        }

        public void RemoveSongFromPlaylist(int playlistId, int songId)
        {
            string sql = $"DELETE FROM PlaylistSongs WHERE PlaylistID = {playlistId} AND SongID = {songId}";
            db.ExecuteNonQuery(sql);
        }

        public bool IsPlaylistFavorited(int playlistId, int userId)
        {
            string sql = $"SELECT COUNT(*) FROM FavoritePlaylists WHERE PlaylistID = {playlistId} AND UserID = {userId}";
            int count = Convert.ToInt32(db.ExecuteScalar(sql));
            return count > 0;
        }

        // Get playlists created by current user
        public DataTable GetMyPlaylists()
        {
            if (UserBLL.CurrentUser.UserID == null) return new DataTable();
            
            string sql = $@"SELECT p.*, COUNT(ps.SongID) as SongCount 
                           FROM Playlists p 
                           LEFT JOIN PlaylistSongs ps ON p.PlaylistID = ps.PlaylistID 
                           WHERE p.CreatorID = {UserBLL.CurrentUser.UserID ?? 0}
                           GROUP BY p.PlaylistID, p.Name, p.Description, p.CreatedDate, p.CreatorID";
            return db.ExecuteQuery(sql);
        }

        // Reorder songs in playlist
        public void MoveSong(int playlistId, int songId1, int songId2)
        {
            // Get current order indices
            string getOrder1Sql = $"SELECT OrderIndex FROM PlaylistSongs WHERE PlaylistID = {playlistId} AND SongID = {songId1}";
            object order1Obj = db.ExecuteScalar(getOrder1Sql);

            string getOrder2Sql = $"SELECT OrderIndex FROM PlaylistSongs WHERE PlaylistID = {playlistId} AND SongID = {songId2}";
            object order2Obj = db.ExecuteScalar(getOrder2Sql);

            if (order1Obj != null && order2Obj != null)
            {
                int order1 = Convert.ToInt32(order1Obj);
                int order2 = Convert.ToInt32(order2Obj);
                int tempOrder = -1; // Temporary order to avoid constraint violations

                // Swap the order indices using a temporary value
                string updateSql1 = $"UPDATE PlaylistSongs SET OrderIndex = {tempOrder} WHERE PlaylistID = {playlistId} AND SongID = {songId1}";
                db.ExecuteNonQuery(updateSql1);

                string updateSql2 = $"UPDATE PlaylistSongs SET OrderIndex = {order1} WHERE PlaylistID = {playlistId} AND SongID = {songId2}";
                db.ExecuteNonQuery(updateSql2);

                string updateSql3 = $"UPDATE PlaylistSongs SET OrderIndex = {order2} WHERE PlaylistID = {playlistId} AND SongID = {songId1}";
                db.ExecuteNonQuery(updateSql3);

                // Reorder all songs to ensure sequential ordering
                string getSongsSql = $"SELECT SongID FROM PlaylistSongs WHERE PlaylistID = {playlistId} ORDER BY OrderIndex";
                DataTable songs = db.ExecuteQuery(getSongsSql);

                for (int i = 0; i < songs.Rows.Count; i++)
                {
                    int songId = Convert.ToInt32(songs.Rows[i]["SongID"]);
                    int newOrder = i + 1;
                    string updateSql = $"UPDATE PlaylistSongs SET OrderIndex = {newOrder} WHERE PlaylistID = {playlistId} AND SongID = {songId}";
                    db.ExecuteNonQuery(updateSql);
                }
            }
        }

        // Check if user can modify playlist
        public bool CanModifyPlaylist(int playlistId, int userId)
        {
            // Administrator can modify any playlist
            if (new UserBLL().IsAdmin())
                return true;
                
            string sql = $"SELECT COUNT(*) FROM Playlists WHERE PlaylistID = {playlistId} AND CreatorID = {userId}";
            int count = Convert.ToInt32(db.ExecuteScalar(sql));
            return count > 0;
        }

        public DataRow GetById(int playlistId)
        {
            string sql = $@"SELECT p.PlaylistID, p.Name, p.Description, p.CreatedDate, p.CreatorID, u.FullName AS CreatorName
                          FROM Playlists p
                          LEFT JOIN Users u ON p.CreatorID = u.UserID
                          WHERE p.PlaylistID = {playlistId}";
            DataTable dt = db.ExecuteQuery(sql);
            
            if (dt.Rows.Count == 0)
                return null;
                
            return dt.Rows[0];
        }

        // Get songs in playlist (alias for GetPlaylistSongs)
        public DataTable GetSongsInPlaylist(int playlistId)
        {
            return GetPlaylistSongs(playlistId);
        }

        // Swap song order (alias for MoveSong)
        public void SwapSongOrder(int playlistId, int songId1, int songId2)
        {
            MoveSong(playlistId, songId1, songId2);
        }

        // Additional helper methods for getting specific values from DataRow
        public static int GetPlaylistId(DataRow row)
        {
            return row["PlaylistID"] != DBNull.Value ? Convert.ToInt32(row["PlaylistID"]) : 0;
        }

        public static string GetPlaylistName(DataRow row)
        {
            return row["Name"]?.ToString() ?? "";
        }

        public static string GetPlaylistDescription(DataRow row)
        {
            return row["Description"]?.ToString() ?? "";
        }

        public static DateTime GetCreatedDate(DataRow row)
        {
            return row["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.MinValue;
        }

        public static int GetCreatorId(DataRow row)
        {
            return row["CreatorID"] != DBNull.Value ? Convert.ToInt32(row["CreatorID"]) : 0;
        }

        public static string GetCreatorName(DataRow row)
        {
            if (row.Table.Columns.Contains("CreatorName"))
                return row["CreatorName"]?.ToString() ?? "";
            return "";
        }

        public static int GetTotalSongs(DataRow row)
        {
            if (row.Table.Columns.Contains("TotalSongs"))
                return row["TotalSongs"] != DBNull.Value ? Convert.ToInt32(row["TotalSongs"]) : 0;
            return 0;
        }
    }
}
