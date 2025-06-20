using System;
using System.Data;
using System.Linq;
using WIPR_FinalProject_Entity;
using System.Collections.Generic;

namespace WIPR_FinalProject_Entity.BS_Layer
{
    public class BL_Song : IDisposable
    {
        private MusicLibraryDBEntities musicEntity = new MusicLibraryDBEntities();

        public class SongDetailDTO
        {
            public int SongID { get; set; }
            public string Title { get; set; }
            public int? Duration { get; set; }
            public int? Year { get; set; }
            public double? Rating { get; set; }
            public int? ArtistID { get; set; }
            public string ArtistName { get; set; }
            public int? AlbumID { get; set; }
            public string AlbumTitle { get; set; }
            public int? GenreID { get; set; }
            public string GenreName { get; set; }
            public string FilePath { get; set; }
        }

        public DataTable GetAll()
        {
            var query = from s in musicEntity.Songs
                        select new
                        {
                            s.SongID,
                            s.Title,
                            s.Duration,
                            s.Year,
                            s.Rating,
                            s.ArtistID,
                            ArtistName = s.Artist != null ? s.Artist.Name : null,
                            s.AlbumID,
                            AlbumTitle = s.Album != null ? s.Album.Title : null,
                            s.GenreID,
                            GenreName = s.Genre != null ? s.Genre.Name : null,
                            s.FilePath
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("SongID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Duration", typeof(int));
            dt.Columns.Add("Year", typeof(int));
            dt.Columns.Add("Rating", typeof(int));
            dt.Columns.Add("ArtistID", typeof(int));
            dt.Columns.Add("ArtistName", typeof(string));
            dt.Columns.Add("AlbumID", typeof(int));
            dt.Columns.Add("AlbumTitle", typeof(string));
            dt.Columns.Add("GenreID", typeof(int));
            dt.Columns.Add("GenreName", typeof(string));
            dt.Columns.Add("FilePath", typeof(string));

            foreach (var song in query)
            {
                dt.Rows.Add(
                    song.SongID,
                    song.Title ?? string.Empty,
                    song.Duration,
                    song.Year ?? 0,
                    song.Rating ?? 0,
                    song.ArtistID ?? 0,
                    song.ArtistName ?? string.Empty,
                    song.AlbumID ?? 0,
                    song.AlbumTitle ?? string.Empty,
                    song.GenreID ?? 0,
                    song.GenreName ?? string.Empty,
                    song.FilePath ?? string.Empty
                );
            }

            return dt;
        }

        public void Insert(string title, int duration, int year, int rating, int artistId, int albumId, int genreId, string filePath)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty", nameof(title));
            if (duration <= 0)
                throw new ArgumentException("Duration must be greater than 0", nameof(duration));
            if (year <= 0)
                throw new ArgumentException("Year must be greater than 0", nameof(year));
            if (rating < 0 || rating > 5)
                throw new ArgumentException("Rating must be between 0 and 5", nameof(rating));

            try
            {
                var song = new Song
                {
                    Title = title,
                    Duration = duration,
                    Year = year,
                    Rating = rating,
                    ArtistID = artistId,
                    AlbumID = albumId,
                    GenreID = genreId,
                    FilePath = filePath
                };

                musicEntity.Songs.Add(song);
                musicEntity.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to insert song: {ex.Message}", ex);
            }
        }

        public void Update(int id, string title, int duration, int year, int rating, int artistId, int albumId, int genreId, string filePath)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty", nameof(title));
            if (duration <= 0)
                throw new ArgumentException("Duration must be greater than 0", nameof(duration));
            if (year <= 0)
                throw new ArgumentException("Year must be greater than 0", nameof(year));
            if (rating < 0 || rating > 5)
                throw new ArgumentException("Rating must be between 0 and 5", nameof(rating));

