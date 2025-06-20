using System;
using System.Windows.Forms;
using WIPR_FinalProject_Entity.BS_Layer;

namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormAlbums : Form
    {
        private BL_Album albumBLL = new BL_Album();

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
            dgvAlbums.DataSource = albumBLL.GetAll();

            if (dgvAlbums.Columns.Contains("AlbumID"))
                dgvAlbums.Columns["AlbumID"].Visible = false;

            if (dgvAlbums.Columns.Contains("ArtistID"))
                dgvAlbums.Columns["ArtistID"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAlbums.DataSource = albumBLL.Search(txtSearch.Text.Trim());
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

            int id = Convert.ToInt32(dgvAlbums.CurrentRow.Cells["AlbumID"].Value);

            FormAddEditAlbum form = new FormAddEditAlbum(new Album
            {
                AlbumID = id,
                Title = dgvAlbums.CurrentRow.Cells["Title"].Value.ToString(),
                Year = Convert.ToInt32(dgvAlbums.CurrentRow.Cells["Year"].Value),
                ArtistID = Convert.ToInt32(dgvAlbums.CurrentRow.Cells["ArtistID"].Value)
            });

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
