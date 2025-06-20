using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WIPR_FinalTermProject.BS_layer;

namespace WIPR_FinalTermProject.Forms_layer
{
    public partial class FormPlaylistSongs : Form
    {
        private int playlistId;
        private string playlistName;
        private bool canModify = false;

        private PlaylistBLL playlistBLL = new PlaylistBLL();
        private SongBLL songBLL = new SongBLL();

        private DataTable allSongsTable;
        private DataTable songsInPlaylistTable;
        private DataTable songsInPlaylistDetails;
        private int currentPlayingIndex = -1;

        public FormPlaylistSongs(int playlistId, string playlistName)
        {
            InitializeComponent();
            this.playlistId = playlistId;
            this.playlistName = playlistName;
        }

        private void FormPlaylistSongs_Load(object sender, EventArgs e)
        {
            SetupVietnameseFonts();
            
            lblTitle.Text = $"Playlist: {playlistName}";

            // Check if the current user can modify this playlist
            canModify = playlistBLL.CanModifyPlaylist(playlistId, UserBLL.CurrentUser.UserID ?? 0);
            
            // Set button visibility based on permissions
            btnAdd.Visible = canModify;
            btnRemove.Visible = canModify;
            btnMoveUp.Visible = canModify;
            btnMoveDown.Visible = canModify;
            
            // Display creator info if available
            DataRow playlistRow = playlistBLL.GetById(playlistId);
            if (playlistRow != null && !string.IsNullOrEmpty(PlaylistBLL.GetCreatorName(playlistRow)))
            {
                lblCreator.Text = $"Created by: {PlaylistBLL.GetCreatorName(playlistRow)}";
                lblCreator.Visible = true;
            }
            
            if (!canModify)
            {
                lblPermission.Text = "You can view but not modify this playlist";
                lblPermission.Visible = true;
            }

            LoadData();
            LoadListBoxes();
        }
        
        private void SetupVietnameseFonts()
        {
            // Setup font for ListBoxes
            System.Drawing.Font vietnameseFont = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Regular);
            lstInPlaylist.Font = vietnameseFont;
            lstAvailable.Font = vietnameseFont;
            
            // Setup font for Labels
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            lblSongInfo.Font = vietnameseFont;
            lblNowPlaying.Font = vietnameseFont;
        }

        private void LoadData()
        {
            // Get songs already in playlist
            songsInPlaylistTable = playlistBLL.GetSongsInPlaylist(playlistId);
            
            songsInPlaylistDetails = new DataTable();
            songsInPlaylistDetails.Columns.Add("SongID", typeof(int));
            songsInPlaylistDetails.Columns.Add("Title", typeof(string));
            songsInPlaylistDetails.Columns.Add("Duration", typeof(int));
            songsInPlaylistDetails.Columns.Add("Year", typeof(int));
            songsInPlaylistDetails.Columns.Add("Rating", typeof(int));
            songsInPlaylistDetails.Columns.Add("ArtistID", typeof(int));
            songsInPlaylistDetails.Columns.Add("AlbumID", typeof(int));
            songsInPlaylistDetails.Columns.Add("GenreID", typeof(int));
            songsInPlaylistDetails.Columns.Add("ArtistName", typeof(string));
            songsInPlaylistDetails.Columns.Add("AlbumTitle", typeof(string));
            songsInPlaylistDetails.Columns.Add("GenreName", typeof(string));
            songsInPlaylistDetails.Columns.Add("FilePath", typeof(string));
            
            foreach (DataRow row in songsInPlaylistTable.Rows)
            {
                int songId = Convert.ToInt32(row["SongID"]);
                DataRow songRow = songBLL.GetSongById(songId);
                if (songRow != null)
                {
                    DataRow newRow = songsInPlaylistDetails.NewRow();
                    newRow["SongID"] = SongBLL.GetSongId(songRow);
                    newRow["Title"] = SongBLL.GetSongTitle(songRow);
                    newRow["Duration"] = SongBLL.GetSongDuration(songRow);
                    newRow["Year"] = SongBLL.GetSongYear(songRow);
                    newRow["Rating"] = SongBLL.GetSongRating(songRow);
                    newRow["ArtistID"] = songRow["ArtistID"];
                    newRow["AlbumID"] = songRow["AlbumID"];
                    newRow["GenreID"] = songRow["GenreID"];
                    newRow["ArtistName"] = SongBLL.GetArtistName(songRow);
                    newRow["AlbumTitle"] = SongBLL.GetAlbumTitle(songRow);
                    newRow["GenreName"] = SongBLL.GetGenreName(songRow);
                    newRow["FilePath"] = SongBLL.GetSongFilePath(songRow);
                    songsInPlaylistDetails.Rows.Add(newRow);
                }
            }

            // Get all songs
            allSongsTable = songBLL.GetAll();
        }

