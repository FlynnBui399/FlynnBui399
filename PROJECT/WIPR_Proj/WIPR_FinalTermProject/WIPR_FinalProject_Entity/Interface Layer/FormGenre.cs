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
    public partial class FormGenre : Form
    {
        private BL_Genre genreBLL = new BL_Genre();

        public FormGenre()
        {
            InitializeComponent();
        }

        private void FormGenre_Load(object sender, EventArgs e)
        {
            LoadGenres();
        }

        private void FormatDataGridView()
        {
            if (dgvGenres.Columns.Contains("GenreID"))
                dgvGenres.Columns["GenreID"].Visible = false;

            // Format columns
            if (dgvGenres.Columns.Contains("Name"))
            {
                dgvGenres.Columns["Name"].HeaderText = "Genre Name";
                dgvGenres.Columns["Name"].Width = 200;
            }

            if (dgvGenres.Columns.Contains("TotalSongs"))
            {
                dgvGenres.Columns["TotalSongs"].HeaderText = "Total Songs";
                dgvGenres.Columns["TotalSongs"].Width = 100;
                dgvGenres.Columns["TotalSongs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void LoadGenres()
        {
            dgvGenres.DataSource = genreBLL.GetAllWithTotalSongs();
            FormatDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvGenres.DataSource = genreBLL.Search(txtSearch.Text.Trim());
            FormatDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditGenre addForm = new FormAddEditGenre();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadGenres();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGenres.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvGenres.CurrentRow.Cells["GenreID"].Value);

            FormAddEditGenre editForm = new FormAddEditGenre(new Genre
            {
                GenreID = id,
                Name = dgvGenres.CurrentRow.Cells["Name"].Value.ToString()
            });

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadGenres();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGenres.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvGenres.CurrentRow.Cells["GenreID"].Value);

            DialogResult result = MessageBox.Show("Are you sure to delete this genre?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    genreBLL.Delete(id);
                    LoadGenres();
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