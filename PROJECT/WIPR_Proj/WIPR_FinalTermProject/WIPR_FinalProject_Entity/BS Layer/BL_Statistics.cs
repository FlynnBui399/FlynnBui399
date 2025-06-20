using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using WIPR_FinalProject_Entity;

namespace WIPR_FinalProject_Entity.BS_Layer
{
    public class BL_Statistics
    {
        private MusicLibraryDBEntities musicEntity = new MusicLibraryDBEntities();

        // Get songs count by artist
        public DataTable GetSongsCountByArtist()
        {
            var query = from s in musicEntity.Songs
                        where s.Artist != null
                        group s by s.Artist.Name into g
                        orderby g.Count() descending
                        select new
                        {
                            Artist = g.Key,
                            TotalSongs = g.Count()
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("Artist", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));

            foreach (var item in query)
            {
                dt.Rows.Add(item.Artist, item.TotalSongs);
            }

            return dt;
        }

        // Get songs count by genre
        public DataTable GetSongsCountByGenre()
        {
            var query = from s in musicEntity.Songs
                        where s.Genre != null
                        group s by s.Genre.Name into g
                        orderby g.Count() descending
                        select new
                        {
                            Genre = g.Key,
                            TotalSongs = g.Count()
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("Genre", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));

            foreach (var item in query)
            {
                dt.Rows.Add(item.Genre, item.TotalSongs);
            }

            return dt;
        }

