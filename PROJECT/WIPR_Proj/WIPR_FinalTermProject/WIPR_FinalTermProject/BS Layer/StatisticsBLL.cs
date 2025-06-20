using System;
using System.Data;
using System.Data.SqlClient;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.BS_layer
{
    public class StatisticsBLL
    {
        private DBMain db = new DBMain();

        // Helper methods for SQL string formatting
        private string EscapeString(string input)
        {
            if (input == null) return "NULL";
            return "N'" + input.Replace("'", "''") + "'";
        }

        // Get total number of songs
        public DataTable GetTotalSongs()
        {
            string sql = "SELECT COUNT(*) AS TotalSongs FROM Songs";
            return db.ExecuteQuery(sql);
        }

        // Get total number of artists
        public DataTable GetTotalArtists()
        {
            string sql = "SELECT COUNT(*) AS TotalArtists FROM Artists";
            return db.ExecuteQuery(sql);
        }

        // Get total number of albums
        public DataTable GetTotalAlbums()
        {
            string sql = "SELECT COUNT(*) AS TotalAlbums FROM Albums";
            return db.ExecuteQuery(sql);
        }

        // Get songs by genre statistics
        public DataTable GetSongsByGenre()
        {
            string sql = @"SELECT g.Name AS GenreName, COUNT(s.SongID) AS SongCount
                          FROM Genres g
                          LEFT JOIN Songs s ON g.GenreID = s.GenreID
                          GROUP BY g.GenreID, g.Name
                          ORDER BY SongCount DESC";
            return db.ExecuteQuery(sql);
        }

        // Get songs by year statistics
        public DataTable GetSongsByYear()
        {
            string sql = @"SELECT Year, COUNT(*) AS SongCount
                          FROM Songs
                          WHERE Year IS NOT NULL
                          GROUP BY Year
                          ORDER BY Year DESC";
            return db.ExecuteQuery(sql);
        }

        // Get songs by rating statistics
        public DataTable GetSongsByRating()
        {
            string sql = @"SELECT Rating, COUNT(*) AS SongCount
                          FROM Songs
                          WHERE Rating IS NOT NULL
                          GROUP BY Rating
                          ORDER BY Rating DESC";
            return db.ExecuteQuery(sql);
        }

        // Get top rated songs
        public DataTable GetTopRatedSongs()
        {
            string sql = @"SELECT TOP 10 s.Title, s.Rating, a.Name AS ArtistName, al.Title AS AlbumTitle
                          FROM Songs s
                          LEFT JOIN Artists a ON s.ArtistID = a.ArtistID
                          LEFT JOIN Albums al ON s.AlbumID = al.AlbumID
                          WHERE s.Rating IS NOT NULL
                          ORDER BY s.Rating DESC, s.Title";
            return db.ExecuteQuery(sql);
        }

        // Get most popular playlists (by number of times favorited)
        public DataTable GetMostPopularPlaylists()
        {
            string sql = @"SELECT p.Name AS PlaylistName, u.Username AS CreatorName, 
                          COUNT(fp.FavoriteID) AS FavoriteCount,
                          (SELECT COUNT(*) FROM PlaylistSongs ps WHERE ps.PlaylistID = p.PlaylistID) AS SongCount
                          FROM Playlists p
                          INNER JOIN Users u ON p.CreatorID = u.UserID
                          LEFT JOIN FavoritePlaylists fp ON p.PlaylistID = fp.PlaylistID
                          GROUP BY p.PlaylistID, p.Name, u.Username
                          ORDER BY FavoriteCount DESC, p.Name";
            return db.ExecuteQuery(sql);
        }

        // Get playlist statistics for a specific playlist
        public DataTable GetPlaylistStats(int playlistId)
        {
            string sql = $@"SELECT 
                           p.Name AS PlaylistName,
                           u.Username AS CreatorName,
                           p.CreatedDate,
                           COUNT(ps.SongID) AS TotalSongs,
                           ISNULL(SUM(s.Duration), 0) AS TotalDuration,
                           ISNULL(AVG(CAST(s.Rating AS FLOAT)), 0) AS AverageRating,
                           (SELECT COUNT(*) FROM FavoritePlaylists fp WHERE fp.PlaylistID = p.PlaylistID) AS FavoriteCount
                           FROM Playlists p
                           INNER JOIN Users u ON p.CreatorID = u.UserID
                           LEFT JOIN PlaylistSongs ps ON p.PlaylistID = ps.PlaylistID
                           LEFT JOIN Songs s ON ps.SongID = s.SongID
                           WHERE p.PlaylistID = {playlistId}
                           GROUP BY p.PlaylistID, p.Name, u.Username, p.CreatedDate";
            return db.ExecuteQuery(sql);
        }

        // Get user activity statistics
        public DataTable GetUserStats()
        {
            string sql = @"SELECT 
                          u.Username,
                          u.CreatedDate AS JoinDate,
                          u.LastLoginDate,
                          COUNT(DISTINCT p.PlaylistID) AS PlaylistsCreated,
                          COUNT(DISTINCT fp.PlaylistID) AS PlaylistsFavorited
                          FROM Users u
                          LEFT JOIN Playlists p ON u.UserID = p.CreatorID
                          LEFT JOIN FavoritePlaylists fp ON u.UserID = fp.UserID
                          GROUP BY u.UserID, u.Username, u.CreatedDate, u.LastLoginDate
                          ORDER BY PlaylistsCreated DESC, PlaylistsFavorited DESC";
            return db.ExecuteQuery(sql);
        }

        public DataTable GetSongsCountByArtist()
        {
            string sql = @"
                SELECT a.Name AS Artist, COUNT(s.SongID) AS TotalSongs
                FROM Songs s
                INNER JOIN Artists a ON s.ArtistID = a.ArtistID
                GROUP BY a.Name
                ORDER BY TotalSongs DESC";

            return db.ExecuteQuery(sql);
        }

        public DataTable GetSongsCountByGenre()
        {
            string sql = @"
                SELECT g.Name AS Genre, COUNT(s.SongID) AS TotalSongs
                FROM Songs s
                INNER JOIN Genres g ON s.GenreID = g.GenreID
                GROUP BY g.Name
                ORDER BY TotalSongs DESC";

            return db.ExecuteQuery(sql);
        }

        public DataTable GetPlaylistDurations()
        {
            string sql = @"
                SELECT p.Name AS Playlist, SUM(s.Duration) AS TotalDuration
                FROM Playlists p
                INNER JOIN PlaylistSongs ps ON p.PlaylistID = ps.PlaylistID
                INNER JOIN Songs s ON ps.SongID = s.SongID
                GROUP BY p.Name
                ORDER BY TotalDuration DESC";

            return db.ExecuteQuery(sql);
        }

        public DataTable GetArtistStatistics()
        {
            string sql = @"
                SELECT 
                    a.Name AS Artist,
                    a.Nationality,
                    a.Birthdate,
                    COUNT(s.SongID) AS TotalSongs,
                    SUM(s.Duration) AS TotalDuration,
                    COUNT(DISTINCT s.AlbumID) AS TotalAlbums,
                    (
                        SELECT TOP 1 s2.Title
                        FROM Songs s2
                        WHERE s2.ArtistID = a.ArtistID
                        ORDER BY s2.Rating DESC, s2.Year DESC
                    ) AS TopRatedSong
                FROM Songs s
                INNER JOIN Artists a ON s.ArtistID = a.ArtistID
                GROUP BY a.Name, a.Nationality, a.Birthdate, a.ArtistID
                ORDER BY TotalSongs DESC";

            return db.ExecuteQuery(sql);
        }

        public DataTable GetGenreStatistics()
        {
            string sql = @"
                SELECT 
                    g.Name AS Genre,
                    COUNT(s.SongID) AS TotalSongs,
                    AVG(s.Duration) AS AverageDuration,
                    (
                        SELECT TOP 1 a.Name
                        FROM Songs s2
                        INNER JOIN Artists a ON s2.ArtistID = a.ArtistID
                        WHERE s2.GenreID = g.GenreID
                        GROUP BY a.Name, a.ArtistID
                        ORDER BY COUNT(*) DESC
                    ) AS PopularArtist,
                    (
                        SELECT TOP 1 YEAR(s2.Year)
                        FROM Songs s2
                        WHERE s2.GenreID = g.GenreID
                        GROUP BY YEAR(s2.Year)
                        ORDER BY COUNT(*) DESC
                    ) AS PopularYear
                FROM Songs s
                INNER JOIN Genres g ON s.GenreID = g.GenreID
                GROUP BY g.Name, g.GenreID
                ORDER BY TotalSongs DESC";

            return db.ExecuteQuery(sql);
        }

        public DataTable GetPlaylistStatistics()
        {
            string sql = @"
                SELECT 
                    p.PlaylistID,
                    p.Name AS Playlist,
                    p.CreatedDate,
                    COUNT(s.SongID) AS TotalSongs,
                    ISNULL(SUM(s.Duration), 0) AS TotalDuration,
                    ISNULL(AVG(s.Duration), 0) AS AverageDuration,
                    (
                        SELECT TOP 1 g.Name
                        FROM PlaylistSongs ps2
                        INNER JOIN Songs s2 ON ps2.SongID = s2.SongID
                        INNER JOIN Genres g ON s2.GenreID = g.GenreID
                        WHERE ps2.PlaylistID = p.PlaylistID
                        GROUP BY g.Name, g.GenreID
                        ORDER BY COUNT(*) DESC
                    ) AS PopularGenre,
                    (
                        SELECT TOP 1 s2.Title
                        FROM PlaylistSongs ps2
                        INNER JOIN Songs s2 ON ps2.SongID = s2.SongID
                        WHERE ps2.PlaylistID = p.PlaylistID
                        ORDER BY s2.Rating DESC, s2.Title
                    ) AS MostRatedSong
                FROM Playlists p
                LEFT JOIN PlaylistSongs ps ON p.PlaylistID = ps.PlaylistID
                LEFT JOIN Songs s ON ps.SongID = s.SongID
                GROUP BY p.PlaylistID, p.Name, p.CreatedDate
                ORDER BY TotalSongs DESC";

            return db.ExecuteQuery(sql);
        }

        public DataTable GetSongsInPlaylist(int playlistId)
        {
            string sql = $@"
                SELECT s.Title AS SongTitle, a.Name AS ArtistName, s.Duration, s.Rating
                FROM PlaylistSongs ps
                INNER JOIN Songs s ON ps.SongID = s.SongID
                INNER JOIN Artists a ON s.ArtistID = a.ArtistID
                WHERE ps.PlaylistID = {playlistId}";

            return db.ExecuteQuery(sql);
        }

        public DataTable GetAlbumStatistics()
        {
            string sql = @"
                SELECT 
                    alb.AlbumID,
                    alb.Title AS Album,
                    alb.Year,
                    art.Name AS Artist,
                    COUNT(s.SongID) AS TotalSongs,
                    SUM(s.Duration) AS TotalDuration,
                    AVG(s.Duration) AS AverageDuration,
                    (
                        SELECT TOP 1 g.Name
                        FROM Songs s2
                        INNER JOIN Genres g ON s2.GenreID = g.GenreID
                        WHERE s2.AlbumID = alb.AlbumID
                        GROUP BY g.Name, g.GenreID
                        ORDER BY COUNT(*) DESC
                    ) AS PrimaryGenre,
                    (
                        SELECT TOP 1 s2.Title
                        FROM Songs s2
                        WHERE s2.AlbumID = alb.AlbumID
                        ORDER BY s2.Rating DESC, s2.Title
                    ) AS MostRatedSong,
                    AVG(CAST(ISNULL(s.Rating, 0) AS FLOAT)) AS AvgRating
                FROM Albums alb
                LEFT JOIN Songs s ON alb.AlbumID = s.AlbumID
                LEFT JOIN Artists art ON alb.ArtistID = art.ArtistID
                GROUP BY alb.AlbumID, alb.Title, alb.Year, art.Name
                ORDER BY alb.Year DESC, alb.Title";

            return db.ExecuteQuery(sql);
        }
    }
}
