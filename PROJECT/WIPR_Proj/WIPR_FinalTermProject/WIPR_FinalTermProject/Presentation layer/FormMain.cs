using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIPR_FinalTermProject.BS_layer;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.Forms_layer
{
    public partial class FormMain : Form
    {
        private DataTable songsTable;
        private SongBLL songBLL = new SongBLL();
        private PlaylistBLL playlistBLL = new PlaylistBLL();
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuManage_Click(object sender, EventArgs e)
        {

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadForm();
            
            // Display current user information
            if (UserBLL.CurrentUser.UserID != null)
            {
                lblUserInfo.Text = $"Welcome, {UserBLL.CurrentUser.FullName}";
                lblUserInfo.Visible = true;
                btnLogout.Visible = true;
                
                // Only show Email Settings to admin users
                emailSettingsToolStripMenuItem.Visible = UserBLL.CurrentUser.Role?.ToLower() == "admin";
            }
            else
            {
                lblUserInfo.Visible = false;
                btnLogout.Visible = false;
                emailSettingsToolStripMenuItem.Visible = false;
            }
        }
        private void LoadForm()
        {
            songsTable = songBLL.GetAllSongsWithFilePath();
            lstSongs.DataSource = songsTable;
            lstSongs.DisplayMember = "Title";
            lstSongs.ValueMember = "SongID";
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuSongs_Click(object sender, EventArgs e)
        {
            FormSongs form = new FormSongs();
            form.ShowDialog();
            LoadForm();
        }

        private void menuArtists_Click(object sender, EventArgs e)
        {
            FormArtists form = new FormArtists();
            form.ShowDialog();
            LoadForm();
        }

        private void menuAlbums_Click(object sender, EventArgs e)
        {
            FormAlbums form = new FormAlbums();
            form.ShowDialog();
            LoadForm();
        }

        private void menuGenre_Click(object sender, EventArgs e)
        {
            FormGenre form = new FormGenre();
            form.ShowDialog();
            LoadForm();
        }

        private void menuPlaylists_Click(object sender, EventArgs e)
        {
            FormPlaylists form = new FormPlaylists();
            form.ShowDialog();
            LoadForm();
        }

        private void menuStats_Click(object sender, EventArgs e)
        {
            FormStatistics form = new FormStatistics();
            form.ShowDialog();
            LoadForm();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lstSongs.SelectedItem is DataRowView selected)
            {
                DataRow row = selected.Row;
                string filePath = SongBLL.GetSongFilePath(row);
                string title = SongBLL.GetSongTitle(row);
                
                player.URL = filePath;
                player.Ctlcontrols.play();
                lblNowPlaying.Text = $"🎵 Now Playing: {title}";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            lblNowPlaying.Text = "⏹ Stopped";
        }
        
        private void menuFavorites_Click(object sender, EventArgs e)
        {
            // Check if user is logged in
            if (UserBLL.CurrentUser.UserID == null)
            {
                MessageBox.Show("You must be logged in to view favorite playlists.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            FormFavorites form = new FormFavorites();
            form.ShowDialog();
        }
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Stop music playback first
            player.Ctlcontrols.stop();
            lblNowPlaying.Text = "⏹ Stopped";

            // Logout current user
            new UserBLL().Logout();
            
            // Show login form
            FormLogin loginForm = new FormLogin();
            this.Hide();
            
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // If login successful, display user information again
                lblUserInfo.Text = $"Welcome, {UserBLL.CurrentUser.FullName}";
                lblUserInfo.Visible = true;
                btnLogout.Visible = true;
                this.Show();
            }
            else
            {
                // If login canceled, close application
                Application.Exit();
            }
        }

        // Email settings configuration - restrict to admin users
        private void emailSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if current user is admin
            UserBLL userBLL = new UserBLL();
            if (userBLL.IsAdmin())
            {
                FormSetupEmail form = new FormSetupEmail();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to access Email Settings.", 
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddToPlaylist_Click(object sender, EventArgs e)
        {
            // Check if a song is selected
            if (lstSongs.SelectedItem is DataRowView selectedView)
            {
                DataRow selected = selectedView.Row;
                int songId = SongBLL.GetSongId(selected);
                
                // Check if user is logged in
                if (UserBLL.CurrentUser.UserID == null)
                {
                    MessageBox.Show("You must be logged in to add songs to playlists.", 
                        "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                // Get all playlists
                DataTable playlists = playlistBLL.GetAll();
                
                // Create a playlist selection form
                using (var form = new Form())
                {
                    form.Text = "Add to Playlist";
                    form.Size = new Size(400, 300);
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.FormBorderStyle = FormBorderStyle.FixedDialog;
                    form.MaximizeBox = false;
                    form.MinimizeBox = false;
                    
                    // Create ListBox to display playlists
                    var listBox = new ListBox();
                    listBox.Dock = DockStyle.Top;
                    listBox.Height = 200;
                    listBox.DisplayMember = "Name";
                    listBox.ValueMember = "PlaylistID";
                    listBox.DataSource = playlists;
                    
                    // Create a "New Playlist" button
                    var btnNewPlaylist = new Button();
                    btnNewPlaylist.Text = "Create New Playlist";
                    btnNewPlaylist.Dock = DockStyle.Bottom;
                    btnNewPlaylist.Click += (s, args) => 
                    {
                        form.DialogResult = DialogResult.No; // Special result for new playlist
                        form.Close();
                    };
                    
                    // Create an "Add to Selected" button
                    var btnAddToSelected = new Button();
                    btnAddToSelected.Text = "Add to Selected Playlist";
                    btnAddToSelected.Dock = DockStyle.Bottom;
                    btnAddToSelected.Click += (s, args) => 
                    {
                        if (listBox.SelectedItem != null)
                        {
                            form.DialogResult = DialogResult.OK;
                            form.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please select a playlist.", "Selection Required", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    };
                    
                    // Add controls to form
                    form.Controls.Add(listBox);
                    form.Controls.Add(btnNewPlaylist);
                    form.Controls.Add(btnAddToSelected);
                    
                    // Show the form
                    var result = form.ShowDialog();
                    
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            // Add song to selected playlist
                            int playlistId = Convert.ToInt32((listBox.SelectedItem as DataRowView)["PlaylistID"]);
                            playlistBLL.AddSongToPlaylist(playlistId, songId);
                            MessageBox.Show("Song added to selected playlist successfully.", "Success", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        // Create new playlist
                        FormAddEditPlaylist formNewPlaylist = new FormAddEditPlaylist();
                        if (formNewPlaylist.ShowDialog() == DialogResult.OK)
                        {
                            // Get the newly created playlist ID
                            DataTable newPlaylists = playlistBLL.GetAll();
                            int newPlaylistId = Convert.ToInt32(newPlaylists.Rows[newPlaylists.Rows.Count - 1]["PlaylistID"]);
                            
                            try
                            {
                                // Add song to the new playlist
                                playlistBLL.AddSongToPlaylist(newPlaylistId, songId);
                                MessageBox.Show("Song added to new playlist successfully.", "Success", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a song first.", "Selection Required", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                // If search box is empty, show all songs
                LoadForm();
            }
            else
            {
                // Filter songs based on search text using DataTable
                string searchText = txtSearch.Text.ToLower();
                DataView dv = songsTable.DefaultView;
                dv.RowFilter = $"Title LIKE '%{searchText.Replace("'", "''")}%' OR " +
                              $"ArtistName LIKE '%{searchText.Replace("'", "''")}%' OR " +
                              $"AlbumTitle LIKE '%{searchText.Replace("'", "''")}%' OR " +
                              $"GenreName LIKE '%{searchText.Replace("'", "''")}%'";
                
                lstSongs.DataSource = dv;
                lstSongs.DisplayMember = "Title";
                lstSongs.ValueMember = "SongID";
            }
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSongs.SelectedItem is DataRowView selectedView)
            {
                DataRow selected = selectedView.Row;
                
                // Format duration as minutes:seconds
                string durationStr = "N/A";
                int duration = SongBLL.GetSongDuration(selected);
                if (duration > 0)
                {
                    int minutes = duration / 60;
                    int seconds = duration % 60;
                    durationStr = $"{minutes}:{seconds:D2}";
                }

                int rating = SongBLL.GetSongRating(selected);
                int year = SongBLL.GetSongYear(selected);

                // Display song information when a song is selected
                lblSongInfo.Text = $"Title: {SongBLL.GetSongTitle(selected)}\r\n" +
                                  $"Artist: {SongBLL.GetArtistName(selected) ?? "N/A"}\r\n" +
                                  $"Album: {SongBLL.GetAlbumTitle(selected) ?? "N/A"}\r\n" +
                                  $"Genre: {SongBLL.GetGenreName(selected) ?? "N/A"}\r\n" +
                                  $"Year: {(year > 0 ? year.ToString() : "N/A")}\r\n" +
                                  $"Rating: {(rating > 0 ? rating.ToString() + "/5" : "Not rated")}\r\n" +
                                  $"Duration: {durationStr}";
            }
        }
    }
}
