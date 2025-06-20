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
using WIPR_FinalProject_Entity.BS_Layer;


namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormAddEditGenre : Form
    {
        private Genre genreToEdit = null;
        private bool isEditMode => genreToEdit != null;

        public FormAddEditGenre()
        {
            InitializeComponent();
        }

        public FormAddEditGenre(Genre genre) : this()
        {
            this.genreToEdit = genre;
        }

        private void FormAddEditGenre_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                label2.Text = "Edit Genre";
                txtName.Text = genreToEdit.Name;
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

            BL_Genre bll = new BL_Genre();

            if (isEditMode)
            {
                bll.Update(genreToEdit.GenreID, txtName.Text.Trim());
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