using System;
using System.Data;
using System.Linq;
using WIPR_FinalProject_Entity;

namespace WIPR_FinalProject_Entity.BS_Layer
{
    public class BL_Genre
    {
        private MusicLibraryDBEntities musicEntity = new MusicLibraryDBEntities();

        public DataTable GetAll()
        {
            var genres = from g in musicEntity.Genres
                        select new
                        {
                            g.GenreID,
                            g.Name,
                            TotalSongs = g.Songs.Count
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("GenreID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));

            foreach (var genre in genres)
            {
                dt.Rows.Add(
                    genre.GenreID,
                    genre.Name ?? string.Empty,
                    genre.TotalSongs
                );
            }

            return dt;
        }

        public DataTable GetAllWithTotalSongs()
        {
            return GetAll(); // Already includes total songs
        }

        public void Insert(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Genre name cannot be empty.");

            var genre = new Genre
            {
                Name = name
            };

            musicEntity.Genres.Add(genre);
            musicEntity.SaveChanges();
        }

        public void Update(int id, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Genre name cannot be empty.");

            var genre = musicEntity.Genres.FirstOrDefault(g => g.GenreID == id);
            if (genre != null)
            {
                genre.Name = name;
                musicEntity.SaveChanges();
            }
            else
            {
                throw new Exception("Genre not found.");
            }
        }

        public bool HasSongs(int genreId)
        {
            return musicEntity.Songs.Any(s => s.GenreID == genreId);
        }

        public void Delete(int id)
        {
            if (HasSongs(id))
                throw new Exception("Cannot delete this genre because there are songs associated with it.");

            var genre = musicEntity.Genres.FirstOrDefault(g => g.GenreID == id);
            if (genre != null)
            {
                musicEntity.Genres.Remove(genre);
                musicEntity.SaveChanges();
            }
            else
            {
                throw new Exception("Genre not found.");
            }
        }

        public DataTable Search(string keyword)
        {
            var genres = from g in musicEntity.Genres
                        where g.Name.Contains(keyword)
                        select new
                        {
                            g.GenreID,
                            g.Name,
                            TotalSongs = g.Songs.Count
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("GenreID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));

            foreach (var genre in genres)
            {
                dt.Rows.Add(
                    genre.GenreID,
                    genre.Name ?? string.Empty,
                    genre.TotalSongs
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
