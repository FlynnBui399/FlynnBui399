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
using WIPR_FinalTermProject.BS_layer;
using WIPR_FinalTermProject.DB_layer;

namespace WIPR_FinalTermProject.Forms_layer
{
    public partial class FormAddEditArtist : Form
    {
        private DataRow artistToEdit = null;
        private bool isEditMode => artistToEdit != null;

        public FormAddEditArtist()
        {
            InitializeComponent();
        }

        public FormAddEditArtist(DataRow artist) : this()
        {
            this.artistToEdit = artist;
        }

        private void FormAddEditArtist_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                label2.Text = "Edit Artist";
                txtName.Text = ArtistBLL.GetArtistName(artistToEdit);
                DateTime? birthdate = ArtistBLL.GetArtistBirthdate(artistToEdit);
                dtpBirthdate.Value = birthdate ?? DateTime.Today.AddYears(-20);
                txtNationality.Text = ArtistBLL.GetArtistNationality(artistToEdit);
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
                MessageBox.Show("Please fill all fields");
                return;
            }

            ArtistBLL bll = new ArtistBLL();

            if (isEditMode)
            {
                int artistId = ArtistBLL.GetArtistId(artistToEdit);
                bll.Update(artistId, txtName.Text.Trim(), dtpBirthdate.Value, txtNationality.Text.Trim());
            }
            else
            {
                bll.Insert(txtName.Text.Trim(), dtpBirthdate.Value, txtNationality.Text.Trim());
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
            Application.Exit();
        }
    }
}
