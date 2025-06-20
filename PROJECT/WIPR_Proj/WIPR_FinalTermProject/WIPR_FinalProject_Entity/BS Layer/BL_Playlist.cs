using System;
using System.Data;
using System.Linq;
using WIPR_FinalProject_Entity;
using WIPR_FinalProject_Entity.BS_Layer;

internal class BL_Playlist
{
    private MusicLibraryDBEntities musicEntity = new MusicLibraryDBEntities();

    public DataTable GetAll()
    {
        var playlists = from p in musicEntity.Playlists
                       select new
                       {
                           p.PlaylistID,
                           p.Name,
                           p.Description,
                           p.CreatedDate,
                           p.CreatorID,
                           TotalSongs = p.Songs.Count
                           
                       };

        DataTable dt = new DataTable();
        dt.Columns.Add("PlaylistID", typeof(int));
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("Description", typeof(string));
        dt.Columns.Add("CreatedDate", typeof(DateTime));
        dt.Columns.Add("CreatorID", typeof(int));
        dt.Columns.Add("TotalSongs", typeof(int));
        

        foreach (var p in playlists)
        {
            dt.Rows.Add(p.PlaylistID, p.Name, p.Description, p.CreatedDate, 
                       p.CreatorID, p.TotalSongs);
        }

        return dt;
    }

    public void Insert(string name, string description)
    {
        if (BL_Users.CurrentUser == null)
            throw new Exception("You must be logged in to create a playlist");

        var playlist = new Playlist
        {
            Name = name,
            Description = description,
            CreatorID = BL_Users.CurrentUser.UserID,
            CreatedDate = DateTime.Now
        };

        musicEntity.Playlists.Add(playlist);
        musicEntity.SaveChanges();
    }

    public void Update(int id, string name, string description)
    {
        if (!CanModifyPlaylist(id, BL_Users.CurrentUser?.UserID ?? 0))
            throw new Exception("You don't have permission to modify this playlist");

        var playlist = musicEntity.Playlists.FirstOrDefault(p => p.PlaylistID == id);
        if (playlist != null)
        {
            playlist.Name = name;
            playlist.Description = description;
            musicEntity.SaveChanges();
        }
        else
        {
            throw new Exception("Playlist not found.");
        }
    }

    public void Delete(int id)
    {
        if (!CanModifyPlaylist(id, BL_Users.CurrentUser?.UserID ?? 0))
            throw new Exception("You don't have permission to delete this playlist");

        var playlist = musicEntity.Playlists.FirstOrDefault(p => p.PlaylistID == id);
        if (playlist != null)
        {
            // Remove all songs from playlist
            playlist.Songs.Clear();
            // Remove from favorites
            var favorites = musicEntity.FavoritePlaylists.Where(f => f.PlaylistID == id);
            musicEntity.FavoritePlaylists.RemoveRange(favorites);
            // Remove playlist
            musicEntity.Playlists.Remove(playlist);
            musicEntity.SaveChanges();
        }
        else
        {
            throw new Exception("Playlist not found.");
        }
    }

    public DataTable Search(string keyword)
    {
        var playlists = from p in musicEntity.Playlists
                       where p.Name.Contains(keyword) || p.Description.Contains(keyword)
                       select new
                       {
                           p.PlaylistID,
                           p.Name,
                           p.Description,
                           p.CreatedDate,
                           p.CreatorID,
                           TotalSongs = p.Songs.Count,
                           CreatorName = p.User.Username
                       };

        DataTable dt = new DataTable();
        dt.Columns.Add("PlaylistID", typeof(int));
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("Description", typeof(string));
        dt.Columns.Add("CreatedDate", typeof(DateTime));
        dt.Columns.Add("CreatorID", typeof(int));
        dt.Columns.Add("TotalSongs", typeof(int));
        dt.Columns.Add("CreatorName", typeof(string));

        foreach (var p in playlists)
        {
            dt.Rows.Add(p.PlaylistID, p.Name, p.Description, p.CreatedDate,
                       p.CreatorID, p.TotalSongs, p.CreatorName);
        }

        return dt;
    }

