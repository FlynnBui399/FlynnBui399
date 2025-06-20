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
    public partial class FormAddEditSong : Form
    {
        private Song songToEdit = null;
        private bool isEditMode => songToEdit != null;

        public FormAddEditSong()
        {
            InitializeComponent();
        }

        public FormAddEditSong(Song song) : this()
        {
            this.songToEdit = song;
        }

        private void FormAddEditSong_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();

            cbRating.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });

            if (isEditMode)
            {
                label2.Text = "Edit Song";

                txtTitle.Text = songToEdit.Title;
                nudDuration.Value = (decimal)songToEdit.Duration;
                nudYear.Value = (decimal)songToEdit.Year;
                cbRating.SelectedItem = songToEdit.Rating.ToString();

                cbArtist.SelectedValue = songToEdit.ArtistID;
                cbAlbum.SelectedValue = songToEdit.AlbumID;
                cbGenre.SelectedValue = songToEdit.GenreID;
                txtFilePath.Text = songToEdit.FilePath;

            }
            else
            {
                label2.Text = "Add Song";
                cbRating.SelectedIndex = 0;
            }
        }

        private void LoadComboBoxes()
        {
            cbArtist.DataSource = new BL_Artist().GetAll();
            cbArtist.DisplayMember = "Name";
            cbArtist.ValueMember = "ArtistID";

            cbAlbum.DataSource = new BL_Album().GetAll();
            cbAlbum.DisplayMember = "Title";
            cbAlbum.ValueMember = "AlbumID";

            cbGenre.DataSource = new BL_Genre().GetAll();
            cbGenre.DisplayMember = "Name";
            cbGenre.ValueMember = "GenreID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Title
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Please enter a title for the song.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitle.Focus();
                    return;
                }

                // Validate Duration
                if (nudDuration.Value <= 0)
                {
                    MessageBox.Show("Duration must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudDuration.Focus();
                    return;
                }

                // Validate Year
                if (nudYear.Value <= 0 || nudYear.Value > DateTime.Now.Year)
                {
                    MessageBox.Show($"Year must be between 1 and {DateTime.Now.Year}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudYear.Focus();
                    return;
                }

                // Validate Rating
                if (cbRating.SelectedItem == null)
                {
                    MessageBox.Show("Please select a rating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbRating.Focus();
                    return;
                }

                // Validate Artist
                if (cbArtist.SelectedValue == null)
                {
                    MessageBox.Show("Please select an artist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbArtist.Focus();
                    return;
                }

                // Validate Album
                if (cbAlbum.SelectedValue == null)
                {
                    MessageBox.Show("Please select an album.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbAlbum.Focus();
                    return;
                }

                // Validate Genre
                if (cbGenre.SelectedValue == null)
                {
                    MessageBox.Show("Please select a genre.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbGenre.Focus();
                    return;
                }

                BL_Song bll = new BL_Song();
                
                try
                {
                    int rating = int.Parse(cbRating.SelectedItem.ToString());

                    // Check Artist
                    if (!(cbArtist.SelectedValue is int artistId))
                    {
                        MessageBox.Show("Invalid selection for Artist. Please select a valid artist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbArtist.Focus();
                        return;
                    }
                    // Check Album
                    if (!(cbAlbum.SelectedValue is int albumId))
                    {
                        MessageBox.Show("Invalid selection for Album. Please select a valid album.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbAlbum.Focus();
                        return;
                    }
                    // Check Genre
                    if (!(cbGenre.SelectedValue is int genreId))
                    {
                        MessageBox.Show("Invalid selection for Genre. Please select a valid genre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbGenre.Focus();
                        return;
                    }
                    
                    if (isEditMode)
                    {
                        bll.Update(songToEdit.SongID, txtTitle.Text.Trim(), (int)nudDuration.Value, (int)nudYear.Value, rating,
                            artistId, albumId, genreId, txtFilePath.Text.Trim());
                    }
                    else
                    {
                        bll.Insert(txtTitle.Text.Trim(), (int)nudDuration.Value, (int)nudYear.Value, rating,
                            artistId, albumId, genreId, txtFilePath.Text.Trim());
                    }
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid rating value. Please select a valid rating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbRating.Focus();
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Invalid selection in one of the dropdown fields. Please make sure all selections are valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving song: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
