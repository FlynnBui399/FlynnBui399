using System;
using System.Data;
using System.Windows.Forms;
using WIPR_FinalTermProject.BS_layer;
using WIPR_FinalTermProject.Classes;

namespace WIPR_FinalTermProject.Forms_layer
{
    public partial class FormAlbums : Form
    {
        private AlbumBLL albumBLL = new AlbumBLL();
        private DataTable originalData;

        public FormAlbums()
        {
            InitializeComponent();
        }

        private void FormAlbums_Load(object sender, EventArgs e)
        {
            LoadAlbums();

        }

        private void LoadAlbums()
        {
            originalData = albumBLL.GetAll();
            dgvAlbums.DataSource = originalData;

            if (dgvAlbums.Columns.Contains("AlbumID"))
                dgvAlbums.Columns["AlbumID"].Visible = false;
            if (dgvAlbums.Columns.Contains("ArtistID"))
                dgvAlbums.Columns["ArtistID"].Visible = false;

            // Format columns
            if (dgvAlbums.Columns.Contains("Title"))
            {
                dgvAlbums.Columns["Title"].HeaderText = "Album Title";
                dgvAlbums.Columns["Title"].Width = 200;
            }

            if (dgvAlbums.Columns.Contains("ArtistName"))
            {
                dgvAlbums.Columns["ArtistName"].HeaderText = "Artist";
                dgvAlbums.Columns["ArtistName"].Width = 150;
            }

            if (dgvAlbums.Columns.Contains("Year"))
            {
                dgvAlbums.Columns["Year"].Width = 80;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAlbums.DataSource = albumBLL.Search(txtSearch.Text.Trim());
            
            if (dgvAlbums.Columns.Contains("AlbumID"))
                dgvAlbums.Columns["AlbumID"].Visible = false;

            if (dgvAlbums.Columns.Contains("ArtistID"))
                dgvAlbums.Columns["ArtistID"].Visible = false;
                
            if (dgvAlbums.Columns.Contains("ArtistName"))
            {
                dgvAlbums.Columns["ArtistName"].HeaderText = "Artist";
                dgvAlbums.Columns["ArtistName"].DisplayIndex = 1;
                dgvAlbums.Columns["ArtistName"].Width = 150;
            }
            
            if (dgvAlbums.Columns.Contains("TotalSongs"))
            {
                dgvAlbums.Columns["TotalSongs"].HeaderText = "Total Songs";
                dgvAlbums.Columns["TotalSongs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAlbums.Columns["TotalSongs"].Width = 100;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditAlbum form = new FormAddEditAlbum();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadAlbums();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAlbums.CurrentRow == null) return;

            DataRowView rowView = (DataRowView)dgvAlbums.CurrentRow.DataBoundItem;
            DataRow albumRow = rowView.Row;

            FormAddEditAlbum form = new FormAddEditAlbum(albumRow);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadAlbums();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAlbums.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvAlbums.CurrentRow.Cells["AlbumID"].Value);
            DialogResult result = MessageBox.Show("Are you sure to delete this album?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    albumBLL.Delete(id);
                    LoadAlbums();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
