using System;
using System.Data;
using System.Linq;
using WIPR_FinalProject_Entity;

namespace WIPR_FinalProject_Entity.BS_Layer
{
    public class BL_Artist
    {
        private MusicLibraryDBEntities musicEntity = new MusicLibraryDBEntities();

        // Get all artists
        public DataTable GetAll()
        {
            var artists = from a in musicEntity.Artists
                         select new
                         {
                             a.ArtistID,
                             a.Name,
                             a.Birthdate,
                             a.Nationality,
                             TotalSongs = a.Songs.Count,
                             TotalAlbums = a.Albums.Count
                         };

            DataTable dt = new DataTable();
            dt.Columns.Add("ArtistID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Birthdate", typeof(DateTime));
            dt.Columns.Add("Nationality", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));
            dt.Columns.Add("TotalAlbums", typeof(int));

            foreach (var artist in artists)
            {
                dt.Rows.Add(
                    artist.ArtistID,
                    artist.Name ?? string.Empty,
                    artist.Birthdate ?? DateTime.MinValue,
                    artist.Nationality ?? string.Empty,
                    artist.TotalSongs,
                    artist.TotalAlbums
                );
            }

            return dt;
        }

        // Insert a new artist
        public void Insert(string name, DateTime birthdate, string nationality)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Artist name cannot be empty.");

            if (birthdate > DateTime.Now)
                throw new Exception("Birthdate cannot be in the future.");

            var artist = new Artist
            {
                Name = name,
                Birthdate = birthdate,
                Nationality = nationality
            };

            musicEntity.Artists.Add(artist);
            musicEntity.SaveChanges();
        }

        // Update an artist's details
        public void Update(int id, string name, DateTime birthdate, string nationality)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Artist name cannot be empty.");

            if (birthdate > DateTime.Now)
                throw new Exception("Birthdate cannot be in the future.");

            var artist = musicEntity.Artists.FirstOrDefault(a => a.ArtistID == id);
            if (artist != null)
            {
                artist.Name = name;
                artist.Birthdate = birthdate;
                artist.Nationality = nationality;
                musicEntity.SaveChanges();
            }
            else
            {
                throw new Exception("Artist not found.");
            }
        }

        // Check if the artist has any songs
        public bool HasSongs(int artistId)
        {
            return musicEntity.Songs.Any(s => s.ArtistID == artistId);
        }

        // Delete an artist
        public void Delete(int id)
        {
            if (HasSongs(id))
                throw new Exception("Cannot delete this artist because there are songs associated with it.");

            var artist = musicEntity.Artists.FirstOrDefault(a => a.ArtistID == id);
            if (artist != null)
            {
                musicEntity.Artists.Remove(artist);
                musicEntity.SaveChanges();
            }
            else
            {
                throw new Exception("Artist not found.");
            }
        }

        // Search artists by name or nationality
        public DataTable Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAll();

            var artists = from a in musicEntity.Artists
                         where a.Name.Contains(keyword) || (a.Nationality != null && a.Nationality.Contains(keyword))
                         select new
                         {
                             a.ArtistID,
                             a.Name,
                             a.Birthdate,
                             a.Nationality,
                             TotalSongs = a.Songs.Count,
                             TotalAlbums = a.Albums.Count
                         };

            DataTable dt = new DataTable();
            dt.Columns.Add("ArtistID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Birthdate", typeof(DateTime));
            dt.Columns.Add("Nationality", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));
            dt.Columns.Add("TotalAlbums", typeof(int));

            foreach (var artist in artists)
            {
                dt.Rows.Add(
                    artist.ArtistID,
                    artist.Name ?? string.Empty,
                    artist.Birthdate ?? DateTime.MinValue,
                    artist.Nationality ?? string.Empty,
                    artist.TotalSongs,
                    artist.TotalAlbums
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