    public DataTable GetSongsInPlaylist(int playlistId)
    {
        var songs = from ps in musicEntity.PlaylistSongs
                   where ps.PlaylistID == playlistId
                   orderby ps.OrderIndex
                   select new
                   {
                       ps.SongID,
                       ps.Song.Title,
                       ps.OrderIndex
                   };

        DataTable dt = new DataTable();
        dt.Columns.Add("SongID", typeof(int));
        dt.Columns.Add("Title", typeof(string));
        dt.Columns.Add("OrderIndex", typeof(int));

        foreach (var song in songs)
        {
            dt.Rows.Add(song.SongID, song.Title, song.OrderIndex);
        }

        return dt;
    }

    public void AddSongToPlaylist(int playlistId, int songId)
    {
        if (!CanModifyPlaylist(playlistId, BL_Users.CurrentUser?.UserID ?? 0))
            throw new Exception("You don't have permission to modify this playlist");

        var playlist = musicEntity.Playlists.FirstOrDefault(p => p.PlaylistID == playlistId);
        var song = musicEntity.Songs.FirstOrDefault(s => s.SongID == songId);

        if (playlist != null && song != null)
        {
            // Get next order index
            int nextOrder = playlist.Songs.Any() ? 
                playlist.Songs.Max(s => s.PlaylistSongs.First(ps => ps.PlaylistID == playlistId).OrderIndex) + 1 : 1;

            var playlistSong = new PlaylistSong
            {
                PlaylistID = playlistId,
                SongID = songId,
                OrderIndex = nextOrder
            };

            musicEntity.PlaylistSongs.Add(playlistSong);
            musicEntity.SaveChanges();
        }
        else
        {
            throw new Exception("Playlist or Song not found.");
        }
    }

    public void RemoveSongFromPlaylist(int playlistId, int songId)
    {
        if (!CanModifyPlaylist(playlistId, BL_Users.CurrentUser?.UserID ?? 0))
            throw new Exception("You don't have permission to modify this playlist");

        var playlistSong = musicEntity.PlaylistSongs
            .FirstOrDefault(ps => ps.PlaylistID == playlistId && ps.SongID == songId);

        if (playlistSong != null)
        {
            musicEntity.PlaylistSongs.Remove(playlistSong);
            musicEntity.SaveChanges();
            ReorderPlaylistSongs(playlistId);
        }
        else
        {
            throw new Exception("Song not found in playlist.");
        }
    }

    public bool CanModifyPlaylist(int playlistId, int userId)
    {
        // Administrator can modify any playlist
        if (new BL_Users().IsAdmin())
            return true;

        var playlist = musicEntity.Playlists.FirstOrDefault(p => p.PlaylistID == playlistId);
        return playlist != null && playlist.CreatorID == userId;
    }

    public Playlist GetById(int playlistId)
    {
        var playlist = musicEntity.Playlists
            .FirstOrDefault(p => p.PlaylistID == playlistId);

        if (playlist == null)
            return null;

        return new Playlist
        {
            PlaylistID = playlist.PlaylistID,
            Name = playlist.Name,
            Description = playlist.Description,
            CreatorID = playlist.CreatorID,
            CreatedDate = playlist.CreatedDate
        };
    }

    public void SwapSongOrder(int playlistId, int songId1, int songId2)
    {
        if (!CanModifyPlaylist(playlistId, BL_Users.CurrentUser?.UserID ?? 0))
            throw new Exception("You don't have permission to modify this playlist");

        var ps1 = musicEntity.PlaylistSongs
            .FirstOrDefault(ps => ps.PlaylistID == playlistId && ps.SongID == songId1);
        var ps2 = musicEntity.PlaylistSongs
            .FirstOrDefault(ps => ps.PlaylistID == playlistId && ps.SongID == songId2);

        if (ps1 == null || ps2 == null)
            throw new Exception("One or both songs are not in this playlist");

        // Swap order indices
        int tempOrder = ps1.OrderIndex;
        ps1.OrderIndex = ps2.OrderIndex;
        ps2.OrderIndex = tempOrder;

        musicEntity.SaveChanges();
    }

    private void ReorderPlaylistSongs(int playlistId)
    {
        var songs = musicEntity.PlaylistSongs
            .Where(ps => ps.PlaylistID == playlistId)
            .OrderBy(ps => ps.OrderIndex)
            .ToList();

        int newOrder = 1;
        foreach (var song in songs)
        {
            song.OrderIndex = newOrder++;
        }

        musicEntity.SaveChanges();
    }
}
