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
    public partial class FormAddEditAlbum : Form
    {
        private DataRow albumToEdit = null;
        private bool isEditMode => albumToEdit != null;

        public FormAddEditAlbum()
        {
            InitializeComponent();
        }

        public FormAddEditAlbum(DataRow album) : this()
        {
            this.albumToEdit = album;
        }

        private void FormAddEditAlbum_Load(object sender, EventArgs e)
        {
            LoadArtists();

            if (isEditMode)
            {
                label2.Text = "Edit Album";
                txtTitle.Text = AlbumBLL.GetAlbumTitle(albumToEdit);
                nudYear.Value = AlbumBLL.GetAlbumYear(albumToEdit);
                cbArtist.SelectedValue = AlbumBLL.GetAlbumArtistId(albumToEdit);
            }
            else
            {
                label2.Text = "Add Album";
                nudYear.Value = DateTime.Now.Year;
            }
        }
        private void LoadArtists()
        {
            ArtistBLL bll = new ArtistBLL();
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

            AlbumBLL bll = new AlbumBLL();

            if (isEditMode)
            {
                int albumId = AlbumBLL.GetAlbumId(albumToEdit);
                bll.Update(albumId, txtTitle.Text.Trim(), (int)nudYear.Value, (int)cbArtist.SelectedValue);
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
