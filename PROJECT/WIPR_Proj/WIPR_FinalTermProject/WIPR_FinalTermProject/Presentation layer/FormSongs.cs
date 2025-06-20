using System;
using System.Data;
using System.Windows.Forms;
using WIPR_FinalTermProject.BS_layer;
using WIPR_FinalTermProject.Classes;

namespace WIPR_FinalTermProject.Forms_layer
{
    public partial class FormSongs : Form
    {
        private SongBLL songBLL = new SongBLL();

        public FormSongs()
        {
            InitializeComponent();
        }

        private void FormSongs_Load(object sender, EventArgs e)
        {
            // Setup Vietnamese font for DataGridView
            dgvSongs.SetupVietnameseFont(9.5f);
            
            LoadSongs();
        }

        private void LoadSongs()
        {
            dgvSongs.DataSource = songBLL.GetAll();

            if (dgvSongs.Columns.Contains("SongID"))
                dgvSongs.Columns["SongID"].Visible = false;
            if (dgvSongs.Columns.Contains("ArtistID"))
                dgvSongs.Columns["ArtistID"].Visible = false;
            if (dgvSongs.Columns.Contains("AlbumID"))
                dgvSongs.Columns["AlbumID"].Visible = false;
            if (dgvSongs.Columns.Contains("GenreID"))
                dgvSongs.Columns["GenreID"].Visible = false;
                
            if (dgvSongs.Columns.Contains("ArtistName"))
            {
                dgvSongs.Columns["ArtistName"].HeaderText = "Artist";
                dgvSongs.Columns["ArtistName"].DisplayIndex = 1;
            }
            if (dgvSongs.Columns.Contains("AlbumTitle"))
            {
                dgvSongs.Columns["AlbumTitle"].HeaderText = "Album";
                dgvSongs.Columns["AlbumTitle"].DisplayIndex = 2;
            }
            if (dgvSongs.Columns.Contains("GenreName"))
            {
                dgvSongs.Columns["GenreName"].HeaderText = "Genre";
                dgvSongs.Columns["GenreName"].DisplayIndex = 3;
            }
            
            if (dgvSongs.Columns.Contains("Duration"))
            {
                dgvSongs.Columns["Duration"].HeaderText = "Duration";
                dgvSongs.Columns["Duration"].DefaultCellStyle.Format = "0' min '0' sec'";
                
                dgvSongs.CellFormatting += DgvSongs_CellFormatting;
            }

        }
        
        private void DgvSongs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSongs.Columns[e.ColumnIndex].Name == "Duration" && e.Value != null)
            {
                int totalSeconds;
                
                if (int.TryParse(e.Value.ToString(), out totalSeconds))
                {
                    int minutes = totalSeconds / 60;
                    int seconds = totalSeconds % 60;
                    
                    e.Value = string.Format("{0}:{1:00}", minutes, seconds);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSongs.DataSource = songBLL.Search(txtSearch.Text.Trim());
            
            if (dgvSongs.Columns.Contains("SongID"))
                dgvSongs.Columns["SongID"].Visible = false;
            if (dgvSongs.Columns.Contains("ArtistID"))
                dgvSongs.Columns["ArtistID"].Visible = false;
            if (dgvSongs.Columns.Contains("AlbumID"))
                dgvSongs.Columns["AlbumID"].Visible = false;
            if (dgvSongs.Columns.Contains("GenreID"))
                dgvSongs.Columns["GenreID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditSong form = new FormAddEditSong();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSongs();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSongs.CurrentRow == null) return;

            DataRowView rowView = (DataRowView)dgvSongs.CurrentRow.DataBoundItem;
            DataRow songRow = rowView.Row;

            FormAddEditSong form = new FormAddEditSong(songRow);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSongs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSongs.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvSongs.CurrentRow.Cells["SongID"].Value);
            DialogResult result = MessageBox.Show("Are you sure to delete this song?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                songBLL.Delete(id);
                LoadSongs();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
