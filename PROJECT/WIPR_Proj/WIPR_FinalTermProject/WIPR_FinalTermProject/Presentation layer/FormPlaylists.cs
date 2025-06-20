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
using WIPR_FinalTermProject.Classes;

namespace WIPR_FinalTermProject.Forms_layer
{
    public partial class FormPlaylists : Form
    {
        PlaylistBLL playlistBLL = new PlaylistBLL();

        public FormPlaylists()
        {
            InitializeComponent();
        }

        private void FormPlaylists_Load(object sender, EventArgs e)
        {
            // Setup Vietnamese font for DataGridView
            dgvPlaylists.SetupVietnameseFont(9.5f);
            
            LoadPlaylists();
        }

        private void LoadPlaylists()
        {
            try
            {
                dgvPlaylists.DataSource = playlistBLL.GetAll();
                
                if (dgvPlaylists.Columns.Contains("PlaylistID"))
                    dgvPlaylists.Columns["PlaylistID"].Visible = false;
                
                if (dgvPlaylists.Columns.Contains("TotalSongs"))
                {
                    dgvPlaylists.Columns["TotalSongs"].HeaderText = "Total Songs";
                    dgvPlaylists.Columns["TotalSongs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvPlaylists.Columns["TotalSongs"].Width = 100;
                }
                
                if (dgvPlaylists.Columns.Contains("CreatedDate"))
                {
                    dgvPlaylists.Columns["CreatedDate"].HeaderText = "Created Date";
                    dgvPlaylists.Columns["CreatedDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvPlaylists.Columns["CreatedDate"].Width = 120;
                }

                if (dgvPlaylists.Columns.Contains("CreatorName"))
                {
                    dgvPlaylists.Columns["CreatorName"].HeaderText = "Created By";
                    dgvPlaylists.Columns["CreatorName"].Width = 100;
                }
                
                if (dgvPlaylists.Columns.Contains("CreatorID"))
                    dgvPlaylists.Columns["CreatorID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPlaylists.DataSource = playlistBLL.Search(txtSearch.Text.Trim());
            
            if (dgvPlaylists.Columns.Contains("PlaylistID"))
                dgvPlaylists.Columns["PlaylistID"].Visible = false;
                
            if (dgvPlaylists.Columns.Contains("TotalSongs"))
            {
                dgvPlaylists.Columns["TotalSongs"].HeaderText = "Total Songs";
                dgvPlaylists.Columns["TotalSongs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPlaylists.Columns["TotalSongs"].Width = 100;
            }
            
            if (dgvPlaylists.Columns.Contains("CreatedDate"))
            {
                dgvPlaylists.Columns["CreatedDate"].HeaderText = "Created Date";
                dgvPlaylists.Columns["CreatedDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvPlaylists.Columns["CreatedDate"].Width = 120;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditPlaylist addForm = new FormAddEditPlaylist();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadPlaylists();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPlaylists.CurrentRow == null) return;
            
            int playlistId = Convert.ToInt32(dgvPlaylists.CurrentRow.Cells["PlaylistID"].Value);
            
            if (!playlistBLL.CanModifyPlaylist(playlistId, UserBLL.CurrentUser.UserID ?? 0))
            {
                MessageBox.Show("You don't have permission to edit this playlist", 
                    "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowView = (DataRowView)dgvPlaylists.CurrentRow.DataBoundItem;
            DataRow playlistRow = rowView.Row;

            FormAddEditPlaylist editForm = new FormAddEditPlaylist(playlistRow);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadPlaylists();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPlaylists.CurrentRow == null) return;
            
            int playlistId = Convert.ToInt32(dgvPlaylists.CurrentRow.Cells["PlaylistID"].Value);
            
            if (!playlistBLL.CanModifyPlaylist(playlistId, UserBLL.CurrentUser.UserID ?? 0))
            {
                MessageBox.Show("You don't have permission to delete this playlist", 
                    "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Delete this playlist?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    playlistBLL.Delete(playlistId);
                    LoadPlaylists();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnViewSongs_Click(object sender, EventArgs e)
        {
            if (dgvPlaylists.CurrentRow == null) return;

            int playlistId = Convert.ToInt32(dgvPlaylists.CurrentRow.Cells["PlaylistID"].Value);
            string playlistName = dgvPlaylists.CurrentRow.Cells["Name"].Value.ToString();

            FormPlaylistSongs form = new FormPlaylistSongs(playlistId, playlistName);
            form.ShowDialog();

            LoadPlaylists();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
