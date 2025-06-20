using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WIPR_FinalProject_Entity.BS_Layer;
using WIPR_FinalProject_Entity.Classes;

namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormPlaylistSongs : Form
    {
        private int playlistId;
        private string playlistName;
        private bool canModify = false;

        private BL_Playlist playlistBLL = new BL_Playlist();
        private BL_Song songBLL = new BL_Song();

        private DataTable allSongsTable;
        private DataTable songsInPlaylistTable;
        private List<BL_Song.SongDetailDTO> songsInPlaylist = new List<BL_Song.SongDetailDTO>();
        private int currentPlayingIndex = -1;

        public FormPlaylistSongs(int playlistId, string playlistName)
        {
            InitializeComponent();
            this.playlistId = playlistId;
            this.playlistName = playlistName;
        }

        private void FormPlaylistSongs_Load(object sender, EventArgs e)
        {
            // Setup Unicode font for controls to display Vietnamese content
            SetupVietnameseFonts();

            lblTitle.Text = $"Playlist: {playlistName}";

            // Check if the current user can modify this playlist
            canModify = playlistBLL.CanModifyPlaylist(playlistId, BL_Users.CurrentUser?.UserID ?? 0);

            // Set button visibility based on permissions
            btnAdd.Visible = canModify;
            btnRemove.Visible = canModify;
            btnMoveUp.Visible = canModify;
            btnMoveDown.Visible = canModify;

            // Display creator info if available
            Playlist playlist = playlistBLL.GetById(playlistId);
            if (playlist != null && playlist.User != null && !string.IsNullOrEmpty(playlist.User.Username))
            {
                lblCreator.Text = $"Created by: {playlist.User.Username}";
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

            // Setup font for labels
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            lblSongInfo.Font = vietnameseFont;
            lblNowPlaying.Font = vietnameseFont;
        }

        private void LoadData()
        {
            // Get songs already in playlist
            songsInPlaylistTable = playlistBLL.GetSongsInPlaylist(playlistId);

            // Get detailed song information for playback
            songsInPlaylist.Clear();
            foreach (DataRow row in songsInPlaylistTable.Rows)
            {
                int songId = Convert.ToInt32(row["SongID"]);
                BL_Song.SongDetailDTO song = songBLL.GetSongById(songId);
                if (song != null)
                {
                    songsInPlaylist.Add(song);
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
            lstInPlaylist.DataSource = songsInPlaylist;
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
                    BL_Song.SongDetailDTO selectedSong = (BL_Song.SongDetailDTO)lstInPlaylist.SelectedItem;
                    int songId = selectedSong.SongID;

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
            if (lstInPlaylist.SelectedItem is BL_Song.SongDetailDTO selected)
            {
                // Format duration as minutes:seconds
                string durationStr = "N/A";
                if (selected.Duration > 0)
                {
                    int minutes = (int)(selected.Duration / 60);
                    int seconds = (int)(selected.Duration % 60);
                    durationStr = $"{minutes}:{seconds:D2}";
                }

                // Display song information
                lblSongInfo.Text = $"Title: {selected.Title}\r\n" +
                                  $"Artist: {selected.ArtistName ?? "N/A"}\r\n" +
                                  $"Album: {selected.AlbumTitle ?? "N/A"}\r\n" +
                                  $"Genre: {selected.GenreName ?? "N/A"}\r\n" +
                                  $"Year: {(selected.Year > 0 ? selected.Year.ToString() : "N/A")}\r\n" +
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
            if (lstInPlaylist.SelectedItem is BL_Song.SongDetailDTO selected)
            {
                if (string.IsNullOrEmpty(selected.FilePath))
                {
                    MessageBox.Show("This song does not have a file path. Cannot play.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                player.URL = selected.FilePath;
                player.Ctlcontrols.play();
                currentPlayingIndex = lstInPlaylist.SelectedIndex;
                lblNowPlaying.Text = $"🎵 Now Playing: {selected.Title}";
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
            if (songsInPlaylist.Count > 0)
            {
                // Find first song with valid filepath
                currentPlayingIndex = songsInPlaylist.FindIndex(s => !string.IsNullOrEmpty(s.FilePath));

                if (currentPlayingIndex == -1)
                {
                    MessageBox.Show("No songs in this playlist have valid file paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                player.URL = songsInPlaylist[currentPlayingIndex].FilePath;
                player.Ctlcontrols.play();
                lblNowPlaying.Text = $"🎵 Now Playing: {songsInPlaylist[currentPlayingIndex].Title}";

                // Select the first song in the list
                lstInPlaylist.SelectedIndex = currentPlayingIndex;
            }
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // WMPPlayState.wmppsMediaEnded = 8
            if (e.newState == 8 && currentPlayingIndex >= 0 && currentPlayingIndex < songsInPlaylist.Count - 1)
            {
                // Find next song with valid filepath
                int nextIndex = currentPlayingIndex + 1;
                while (nextIndex < songsInPlaylist.Count && string.IsNullOrEmpty(songsInPlaylist[nextIndex].FilePath))
                {
                    nextIndex++;
                }

                if (nextIndex < songsInPlaylist.Count)
                {
                    currentPlayingIndex = nextIndex;
                    player.URL = songsInPlaylist[currentPlayingIndex].FilePath;
                    player.Ctlcontrols.play();
                    lblNowPlaying.Text = $"🎵 Now Playing: {songsInPlaylist[currentPlayingIndex].Title}";

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
            else if (e.newState == 8 && currentPlayingIndex == songsInPlaylist.Count - 1)
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
            BL_Song.SongDetailDTO selectedSong = songsInPlaylist[selectedIndex];
            BL_Song.SongDetailDTO previousSong = songsInPlaylist[selectedIndex - 1];

            try
            {
                // Update order in database
                playlistBLL.SwapSongOrder(playlistId, selectedSong.SongID, previousSong.SongID);

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
            BL_Song.SongDetailDTO selectedSong = songsInPlaylist[selectedIndex];
            BL_Song.SongDetailDTO nextSong = songsInPlaylist[selectedIndex + 1];

            try
            {
                // Update order in database
                playlistBLL.SwapSongOrder(playlistId, selectedSong.SongID, nextSong.SongID);

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
