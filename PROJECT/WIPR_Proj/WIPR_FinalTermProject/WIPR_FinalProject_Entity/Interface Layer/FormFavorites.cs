using System;
using System.Windows.Forms;
using WIPR_FinalProject_Entity.BS_Layer;
using WIPR_FinalProject_Entity.Classes;

namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormFavorites : Form
    {
        private BL_FavPlaylist favoritePlaylistBLL = new BL_FavPlaylist();
        private BL_Playlist playlistBLL = new BL_Playlist();

        public FormFavorites()
        {
            InitializeComponent();
        }

        private void FormFavorites_Load(object sender, EventArgs e)
        {
            // Setup Vietnamese font for DataGridView
            dgvFavorites.SetupVietnameseFont(9.5f);

            LoadFavoritePlaylists();
            LoadAvailablePlaylists();
        }

        private void LoadFavoritePlaylists()
        {
            // Check if user is logged in
            if (BL_Users.CurrentUser == null)
            {
                MessageBox.Show("You must be logged in to view favorite playlists", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            dgvFavorites.DataSource = favoritePlaylistBLL.GetByUserId(BL_Users.CurrentUser.UserID);

            if (dgvFavorites.Columns.Contains("FavoriteID"))
                dgvFavorites.Columns["FavoriteID"].Visible = false;
            if (dgvFavorites.Columns.Contains("UserID"))
                dgvFavorites.Columns["UserID"].Visible = false;
            if (dgvFavorites.Columns.Contains("PlaylistID"))
                dgvFavorites.Columns["PlaylistID"].Visible = false;
            if (dgvFavorites.Columns.Contains("UserName"))
                dgvFavorites.Columns["UserName"].Visible = false;

            if (dgvFavorites.Columns.Contains("PlaylistName"))
            {
                dgvFavorites.Columns["PlaylistName"].HeaderText = "Playlist";
                dgvFavorites.Columns["PlaylistName"].Width = 200;
            }
            if (dgvFavorites.Columns.Contains("PlaylistDescription"))
            {
                dgvFavorites.Columns["PlaylistDescription"].HeaderText = "Description";
                dgvFavorites.Columns["PlaylistDescription"].Width = 200;
            }
            if (dgvFavorites.Columns.Contains("CreatorName"))
            {
                dgvFavorites.Columns["CreatorName"].HeaderText = "Creator";
                dgvFavorites.Columns["CreatorName"].Width = 120;
            }
            if (dgvFavorites.Columns.Contains("DateAdded"))
            {
                dgvFavorites.Columns["DateAdded"].HeaderText = "Date Added";
                dgvFavorites.Columns["DateAdded"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            if (dgvFavorites.Columns.Contains("TotalSongs"))
            {
                dgvFavorites.Columns["TotalSongs"].HeaderText = "Songs";
                dgvFavorites.Columns["TotalSongs"].Width = 60;
            }
            if (dgvFavorites.Columns.Contains("AvgRating"))
            {
                dgvFavorites.Columns["AvgRating"].HeaderText = "Rating";
                dgvFavorites.Columns["AvgRating"].DefaultCellStyle.Format = "N1";
                dgvFavorites.Columns["AvgRating"].Width = 60;
            }

            dgvFavorites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAvailablePlaylists()
        {
            cboPlaylists.DataSource = playlistBLL.GetAll();
            cboPlaylists.DisplayMember = "Name";
            cboPlaylists.ValueMember = "PlaylistID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboPlaylists.SelectedValue == null) return;

            int playlistId = Convert.ToInt32(cboPlaylists.SelectedValue);

            if (favoritePlaylistBLL.Add(BL_Users.CurrentUser.UserID, playlistId))
            {
                LoadFavoritePlaylists();
                MessageBox.Show("Playlist added to favorites", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This playlist is already in your favorites", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvFavorites.CurrentRow == null) return;

            int favoriteId = Convert.ToInt32(dgvFavorites.CurrentRow.Cells["FavoriteID"].Value);
            string playlistName = dgvFavorites.CurrentRow.Cells["PlaylistName"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to remove '{playlistName}' from favorites?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (favoritePlaylistBLL.Remove(favoriteId))
                {
                    LoadFavoritePlaylists();
                    MessageBox.Show("Playlist removed from favorites.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while removing the playlist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvFavorites.CurrentRow == null) return;

            int playlistId = Convert.ToInt32(dgvFavorites.CurrentRow.Cells["PlaylistID"].Value);
            string playlistName = dgvFavorites.CurrentRow.Cells["PlaylistName"].Value.ToString();

            FormPlaylistSongs form = new FormPlaylistSongs(playlistId, playlistName);
            form.ShowDialog();
            LoadFavoritePlaylists();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}