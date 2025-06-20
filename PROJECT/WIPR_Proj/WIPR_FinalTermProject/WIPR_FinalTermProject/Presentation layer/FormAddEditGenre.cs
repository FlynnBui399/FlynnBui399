using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WIPR_FinalTermProject.BS_layer;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.Forms_layer
{
    public partial class FormAddEditGenre : Form
    {
        private DataRow genreToEdit = null;
        private bool isEditMode => genreToEdit != null;

        public FormAddEditGenre()
        {
            InitializeComponent();
        }

        public FormAddEditGenre(DataRow genre) : this()
        {
            this.genreToEdit = genre;
        }

        private void FormAddEditGenre_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                label2.Text = "Edit Genre";
                txtName.Text = GenreBLL.GetGenreName(genreToEdit);
            }
            else
            {
                label2.Text = "Add Genre";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please fill in the genre name.");
                return;
            }

            GenreBLL bll = new GenreBLL();

            if (isEditMode)
            {
                int genreId = GenreBLL.GetGenreId(genreToEdit);
                bll.Update(genreId, txtName.Text.Trim());
            }
            else
            {
                bll.Insert(txtName.Text.Trim());
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}