        private void LoadListBoxes()
        {
            // Filter available songs (songs not in playlist)
            var availableSongs = allSongsTable.AsEnumerable()
                .Where(row => !songsInPlaylistTable.AsEnumerable()
                .Any(inPlaylistRow => (int)inPlaylistRow["SongID"] == (int)row["SongID"]))
                .CopyToDataTableOrNull();

            lstAvailable.DataSource = null;
            lstAvailable.DataSource = availableSongs ?? allSongsTable.Clone(); // If null, empty list
            lstAvailable.DisplayMember = "Title";
            lstAvailable.ValueMember = "SongID";

            lstInPlaylist.DataSource = null;
            lstInPlaylist.DataSource = songsInPlaylistDetails;
            lstInPlaylist.DisplayMember = "Title";
            lstInPlaylist.ValueMember = "SongID";
            
            // Update song information display
            UpdateSongInfoDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!canModify)
            {
                MessageBox.Show("You don't have permission to modify this playlist", 
                    "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                if (lstAvailable.SelectedItem != null)
                {
                    DataRowView row = (DataRowView)lstAvailable.SelectedItem;
                    int songId = Convert.ToInt32(row["SongID"]);
                    
                    playlistBLL.AddSongToPlaylist(playlistId, songId);
                    
                    LoadData();
                    LoadListBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!canModify)
            {
                MessageBox.Show("You don't have permission to modify this playlist", 
                    "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                if (lstInPlaylist.SelectedItem != null)
                {
                    DataRowView selectedSong = (DataRowView)lstInPlaylist.SelectedItem;
                    int songId = Convert.ToInt32(selectedSong["SongID"]);
                    
                    playlistBLL.RemoveSongFromPlaylist(playlistId, songId);
                    
                    LoadData();
                    LoadListBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Stop playback if playing
            if (player != null && player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.stop();
            }
            this.Close();
        }
        
        private void UpdateSongInfoDisplay()
        {
            if (lstInPlaylist.SelectedItem is DataRowView selected)
            {
                DataRow row = selected.Row;
                
                // Format duration as minutes:seconds
                string durationStr = "N/A";
                int duration = row["Duration"] != DBNull.Value ? Convert.ToInt32(row["Duration"]) : 0;
                if (duration > 0)
                {
                    int minutes = duration / 60;
                    int seconds = duration % 60;
                    durationStr = $"{minutes}:{seconds:D2}";
                }

                // Display song information
                lblSongInfo.Text = $"Title: {row["Title"]?.ToString() ?? "N/A"}\r\n" +
                                  $"Artist: {row["ArtistName"]?.ToString() ?? "N/A"}\r\n" +
                                  $"Album: {row["AlbumTitle"]?.ToString() ?? "N/A"}\r\n" +
                                  $"Genre: {row["GenreName"]?.ToString() ?? "N/A"}\r\n" +
                                  $"Year: {(row["Year"] != DBNull.Value && Convert.ToInt32(row["Year"]) > 0 ? row["Year"].ToString() : "N/A")}\r\n" +
                                  $"Duration: {durationStr}";
            }
            else
            {
                lblSongInfo.Text = "";
            }
        }
        
        private void lstInPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSongInfoDisplay();
        }
        
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lstInPlaylist.SelectedItem is DataRowView selected)
            {
                DataRow row = selected.Row;
                string filePath = row["FilePath"]?.ToString() ?? "";
                string title = row["Title"]?.ToString() ?? "";
                
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("This song does not have a file path. Cannot play.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                player.URL = filePath;
                player.Ctlcontrols.play();
                currentPlayingIndex = lstInPlaylist.SelectedIndex;
                lblNowPlaying.Text = $"🎵 Now Playing: {title}";
            }
        }
        
        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            lblNowPlaying.Text = "⏹ Stopped";
            currentPlayingIndex = -1;
        }
        
        private void btnPlayAll_Click(object sender, EventArgs e)
        {
            if (songsInPlaylistDetails.Rows.Count > 0)
            {
                // Find first song with valid filepath
                currentPlayingIndex = -1;
                for (int i = 0; i < songsInPlaylistDetails.Rows.Count; i++)
                {
                    string filePath = songsInPlaylistDetails.Rows[i]["FilePath"]?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        currentPlayingIndex = i;
                        break;
                    }
                }
                
                if (currentPlayingIndex == -1)
                {
                    MessageBox.Show("No songs in this playlist have valid file paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow firstSong = songsInPlaylistDetails.Rows[currentPlayingIndex];
                player.URL = firstSong["FilePath"].ToString();
                player.Ctlcontrols.play();
                lblNowPlaying.Text = $"🎵 Now Playing: {firstSong["Title"]}";
                
                // Select the first song in the list
                lstInPlaylist.SelectedIndex = currentPlayingIndex;
            }
        }
        
        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // WMPPlayState.wmppsMediaEnded = 8
            if (e.newState == 8 && currentPlayingIndex >= 0 && currentPlayingIndex < songsInPlaylistDetails.Rows.Count - 1)
            {
                // Find next song with valid filepath
                int nextIndex = currentPlayingIndex + 1;
                while (nextIndex < songsInPlaylistDetails.Rows.Count)
                {
                    string filePath = songsInPlaylistDetails.Rows[nextIndex]["FilePath"]?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        break;
                    }
                    nextIndex++;
                }

                if (nextIndex < songsInPlaylistDetails.Rows.Count)
                {
                    currentPlayingIndex = nextIndex;
                    DataRow nextSong = songsInPlaylistDetails.Rows[currentPlayingIndex];
                    player.URL = nextSong["FilePath"].ToString();
                    player.Ctlcontrols.play();
                    lblNowPlaying.Text = $"🎵 Now Playing: {nextSong["Title"]}";
                    
                    // Select the current song in the list
                    lstInPlaylist.SelectedIndex = currentPlayingIndex;
                }
                else
                {
                    // No more songs with valid filepath
                    lblNowPlaying.Text = "⏹ Playlist Ended";
                    currentPlayingIndex = -1;
                }
            }
            else if (e.newState == 8 && currentPlayingIndex == songsInPlaylistDetails.Rows.Count - 1)
            {
                // End of playlist
                lblNowPlaying.Text = "⏹ Playlist Ended";
                currentPlayingIndex = -1;
            }
        }
        
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (!canModify || lstInPlaylist.SelectedItem == null || lstInPlaylist.SelectedIndex == 0)
                return;
                
