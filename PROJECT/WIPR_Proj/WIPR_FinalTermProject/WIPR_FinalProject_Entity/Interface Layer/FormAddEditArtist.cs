using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WIPR_FinalProject_Entity.BS_Layer;

namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormAddEditArtist : Form
    {
        private Artist artistToEdit = null;
        private bool isEditMode => artistToEdit != null;

        public FormAddEditArtist()
        {
            InitializeComponent();
        }

        public FormAddEditArtist(Artist artist) : this()
        {
            this.artistToEdit = artist;
        }

        private void FormAddEditArtist_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                label2.Text = "Edit Artist";
                txtName.Text = artistToEdit.Name;
                dtpBirthdate.Value = artistToEdit.Birthdate ?? DateTime.Today.AddYears(-20);
                txtNationality.Text = artistToEdit.Nationality;
            }
            else
            {
                label2.Text = "Add Artist";
                dtpBirthdate.Value = DateTime.Today.AddYears(-20); // default
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtNationality.Text))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BL_Artist bll = new BL_Artist();
            string err = string.Empty;

            try
            {
                if (isEditMode)
                {
                    bll.Update(artistToEdit.ArtistID, txtName.Text.Trim(), dtpBirthdate.Value, txtNationality.Text.Trim());
                }
                else
                {
                    bll.Insert(txtName.Text.Trim(), dtpBirthdate.Value, txtNationality.Text.Trim());
                }

                if (!string.IsNullOrEmpty(err))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
