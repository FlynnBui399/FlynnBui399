namespace WIPR_FinalTermProject.Forms_layer
{
    partial class FormStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabArtists = new System.Windows.Forms.TabPage();
            this.dgvStatsArtists = new System.Windows.Forms.DataGridView();
            this.tabGenres = new System.Windows.Forms.TabPage();
            this.dgvStatsGenres = new System.Windows.Forms.DataGridView();
            this.tabPlaylists = new System.Windows.Forms.TabPage();
            this.dgvStatsPlaylists = new System.Windows.Forms.DataGridView();
            this.tabAlbums = new System.Windows.Forms.TabPage();
            this.dgvStatsAlbums = new System.Windows.Forms.DataGridView();
            this.tpArtists = new System.Windows.Forms.TabPage();
            this.reportViewerArtist = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpGenres = new System.Windows.Forms.TabPage();
            this.reportViewerGenre = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpPlaylists = new System.Windows.Forms.TabPage();
            this.reportViewerPlaylist = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpAlbums = new System.Windows.Forms.TabPage();
            this.reportViewerAlbum = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabArtists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsArtists)).BeginInit();
            this.tabGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsGenres)).BeginInit();
            this.tabPlaylists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsPlaylists)).BeginInit();
            this.tabAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsAlbums)).BeginInit();
            this.tpArtists.SuspendLayout();
            this.tpGenres.SuspendLayout();
            this.tpPlaylists.SuspendLayout();
            this.tpAlbums.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(918, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 46);
            this.label3.TabIndex = 34;
            this.label3.Text = "Bui Tran Tan Phat - 23110052\r\nNguyen Nhat Phat - 23110053\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "TEAM 03";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "STATISTICS PAGE";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabArtists);
            this.tabControl.Controls.Add(this.tabGenres);
            this.tabControl.Controls.Add(this.tabPlaylists);
            this.tabControl.Controls.Add(this.tabAlbums);
            this.tabControl.Controls.Add(this.tpArtists);
            this.tabControl.Controls.Add(this.tpGenres);
            this.tabControl.Controls.Add(this.tpPlaylists);
            this.tabControl.Controls.Add(this.tpAlbums);
            this.tabControl.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(16, 48);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(932, 417);
            this.tabControl.TabIndex = 36;
            // 
            // tabArtists
            // 
            this.tabArtists.BackColor = System.Drawing.Color.LightCyan;
            this.tabArtists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabArtists.Controls.Add(this.dgvStatsArtists);
            this.tabArtists.Location = new System.Drawing.Point(4, 40);
            this.tabArtists.Name = "tabArtists";
            this.tabArtists.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtists.Size = new System.Drawing.Size(924, 373);
            this.tabArtists.TabIndex = 0;
            this.tabArtists.Text = "Artists";
            // 
            // dgvStatsArtists
            // 
            this.dgvStatsArtists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatsArtists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStatsArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsArtists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatsArtists.Location = new System.Drawing.Point(3, 3);
            this.dgvStatsArtists.Name = "dgvStatsArtists";
            this.dgvStatsArtists.RowHeadersWidth = 51;
            this.dgvStatsArtists.RowTemplate.Height = 24;
            this.dgvStatsArtists.Size = new System.Drawing.Size(916, 365);
            this.dgvStatsArtists.TabIndex = 1;
            // 
            // tabGenres
            // 
            this.tabGenres.BackColor = System.Drawing.Color.LightCyan;
            this.tabGenres.Controls.Add(this.dgvStatsGenres);
            this.tabGenres.Location = new System.Drawing.Point(4, 40);
            this.tabGenres.Name = "tabGenres";
            this.tabGenres.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenres.Size = new System.Drawing.Size(924, 373);
            this.tabGenres.TabIndex = 1;
            this.tabGenres.Text = "Genres";
            // 
            // dgvStatsGenres
            // 
            this.dgvStatsGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatsGenres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStatsGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatsGenres.Location = new System.Drawing.Point(3, 3);
            this.dgvStatsGenres.Name = "dgvStatsGenres";
            this.dgvStatsGenres.RowHeadersWidth = 51;
            this.dgvStatsGenres.RowTemplate.Height = 24;
            this.dgvStatsGenres.Size = new System.Drawing.Size(918, 367);
            this.dgvStatsGenres.TabIndex = 2;
            // 
            // tabPlaylists
            // 
            this.tabPlaylists.BackColor = System.Drawing.Color.LightCyan;
            this.tabPlaylists.Controls.Add(this.dgvStatsPlaylists);
            this.tabPlaylists.Location = new System.Drawing.Point(4, 40);
            this.tabPlaylists.Name = "tabPlaylists";
            this.tabPlaylists.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlaylists.Size = new System.Drawing.Size(924, 373);
            this.tabPlaylists.TabIndex = 2;
            this.tabPlaylists.Text = "Playlists";
            // 
            // dgvStatsPlaylists
            // 
            this.dgvStatsPlaylists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatsPlaylists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStatsPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsPlaylists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatsPlaylists.Location = new System.Drawing.Point(3, 3);
            this.dgvStatsPlaylists.Name = "dgvStatsPlaylists";
            this.dgvStatsPlaylists.RowHeadersWidth = 51;
            this.dgvStatsPlaylists.RowTemplate.Height = 24;
            this.dgvStatsPlaylists.Size = new System.Drawing.Size(918, 367);
            this.dgvStatsPlaylists.TabIndex = 2;
            // 
            // tabAlbums
            // 
            this.tabAlbums.BackColor = System.Drawing.Color.LightCyan;
            this.tabAlbums.Controls.Add(this.dgvStatsAlbums);
            this.tabAlbums.Location = new System.Drawing.Point(4, 40);
            this.tabAlbums.Name = "tabAlbums";
            this.tabAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlbums.Size = new System.Drawing.Size(924, 373);
            this.tabAlbums.TabIndex = 3;
            this.tabAlbums.Text = "Albums";
            // 
            // dgvStatsAlbums
            // 
            this.dgvStatsAlbums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatsAlbums.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStatsAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatsAlbums.Location = new System.Drawing.Point(3, 3);
            this.dgvStatsAlbums.Name = "dgvStatsAlbums";
            this.dgvStatsAlbums.RowHeadersWidth = 51;
            this.dgvStatsAlbums.RowTemplate.Height = 24;
            this.dgvStatsAlbums.Size = new System.Drawing.Size(918, 367);
            this.dgvStatsAlbums.TabIndex = 2;
            // 
            // tpArtists
            // 
            this.tpArtists.Controls.Add(this.reportViewerArtist);
            this.tpArtists.Location = new System.Drawing.Point(4, 40);
            this.tpArtists.Name = "tpArtists";
            this.tpArtists.Padding = new System.Windows.Forms.Padding(3);
            this.tpArtists.Size = new System.Drawing.Size(924, 373);
            this.tpArtists.TabIndex = 3;
            this.tpArtists.Text = "Report by Artist";
            this.tpArtists.UseVisualStyleBackColor = true;
            // 
            // reportViewerArtist
            // 
            this.reportViewerArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerArtist.Location = new System.Drawing.Point(3, 3);
            this.reportViewerArtist.Name = "reportViewerArtist";
            this.reportViewerArtist.ServerReport.BearerToken = null;
            this.reportViewerArtist.Size = new System.Drawing.Size(918, 367);
            this.reportViewerArtist.TabIndex = 0;
            // 
            // tpGenres
            // 
            this.tpGenres.Controls.Add(this.reportViewerGenre);
            this.tpGenres.Location = new System.Drawing.Point(4, 40);
            this.tpGenres.Name = "tpGenres";
            this.tpGenres.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenres.Size = new System.Drawing.Size(924, 373);
            this.tpGenres.TabIndex = 4;
            this.tpGenres.Text = "Report By Genre";
            this.tpGenres.UseVisualStyleBackColor = true;
            // 
            // reportViewerGenre
            // 
            this.reportViewerGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerGenre.Location = new System.Drawing.Point(3, 3);
            this.reportViewerGenre.Name = "reportViewerGenre";
            this.reportViewerGenre.ServerReport.BearerToken = null;
            this.reportViewerGenre.Size = new System.Drawing.Size(918, 367);
            this.reportViewerGenre.TabIndex = 1;
            // 
            // tpPlaylists
            // 
            this.tpPlaylists.Controls.Add(this.reportViewerPlaylist);
            this.tpPlaylists.Location = new System.Drawing.Point(4, 40);
            this.tpPlaylists.Name = "tpPlaylists";
            this.tpPlaylists.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlaylists.Size = new System.Drawing.Size(924, 373);
            this.tpPlaylists.TabIndex = 5;
            this.tpPlaylists.Text = "Report by Playlist";
            this.tpPlaylists.UseVisualStyleBackColor = true;
            // 
            // reportViewerPlaylist
            // 
            this.reportViewerPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPlaylist.Location = new System.Drawing.Point(3, 3);
            this.reportViewerPlaylist.Name = "reportViewerPlaylist";
            this.reportViewerPlaylist.ServerReport.BearerToken = null;
            this.reportViewerPlaylist.Size = new System.Drawing.Size(918, 367);
            this.reportViewerPlaylist.TabIndex = 1;
            // 
            // tpAlbums
            // 
            this.tpAlbums.Controls.Add(this.reportViewerAlbum);
            this.tpAlbums.Location = new System.Drawing.Point(4, 40);
            this.tpAlbums.Name = "tpAlbums";
            this.tpAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlbums.Size = new System.Drawing.Size(924, 373);
            this.tpAlbums.TabIndex = 6;
            this.tpAlbums.Text = "Report by Album";
            this.tpAlbums.UseVisualStyleBackColor = true;
            // 
            // reportViewerAlbum
            // 
            this.reportViewerAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerAlbum.LocalReport.ReportEmbeddedResource = "";
            this.reportViewerAlbum.Location = new System.Drawing.Point(3, 3);
            this.reportViewerAlbum.Name = "reportViewerAlbum";
            this.reportViewerAlbum.ServerReport.BearerToken = null;
            this.reportViewerAlbum.Size = new System.Drawing.Size(918, 367);
            this.reportViewerAlbum.TabIndex = 0;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStatistics";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabArtists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsArtists)).EndInit();
            this.tabGenres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsGenres)).EndInit();
            this.tabPlaylists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsPlaylists)).EndInit();
            this.tabAlbums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsAlbums)).EndInit();
            this.tpArtists.ResumeLayout(false);
            this.tpGenres.ResumeLayout(false);
            this.tpPlaylists.ResumeLayout(false);
            this.tpAlbums.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabArtists;
        private System.Windows.Forms.TabPage tabGenres;
        private System.Windows.Forms.TabPage tabPlaylists;
        private System.Windows.Forms.DataGridView dgvStatsArtists;
        private System.Windows.Forms.DataGridView dgvStatsGenres;
        private System.Windows.Forms.DataGridView dgvStatsPlaylists;
        private System.Windows.Forms.TabPage tpArtists;
        private System.Windows.Forms.TabPage tpGenres;
        private System.Windows.Forms.TabPage tpPlaylists;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerArtist;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGenre;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPlaylist;
        private System.Windows.Forms.TabPage tabAlbums;
        private System.Windows.Forms.DataGridView dgvStatsAlbums;
        private System.Windows.Forms.TabPage tpAlbums;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAlbum;
    }
}