        // Get playlist durations
        public DataTable GetPlaylistDurations()
        {
            var query = from p in musicEntity.Playlists
                        select new
                        {
                            Playlist = p.Name,
                            TotalDuration = p.Songs.Sum(s => (int?)s.Duration) ?? 0
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("Playlist", typeof(string));
            dt.Columns.Add("TotalDuration", typeof(int));

            foreach (var item in query)
            {
                dt.Rows.Add(item.Playlist, item.TotalDuration);
            }

            return dt;
        }

        // Get artist statistics
        public DataTable GetArtistStatistics()
        {
            var query = from a in musicEntity.Artists
                        select new
                        {
                            Artist = a.Name,
                            a.Nationality,
                            a.Birthdate,
                            TotalSongs = a.Songs.Count,
                            TotalDuration = a.Songs.Sum(s => (int?)s.Duration) ?? 0,
                            TotalAlbums = a.Songs.Select(s => s.AlbumID).Distinct().Count(),
                            TopRatedSong = a.Songs.OrderByDescending(s => s.Rating).ThenByDescending(s => s.Year).Select(s => s.Title).FirstOrDefault()
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("Artist", typeof(string));
            dt.Columns.Add("Nationality", typeof(string));
            dt.Columns.Add("Birthdate", typeof(DateTime));
            dt.Columns.Add("TotalSongs", typeof(int));
            dt.Columns.Add("TotalDuration", typeof(int));
            dt.Columns.Add("TotalAlbums", typeof(int));
            dt.Columns.Add("TopRatedSong", typeof(string));

            foreach (var item in query)
            {
                dt.Rows.Add(item.Artist, item.Nationality ?? string.Empty, item.Birthdate, item.TotalSongs, item.TotalDuration, item.TotalAlbums, item.TopRatedSong ?? string.Empty);
            }

            return dt;
        }

        // Get genre statistics
        public DataTable GetGenreStatistics()
        {
            var query = from g in musicEntity.Genres
                        select new
                        {
                            Genre = g.Name,
                            TotalSongs = g.Songs.Count,
                            AverageDuration = g.Songs.Any() ? g.Songs.Average(s => (double?)s.Duration) ?? 0 : 0,
                            PopularArtist = g.Songs.GroupBy(s => s.Artist.Name).OrderByDescending(gr => gr.Count()).Select(gr => gr.Key).FirstOrDefault(),
                            PopularYear = g.Songs.GroupBy(s => s.Year).OrderByDescending(gr => gr.Count()).Select(gr => gr.Key).FirstOrDefault()
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("Genre", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));
            dt.Columns.Add("AverageDuration", typeof(double));
            dt.Columns.Add("PopularArtist", typeof(string));
            dt.Columns.Add("PopularYear", typeof(int));

            foreach (var item in query)
            {
                dt.Rows.Add(item.Genre, item.TotalSongs, item.AverageDuration, item.PopularArtist ?? string.Empty, item.PopularYear ?? 0);
            }

            return dt;
        }

        // Get playlist statistics
        public DataTable GetPlaylistStatistics()
        {
            var query = from p in musicEntity.Playlists
                        select new
                        {
                            p.PlaylistID,
                            Playlist = p.Name,
                            p.CreatedDate,
                            TotalSongs = p.Songs.Count,
                            TotalDuration = p.Songs.Sum(s => (int?)s.Duration) ?? 0,
                            AverageDuration = p.Songs.Any() ? p.Songs.Average(s => (double?)s.Duration) ?? 0 : 0,
                            PopularGenre = p.Songs.GroupBy(s => s.Genre.Name).OrderByDescending(gr => gr.Count()).Select(gr => gr.Key).FirstOrDefault(),
                            MostRatedSong = p.Songs.OrderByDescending(s => s.Rating).Select(s => s.Title).FirstOrDefault()
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("PlaylistID", typeof(int));
            dt.Columns.Add("Playlist", typeof(string));
            dt.Columns.Add("CreatedDate", typeof(DateTime));
            dt.Columns.Add("TotalSongs", typeof(int));
            dt.Columns.Add("TotalDuration", typeof(int));
            dt.Columns.Add("AverageDuration", typeof(double));
            dt.Columns.Add("PopularGenre", typeof(string));
            dt.Columns.Add("MostRatedSong", typeof(string));

            foreach (var item in query)
            {
                dt.Rows.Add(item.PlaylistID, item.Playlist ?? string.Empty, item.CreatedDate, item.TotalSongs, item.TotalDuration, item.AverageDuration, item.PopularGenre ?? string.Empty, item.MostRatedSong ?? string.Empty);
            }

            return dt;
        }

        // Get songs in a playlist
        public DataTable GetSongsInPlaylist(int playlistId)
        {
            var query = from ps in musicEntity.PlaylistSongs
                        where ps.PlaylistID == playlistId
                        select new
                        {
                            SongTitle = ps.Song.Title,
                            ArtistName = ps.Song.Artist.Name,
                            Duration = ps.Song.Duration,
                            Rating = ps.Song.Rating
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("SongTitle", typeof(string));
            dt.Columns.Add("ArtistName", typeof(string));
            dt.Columns.Add("Duration", typeof(int));
            dt.Columns.Add("Rating", typeof(double));

            foreach (var item in query)
            {
                dt.Rows.Add(item.SongTitle ?? string.Empty, item.ArtistName ?? string.Empty, item.Duration, item.Rating ?? 0.0);
            }

            return dt;
        }

        // Add song into playlist
        public bool AddSongToPlaylist(int playlistId, int songId, ref string err)
        {
            try
            {
                var playlist = musicEntity.Playlists.Find(playlistId);
                var song = musicEntity.Songs.Find(songId);

                if (playlist == null || song == null)
                {
                    err = "Playlist or Song not found.";
                    return false;
                }

                // Check if the song is already in the playlist
                if (musicEntity.PlaylistSongs.Any(ps => ps.PlaylistID == playlistId && ps.SongID == songId))
                {
                    err = "Song is already in the playlist.";
                    return false;
                }

                playlist.Songs.Add(song);
                musicEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        // Remove a song from playlist
        public bool RemoveSongFromPlaylist(int playlistId, int songId, ref string err)
        {
            try
            {
                var playlistSong = musicEntity.PlaylistSongs
                    .FirstOrDefault(ps => ps.PlaylistID == playlistId && ps.SongID == songId);

                if (playlistSong == null)
                {
                    err = "Song not found in the playlist.";
                    return false;
                }

                musicEntity.PlaylistSongs.Remove(playlistSong);
                musicEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        // Create a new playlist
        public bool CreatePlaylist(string name, string description, ref string err)
        {
            try
            {
                if (BL_Users.CurrentUser == null)
                {
                    err = "You must be logged in to create a playlist.";
                    return false;
                }

                var playlist = new Playlist
                {
                    Name = name,
                    Description = description,
                    CreatorID = BL_Users.CurrentUser.UserID,
                    CreatedDate = DateTime.Now
                };

                musicEntity.Playlists.Add(playlist);
                musicEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        // Update playlist
        public bool UpdatePlaylist(int playlistId, string name, string description, ref string err)
        {
            try
            {
                var playlist = musicEntity.Playlists.Find(playlistId);
                if (playlist == null)
                {
                    err = "Playlist not found.";
                    return false;
                }

                // Check if the current user is the creator of the playlist
                if (BL_Users.CurrentUser == null || playlist.CreatorID != BL_Users.CurrentUser.UserID)
                {
                    err = "You don't have permission to modify this playlist.";
                    return false;
                }

                playlist.Name = name;
                playlist.Description = description;
                musicEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        // Delete playlist
        public bool DeletePlaylist(int playlistId, ref string err)
        {
            try
            {
                var playlist = musicEntity.Playlists.Find(playlistId);
                if (playlist == null)
                {
                    err = "Playlist not found.";
                    return false;
                }

                // Check if the current user is the creator of the playlist
                if (BL_Users.CurrentUser == null || playlist.CreatorID != BL_Users.CurrentUser.UserID)
                {
                    err = "You don't have permission to delete this playlist.";
                    return false;
                }

                musicEntity.Playlists.Remove(playlist);
                musicEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public DataTable GetAlbumStatistics()
        {
            var query = from a in musicEntity.Albums
                        select new
                        {
                            Album = a.Title,
                            a.Year,
                            ArtistName = a.Artist.Name,
                            TotalSongs = a.Songs.Count,
                            TotalDuration = a.Songs.Sum(s => (int?)s.Duration) ?? 0,
                            AverageDuration = a.Songs.Any() ? a.Songs.Average(s => (double?)s.Duration) ?? 0 : 0,
                            AverageRating = a.Songs.Any() ? a.Songs.Average(s => (double?)s.Rating) ?? 0 : 0,
                            TopRatedSong = a.Songs.OrderByDescending(s => s.Rating).Select(s => s.Title).FirstOrDefault(),
                            PopularGenre = a.Songs.GroupBy(s => s.Genre.Name).OrderByDescending(gr => gr.Count()).Select(gr => gr.Key).FirstOrDefault()
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("Album", typeof(string));
            dt.Columns.Add("Year", typeof(int));
            dt.Columns.Add("ArtistName", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));
            dt.Columns.Add("TotalDuration", typeof(int));
            dt.Columns.Add("AverageDuration", typeof(double));
            dt.Columns.Add("AverageRating", typeof(double));
            dt.Columns.Add("TopRatedSong", typeof(string));
            dt.Columns.Add("PopularGenre", typeof(string));

            foreach (var item in query)
            {
                dt.Rows.Add(item.Album ?? string.Empty, item.Year, item.ArtistName ?? string.Empty, 
                           item.TotalSongs, item.TotalDuration, item.AverageDuration, item.AverageRating,
                           item.TopRatedSong ?? string.Empty, item.PopularGenre ?? string.Empty);
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