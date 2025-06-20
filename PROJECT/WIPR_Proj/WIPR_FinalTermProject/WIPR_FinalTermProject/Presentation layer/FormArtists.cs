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
    public partial class FormArtists : Form
    {
        private ArtistBLL artistBLL = new ArtistBLL();

        public FormArtists()
        {
            InitializeComponent();
        }

        private void FormArtists_Load(object sender, EventArgs e)
        {
            LoadArtists();
        }

        private void LoadArtists()
        {
            dgvArtists.DataSource = artistBLL.GetAll();

            if (dgvArtists.Columns.Contains("ArtistID"))
                dgvArtists.Columns["ArtistID"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvArtists.DataSource = artistBLL.Search(txtSearch.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditArtist addForm = new FormAddEditArtist();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadArtists();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvArtists.CurrentRow == null) return;

            DataRowView rowView = (DataRowView)dgvArtists.CurrentRow.DataBoundItem;
            DataRow artistRow = rowView.Row;

            FormAddEditArtist editForm = new FormAddEditArtist(artistRow);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadArtists();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvArtists.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvArtists.CurrentRow.Cells["ArtistID"].Value);

            DialogResult result = MessageBox.Show("Are you sure to delete this artist?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    artistBLL.Delete(id);
                    LoadArtists();
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
