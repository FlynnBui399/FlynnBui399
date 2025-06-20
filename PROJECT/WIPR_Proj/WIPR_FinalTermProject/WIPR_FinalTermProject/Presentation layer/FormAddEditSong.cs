using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIPR_FinalTermProject.DB_layer;
using WIPR_FinalTermProject.BS_layer;

namespace WIPR_FinalTermProject.Forms_layer
{
    public partial class FormAddEditSong : Form
    {
        private DataRow songToEdit = null;
        private bool isEditMode => songToEdit != null;

        public FormAddEditSong()
        {
            InitializeComponent();
        }

        public FormAddEditSong(DataRow song) : this()
        {
            this.songToEdit = song;
        }

        private void FormAddEditSong_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();

            cbRating.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });

            if (isEditMode)
            {
                label2.Text = "Edit Song";

                txtTitle.Text = SongBLL.GetSongTitle(songToEdit);
                nudDuration.Value = SongBLL.GetSongDuration(songToEdit);
                nudYear.Value = SongBLL.GetSongYear(songToEdit);
                cbRating.SelectedItem = SongBLL.GetSongRating(songToEdit);

                cbArtist.SelectedValue = songToEdit["ArtistID"];
                cbAlbum.SelectedValue = songToEdit["AlbumID"];
                cbGenre.SelectedValue = songToEdit["GenreID"];
                txtFilePath.Text = SongBLL.GetSongFilePath(songToEdit);

            }
            else
            {
                label2.Text = "Add Song";
                cbRating.SelectedIndex = 0;
            }
        }

        private void LoadComboBoxes()
        {
            cbArtist.DataSource = new ArtistBLL().GetAll();
            cbArtist.DisplayMember = "Name";
            cbArtist.ValueMember = "ArtistID";

            cbAlbum.DataSource = new AlbumBLL().GetAll();
            cbAlbum.DisplayMember = "Title";
            cbAlbum.ValueMember = "AlbumID";

            cbGenre.DataSource = new GenreBLL().GetAll();
            cbGenre.DisplayMember = "Name";
            cbGenre.ValueMember = "GenreID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            SongBLL bll = new SongBLL();

            if (isEditMode)
            {
                int songId = SongBLL.GetSongId(songToEdit);
                bll.Update(songId, txtTitle.Text.Trim(), (int)nudDuration.Value, (int)nudYear.Value, int.Parse(cbRating.SelectedItem.ToString()),
                    (int)cbArtist.SelectedValue, (int)cbAlbum.SelectedValue, (int)cbGenre.SelectedValue, txtFilePath.Text.Trim());
            }
            else
            {
                bll.Insert(txtTitle.Text.Trim(), (int)nudDuration.Value, (int)nudYear.Value, int.Parse(cbRating.SelectedItem.ToString()),
                    (int)cbArtist.SelectedValue, (int)cbAlbum.SelectedValue, (int)cbGenre.SelectedValue, txtFilePath.Text.Trim());
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files|*.mp3;*.wav";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }
    }
}
