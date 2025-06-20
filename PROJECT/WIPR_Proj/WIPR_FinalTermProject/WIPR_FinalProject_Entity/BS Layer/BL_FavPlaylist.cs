using System;
using System.Data;
using System.Linq;
using WIPR_FinalProject_Entity;

namespace WIPR_FinalProject_Entity.BS_Layer
{
    public class BL_FavPlaylist : IDisposable
    {
        private MusicLibraryDBEntities musicEntity = new MusicLibraryDBEntities();

        // Get list of favorite playlists for a user
        public DataTable GetByUserId(int userId)
        {
            if (userId <= 0)
                throw new ArgumentException("Invalid user ID", nameof(userId));

            var query = from f in musicEntity.FavoritePlaylists
                       join p in musicEntity.Playlists on f.PlaylistID equals p.PlaylistID
                       join u in musicEntity.Users on f.UserID equals u.UserID
                       where f.UserID == userId
                       select new
                       {
                           f.FavoriteID,
                           f.UserID,
                           f.PlaylistID,
                           f.DateAdded,
                           PlaylistName = p.Name,
                           PlaylistDescription = p.Description,
                           CreatorName = p.User.FullName,
                           TotalSongs = p.Songs.Count,
                           AvgRating = p.Songs.Any() ? p.Songs.Average(s => s.Rating ?? 0) : 0
                       };

            DataTable dt = new DataTable();
            dt.Columns.Add("FavoriteID", typeof(int));
            dt.Columns.Add("UserID", typeof(int));
            dt.Columns.Add("PlaylistID", typeof(int));
            dt.Columns.Add("DateAdded", typeof(DateTime));
            dt.Columns.Add("PlaylistName", typeof(string));
            dt.Columns.Add("PlaylistDescription", typeof(string));
            dt.Columns.Add("CreatorName", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));
            dt.Columns.Add("AvgRating", typeof(double));

            foreach (var item in query)
            {
                dt.Rows.Add(
                    item.FavoriteID,
                    item.UserID,
                    item.PlaylistID,
                    item.DateAdded,
                    item.PlaylistName ?? string.Empty,
                    item.PlaylistDescription ?? string.Empty,
                    item.CreatorName ?? string.Empty,
                    item.TotalSongs,
                    item.AvgRating
                );
            }

            return dt;
        }

        // Add playlist to favorites
        public bool Add(int userId, int playlistId)
        {
            if (userId <= 0)
                throw new ArgumentException("Invalid user ID", nameof(userId));
            if (playlistId <= 0)
                throw new ArgumentException("Invalid playlist ID", nameof(playlistId));

            try
            {
                // Check if user exists
                if (!musicEntity.Users.Any(u => u.UserID == userId))
                    throw new InvalidOperationException("User not found");

                // Check if playlist exists
                if (!musicEntity.Playlists.Any(p => p.PlaylistID == playlistId))
                    throw new InvalidOperationException("Playlist not found");

                // Check if playlist is already in favorites
                if (IsFavorite(userId, playlistId))
                    throw new InvalidOperationException("Playlist is already in favorites");

                var favorite = new FavoritePlaylist
                {
                    UserID = userId,
                    PlaylistID = playlistId,
                    DateAdded = DateTime.Now
                };

                musicEntity.FavoritePlaylists.Add(favorite);
                musicEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to add playlist to favorites: {ex.Message}", ex);
            }
        }

        // Remove playlist from favorites
        public bool Remove(int favoriteId)
        {
            if (favoriteId <= 0)
                throw new ArgumentException("Invalid favorite ID", nameof(favoriteId));

            try
            {
                var favorite = musicEntity.FavoritePlaylists.Find(favoriteId);
                if (favorite == null)
                    throw new InvalidOperationException("Favorite playlist not found");

                musicEntity.FavoritePlaylists.Remove(favorite);
                musicEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to remove playlist from favorites: {ex.Message}", ex);
            }
        }

        // Check if playlist is already favorited by user
        public bool IsFavorite(int userId, int playlistId)
        {
            if (userId <= 0)
                throw new ArgumentException("Invalid user ID", nameof(userId));
            if (playlistId <= 0)
                throw new ArgumentException("Invalid playlist ID", nameof(playlistId));

            return musicEntity.FavoritePlaylists.Any(f => f.UserID == userId && f.PlaylistID == playlistId);
        }

        // Get total number of favorite playlists for a user
        public int GetTotalFavorites(int userId)
        {
            if (userId <= 0)
                throw new ArgumentException("Invalid user ID", nameof(userId));

            return musicEntity.FavoritePlaylists.Count(f => f.UserID == userId);
        }

        // Get most recent favorite playlists
        public DataTable GetRecentFavorites(int userId, int count = 5)
        {
            if (userId <= 0)
                throw new ArgumentException("Invalid user ID", nameof(userId));
            if (count <= 0)
                throw new ArgumentException("Invalid count", nameof(count));

            var query = from f in musicEntity.FavoritePlaylists
                       join p in musicEntity.Playlists on f.PlaylistID equals p.PlaylistID
                       where f.UserID == userId
                       orderby f.DateAdded descending
                       select new
                       {
                           f.FavoriteID,
                           f.PlaylistID,
                           f.DateAdded,
                           PlaylistName = p.Name,
                           CreatorName = p.User.FullName,
                           TotalSongs = p.Songs.Count
                       };

            DataTable dt = new DataTable();
            dt.Columns.Add("FavoriteID", typeof(int));
            dt.Columns.Add("PlaylistID", typeof(int));
            dt.Columns.Add("DateAdded", typeof(DateTime));
            dt.Columns.Add("PlaylistName", typeof(string));
            dt.Columns.Add("CreatorName", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));

            foreach (var item in query.Take(count))
            {
                dt.Rows.Add(
                    item.FavoriteID,
                    item.PlaylistID,
                    item.DateAdded,
                    item.PlaylistName ?? string.Empty,
                    item.CreatorName ?? string.Empty,
                    item.TotalSongs
                );
            }

            return dt;
        }

        public void Dispose()
        {
            if (musicEntity != null)
            {
                musicEntity.Dispose();
                musicEntity = null;
            }
        }
    }
}