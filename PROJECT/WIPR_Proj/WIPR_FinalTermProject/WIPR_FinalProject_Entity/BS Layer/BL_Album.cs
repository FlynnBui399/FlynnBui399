using System;
using System.Data;
using System.Linq;
using WIPR_FinalProject_Entity;

namespace WIPR_FinalProject_Entity.BS_Layer
{
    internal class BL_Album
    {
        private MusicLibraryDBEntities musicEntity = new MusicLibraryDBEntities();
        
        public DataTable GetAll()
        {
            var albums = from a in musicEntity.Albums
                        select new
                        {
                            a.AlbumID,
                            a.Title,
                            a.Year,
                            a.ArtistID,
                            ArtistName = a.Artist.Name,
                            TotalSongs = a.Songs.Count
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("AlbumID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Year", typeof(int));
            dt.Columns.Add("ArtistID", typeof(int));
            dt.Columns.Add("ArtistName", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));

            foreach (var album in albums)
            {
                dt.Rows.Add(
                    album.AlbumID,
                    album.Title ?? string.Empty,
                    album.Year,
                    album.ArtistID,
                    album.ArtistName ?? string.Empty,
                    album.TotalSongs
                );
            }

            return dt;
        }

        public bool HasSongs(int albumId)
        {
            return musicEntity.Songs.Any(s => s.AlbumID == albumId);
        }

        public void Insert(string title, int year, int artistId)
        {
            var album = new Album
            {
                Title = title,
                Year = year,
                ArtistID = artistId
            };

            musicEntity.Albums.Add(album);
            musicEntity.SaveChanges();
        }

        public void Update(int id, string title, int year, int artistId)
        {
            var album = musicEntity.Albums.FirstOrDefault(a => a.AlbumID == id);
            if (album != null)
            {
                album.Title = title;
                album.Year = year;
                album.ArtistID = artistId;
                musicEntity.SaveChanges();
            }
            else
            {
                throw new Exception("Album not found.");
            }
        }

        public void Delete(int id)
        {
            if (HasSongs(id))
                throw new Exception("Cannot delete this album because there are songs associated with it.");

            var album = musicEntity.Albums.FirstOrDefault(a => a.AlbumID == id);
            if (album != null)
            {
                musicEntity.Albums.Remove(album);
                musicEntity.SaveChanges();
            }
            else
            {
                throw new Exception("Album not found.");
            }
        }

        public DataTable Search(string keyword)
        {
            var albums = from a in musicEntity.Albums
                        where a.Title.Contains(keyword)
                        select new
                        {
                            a.AlbumID,
                            a.Title,
                            a.Year,
                            a.ArtistID,
                            ArtistName = a.Artist.Name,
                            TotalSongs = a.Songs.Count
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("AlbumID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Year", typeof(int));
            dt.Columns.Add("ArtistID", typeof(int));
            dt.Columns.Add("ArtistName", typeof(string));
            dt.Columns.Add("TotalSongs", typeof(int));

            foreach (var album in albums)
            {
                dt.Rows.Add(
                    album.AlbumID,
                    album.Title ?? string.Empty,
                    album.Year,
                    album.ArtistID,
                    album.ArtistName ?? string.Empty,
                    album.TotalSongs
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
