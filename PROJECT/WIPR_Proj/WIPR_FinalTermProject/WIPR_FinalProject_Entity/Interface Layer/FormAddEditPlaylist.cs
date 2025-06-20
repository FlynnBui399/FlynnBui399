using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIPR_FinalProject_Entity;
using WIPR_FinalProject_Entity.BS_Layer;

namespace WIPR_FinalProject_Entity.Interface_Layer
{
    public partial class FormAddEditPlaylist : Form
    {
        private Playlist playlistToEdit = null;
        private bool isEditMode => playlistToEdit != null;

        public FormAddEditPlaylist()
        {
            InitializeComponent();
        }

        public FormAddEditPlaylist(Playlist playlist) : this()
        {
            this.playlistToEdit = playlist;
        }

        private void FormAddEditPlaylist_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                label2.Text = "Edit Playlist";
                txtName.Text = playlistToEdit.Name;
                txtDescription.Text = playlistToEdit.Description;
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

            BL_Playlist bll = new BL_Playlist();

            if (isEditMode)
            {
                bll.Update(playlistToEdit.PlaylistID, txtName.Text.Trim(), txtDescription.Text.Trim());
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
