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
    public partial class FormAddEditPlaylist : Form
    {
        private DataRow playlistToEdit = null;
        private bool isEditMode => playlistToEdit != null;

        public FormAddEditPlaylist()
        {
            InitializeComponent();
        }

        public FormAddEditPlaylist(DataRow playlist) : this()
        {
            this.playlistToEdit = playlist;
        }

        private void FormAddEditPlaylist_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                label2.Text = "Edit Playlist";
                txtName.Text = PlaylistBLL.GetPlaylistName(playlistToEdit);
                txtDescription.Text = PlaylistBLL.GetPlaylistDescription(playlistToEdit);
            }
            else
            {
                label2.Text = "Add Playlist";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a playlist name.");
                return;
            }

            PlaylistBLL bll = new PlaylistBLL();

            if (isEditMode)
            {
                int playlistId = PlaylistBLL.GetPlaylistId(playlistToEdit);
                bll.Update(playlistId, txtName.Text.Trim(), txtDescription.Text.Trim());
            }
            else
            {
                bll.Insert(txtName.Text.Trim(), txtDescription.Text.Trim());
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
