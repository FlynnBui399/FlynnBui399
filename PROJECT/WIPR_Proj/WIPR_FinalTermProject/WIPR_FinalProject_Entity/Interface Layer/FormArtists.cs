using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIPR_FinalProject_Entity.BS_Layer;

namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormArtists : Form
    {
        private BL_Artist artistBLL = new BL_Artist();

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

            int id = Convert.ToInt32(dgvArtists.CurrentRow.Cells["ArtistID"].Value);

            FormAddEditArtist editForm = new FormAddEditArtist(new Artist
            {
                ArtistID = id,
                Name = dgvArtists.CurrentRow.Cells["Name"].Value.ToString(),
                Birthdate = Convert.ToDateTime(dgvArtists.CurrentRow.Cells["Birthdate"].Value),
                Nationality = dgvArtists.CurrentRow.Cells["Nationality"].Value.ToString()
            });

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadArtists();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvArtists.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvArtists.CurrentRow.Cells["ArtistID"].Value);

            DialogResult result = MessageBox.Show("Are you sure to delete this artist?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