            try
            {
                var song = musicEntity.Songs.Find(id);
                if (song == null)
                    throw new InvalidOperationException("Song not found");

                song.Title = title;
                song.Duration = duration;
                song.Year = year;
                song.Rating = rating;
                song.ArtistID = artistId;
                song.AlbumID = albumId;
                song.GenreID = genreId;
                song.FilePath = filePath;

                musicEntity.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update song: {ex.Message}", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var song = musicEntity.Songs.Find(id);
                if (song == null)
                    throw new InvalidOperationException("Song not found");

                // Remove song from all playlists
                var playlistSongs = musicEntity.PlaylistSongs.Where(ps => ps.SongID == id);
                musicEntity.PlaylistSongs.RemoveRange(playlistSongs);

                musicEntity.Songs.Remove(song);
                musicEntity.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete song: {ex.Message}", ex);
            }
        }

        public DataTable Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAll();

            var query = from s in musicEntity.Songs
                       where s.Title.Contains(keyword)
                       select new
                       {
                           s.SongID,
                           s.Title,
                           s.Duration,
                           s.Year,
                           s.Rating,
                           s.ArtistID,
                           ArtistName = s.Artist.Name,
                           s.AlbumID,
                           AlbumTitle = s.Album.Title,
                           s.GenreID,
                           GenreName = s.Genre.Name,
                           s.FilePath
                       };

            DataTable dt = new DataTable();
            dt.Columns.Add("SongID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Duration", typeof(int));
            dt.Columns.Add("Year", typeof(int));
            dt.Columns.Add("Rating", typeof(int));
            dt.Columns.Add("ArtistID", typeof(int));
            dt.Columns.Add("ArtistName", typeof(string));
            dt.Columns.Add("AlbumID", typeof(int));
            dt.Columns.Add("AlbumTitle", typeof(string));
            dt.Columns.Add("GenreID", typeof(int));
            dt.Columns.Add("GenreName", typeof(string));
            dt.Columns.Add("FilePath", typeof(string));

            foreach (var song in query)
            {
                dt.Rows.Add(
                    song.SongID,
                    song.Title ?? string.Empty,
                    song.Duration,
                    song.Year ?? 0,
                    song.Rating ?? 0,
                    song.ArtistID ?? 0,
                    song.ArtistName ?? string.Empty,
                    song.AlbumID ?? 0,
                    song.AlbumTitle ?? string.Empty,
                    song.GenreID ?? 0,
                    song.GenreName ?? string.Empty,
                    song.FilePath ?? string.Empty
                );
            }

            return dt;
        }

        public SongDetailDTO GetSongById(int songId)
        {
            var song = musicEntity.Songs.Find(songId);
            if (song == null)
                return null;

            return new SongDetailDTO
            {
                SongID = song.SongID,
                Title = song.Title ?? string.Empty,
                Duration = song.Duration,
                Year = song.Year,
                Rating = song.Rating,
                ArtistID = song.ArtistID,
                ArtistName = song.Artist?.Name ?? string.Empty,
                AlbumID = song.AlbumID,
                AlbumTitle = song.Album?.Title ?? string.Empty,
                GenreID = song.GenreID,
                GenreName = song.Genre?.Name ?? string.Empty,
                FilePath = song.FilePath ?? string.Empty
            };
        }

        public List<SongDetailDTO> GetAllWithFilePath()
        {
            var songs = from s in musicEntity.Songs
                       where s.FilePath != null && s.FilePath != ""
                       select new SongDetailDTO
                       {
                           SongID = s.SongID,
                           Title = s.Title ?? string.Empty,
                           Duration = s.Duration,
                           Year = s.Year,
                           Rating = s.Rating,
                           ArtistID = s.ArtistID,
                           ArtistName = s.Artist.Name ?? string.Empty,
                           AlbumID = s.AlbumID,
                           AlbumTitle = s.Album.Title ?? string.Empty,
                           GenreID = s.GenreID,
                           GenreName = s.Genre.Name ?? string.Empty,
                           FilePath = s.FilePath ?? string.Empty
                       };

            return songs.ToList();
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