            int selectedIndex = lstInPlaylist.SelectedIndex;
            DataRow selectedSong = songsInPlaylistDetails.Rows[selectedIndex];
            DataRow previousSong = songsInPlaylistDetails.Rows[selectedIndex - 1];
            
            try
            {
                // Update order in database
                int selectedSongId = Convert.ToInt32(selectedSong["SongID"]);
                int previousSongId = Convert.ToInt32(previousSong["SongID"]);
                playlistBLL.SwapSongOrder(playlistId, selectedSongId, previousSongId);
                
                // Reload data to reflect the new order
                LoadData();
                LoadListBoxes();
                
                // Keep selection on the same song (now moved up)
                lstInPlaylist.SelectedIndex = selectedIndex - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (!canModify || lstInPlaylist.SelectedItem == null || 
                lstInPlaylist.SelectedIndex == lstInPlaylist.Items.Count - 1)
                return;
                
            int selectedIndex = lstInPlaylist.SelectedIndex;
            DataRow selectedSong = songsInPlaylistDetails.Rows[selectedIndex];
            DataRow nextSong = songsInPlaylistDetails.Rows[selectedIndex + 1];
            
            try
            {
                // Update order in database
                int selectedSongId = Convert.ToInt32(selectedSong["SongID"]);
                int nextSongId = Convert.ToInt32(nextSong["SongID"]);
                playlistBLL.SwapSongOrder(playlistId, selectedSongId, nextSongId);
                
                // Reload data to reflect the new order
                LoadData();
                LoadListBoxes();
                
                // Keep selection on the same song (now moved down)
                lstInPlaylist.SelectedIndex = selectedIndex + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public static class DataTableExtensions
    {
        public static DataTable CopyToDataTableOrNull(this IEnumerable<DataRow> source)
        {
            var rows = source.ToList();
            if (rows.Count == 0) return null;
            return rows.CopyToDataTable();
        }
    }
}
