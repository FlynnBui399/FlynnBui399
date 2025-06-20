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
    public partial class FormAddEditAlbum : Form
    {
        private Album albumToEdit = null;
        private bool isEditMode => albumToEdit != null;

        public FormAddEditAlbum()
        {
            InitializeComponent();
        }

        public FormAddEditAlbum(Album album) : this()
        {
            this.albumToEdit = album;
        }

        private void FormAddEditAlbum_Load(object sender, EventArgs e)
        {
            LoadArtists();

            if (isEditMode)
            {
                label2.Text = "Edit Album";
                txtTitle.Text = albumToEdit.Title;
                nudYear.Value = (decimal)albumToEdit.Year;
                cbArtist.SelectedValue = albumToEdit.ArtistID;
            }
            else
            {
                label2.Text = "Add Album";
                nudYear.Value = DateTime.Now.Year;
            }
        }
        private void LoadArtists()
        {
            BL_Artist bll = new BL_Artist();
            cbArtist.DataSource = bll.GetAll();
            cbArtist.DisplayMember = "Name";
            cbArtist.ValueMember = "ArtistID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter the album title.");
                return;
            }

            BL_Album bll = new BL_Album();

            if (isEditMode)
            {
                bll.Update(albumToEdit.AlbumID, txtTitle.Text.Trim(), (int)nudYear.Value, (int)cbArtist.SelectedValue);
            }
            else
            {
                bll.Insert(txtTitle.Text.Trim(), (int)nudYear.Value, (int)cbArtist.SelectedValue);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
