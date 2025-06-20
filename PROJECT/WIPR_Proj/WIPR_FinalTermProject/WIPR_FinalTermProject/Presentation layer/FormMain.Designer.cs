namespace WIPR_FinalTermProject.Forms_layer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAddToPlaylist = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblNowPlaying = new System.Windows.Forms.Label();
            this.lblSongInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSongs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArtists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlbums = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlaylists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStats = new System.Windows.Forms.ToolStripMenuItem();
            this.emailSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playlistDetailsTableAdapter1 = new WIPR_FinalTermProject.RDLC_layer.DataSet1TableAdapters.PlaylistDetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.player);
            this.panel1.Location = new System.Drawing.Point(358, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 572);
            this.panel1.TabIndex = 23;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(693, 572);
            this.player.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lstSongs);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.btnAddToPlaylist);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.lblNowPlaying);
            this.panel2.Controls.Add(this.lblSongInfo);
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 559);
            this.panel2.TabIndex = 24;
            // 
            // lstSongs
            // 
            this.lstSongs.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.ItemHeight = 27;
            this.lstSongs.Location = new System.Drawing.Point(19, 95);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(275, 166);
            this.lstSongs.TabIndex = 34;
            this.lstSongs.SelectedIndexChanged += new System.EventHandler(this.lstSongs_SelectedIndexChanged);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Orange;
            this.btnStop.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStop.Location = new System.Drawing.Point(184, 336);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 39);
            this.btnStop.TabIndex = 32;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Orange;
            this.btnPlay.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPlay.Location = new System.Drawing.Point(19, 336);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 39);
            this.btnPlay.TabIndex = 31;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAddToPlaylist
            // 
            this.btnAddToPlaylist.BackColor = System.Drawing.Color.Orange;
            this.btnAddToPlaylist.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToPlaylist.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddToPlaylist.Location = new System.Drawing.Point(50, 290);
            this.btnAddToPlaylist.Name = "btnAddToPlaylist";
            this.btnAddToPlaylist.Size = new System.Drawing.Size(220, 39);
            this.btnAddToPlaylist.TabIndex = 33;
            this.btnAddToPlaylist.Text = "Add to Playlist";
            this.btnAddToPlaylist.UseVisualStyleBackColor = false;
            this.btnAddToPlaylist.Click += new System.EventHandler(this.btnAddToPlaylist_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(89, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 27);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(14, 60);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(77, 27);
            this.lblSearch.TabIndex = 35;
            this.lblSearch.Text = "Search:";
            // 
            // lblNowPlaying
            // 
            this.lblNowPlaying.AutoSize = true;
            this.lblNowPlaying.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowPlaying.ForeColor = System.Drawing.Color.Black;
            this.lblNowPlaying.Location = new System.Drawing.Point(14, 16);
            this.lblNowPlaying.Name = "lblNowPlaying";
            this.lblNowPlaying.Size = new System.Drawing.Size(131, 28);
            this.lblNowPlaying.TabIndex = 30;
            this.lblNowPlaying.Text = "Now Playing";
            // 
            // lblSongInfo
            // 
            this.lblSongInfo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblSongInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSongInfo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongInfo.ForeColor = System.Drawing.Color.Black;
            this.lblSongInfo.Location = new System.Drawing.Point(19, 392);
            this.lblSongInfo.Name = "lblSongInfo";
            this.lblSongInfo.Padding = new System.Windows.Forms.Padding(5);
            this.lblSongInfo.Size = new System.Drawing.Size(275, 152);
            this.lblSongInfo.TabIndex = 37;
            this.lblSongInfo.Text = "Song Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1021, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 46);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bui Tran Tan Phat - 23110052\r\nNguyen Nhat Phat - 23110053\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(362, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "TEAM 03";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(581, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 42);
            this.label1.TabIndex = 25;
            this.label1.Text = "MUSIC LIBRARY";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.BackColor = System.Drawing.Color.Honeydew;
            this.lblUserInfo.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.lblUserInfo.Location = new System.Drawing.Point(12, 40);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(140, 27);
            this.lblUserInfo.TabIndex = 5;
            this.lblUserInfo.Text = "Welcome, User";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 70);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 26);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.Color.Teal;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFile.ForeColor = System.Drawing.Color.Gold;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(66, 28);
            this.menuFile.Text = "File";
            // 
            // menuExit
            // 
            this.menuExit.BackColor = System.Drawing.Color.MintCream;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(138, 28);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuManage
            // 
            this.menuManage.BackColor = System.Drawing.Color.Teal;
            this.menuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSongs,
            this.menuArtists,
            this.menuGenre,
            this.menuAlbums,
            this.menuPlaylists,
            this.menuFavorites,
            this.menuStats,
            this.emailSettingsToolStripMenuItem});
            this.menuManage.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuManage.ForeColor = System.Drawing.Color.Gold;
            this.menuManage.Name = "menuManage";
            this.menuManage.Size = new System.Drawing.Size(101, 28);
            this.menuManage.Text = "Manage";
            this.menuManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuSongs
            // 
            this.menuSongs.Name = "menuSongs";
            this.menuSongs.Size = new System.Drawing.Size(249, 28);
            this.menuSongs.Text = "Songs";
            this.menuSongs.Click += new System.EventHandler(this.menuSongs_Click);
            // 
            // menuArtists
            // 
            this.menuArtists.Name = "menuArtists";
            this.menuArtists.Size = new System.Drawing.Size(249, 28);
            this.menuArtists.Text = "Artists";
            this.menuArtists.Click += new System.EventHandler(this.menuArtists_Click);
            // 
            // menuGenre
            // 
            this.menuGenre.Name = "menuGenre";
            this.menuGenre.Size = new System.Drawing.Size(249, 28);
            this.menuGenre.Text = "Genres";
            this.menuGenre.Click += new System.EventHandler(this.menuGenre_Click);
            // 
            // menuAlbums
            // 
            this.menuAlbums.Name = "menuAlbums";
            this.menuAlbums.Size = new System.Drawing.Size(249, 28);
            this.menuAlbums.Text = "Albums";
            this.menuAlbums.Click += new System.EventHandler(this.menuAlbums_Click);
            // 
            // menuPlaylists
            // 
            this.menuPlaylists.Name = "menuPlaylists";
            this.menuPlaylists.Size = new System.Drawing.Size(249, 28);
            this.menuPlaylists.Text = "Playlists";
            this.menuPlaylists.Click += new System.EventHandler(this.menuPlaylists_Click);
            // 
            // menuFavorites
            // 
            this.menuFavorites.Name = "menuFavorites";
            this.menuFavorites.Size = new System.Drawing.Size(249, 28);
            this.menuFavorites.Text = "Favorites";
            this.menuFavorites.Click += new System.EventHandler(this.menuFavorites_Click);
            // 
            // menuStats
            // 
            this.menuStats.Name = "menuStats";
            this.menuStats.Size = new System.Drawing.Size(249, 28);
            this.menuStats.Text = "STATISTICS";
            this.menuStats.Click += new System.EventHandler(this.menuStats_Click);
            // 
            // emailSettingsToolStripMenuItem
            // 
            this.emailSettingsToolStripMenuItem.Name = "emailSettingsToolStripMenuItem";
            this.emailSettingsToolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.emailSettingsToolStripMenuItem.Text = "EMAIL SETTINGS";
            this.emailSettingsToolStripMenuItem.Click += new System.EventHandler(this.emailSettingsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuManage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 32);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playlistDetailsTableAdapter1
            // 
            this.playlistDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1063, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblNowPlaying;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Button btnAddToPlaylist;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSongInfo;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuManage;
        private System.Windows.Forms.ToolStripMenuItem menuSongs;
        private System.Windows.Forms.ToolStripMenuItem menuArtists;
        private System.Windows.Forms.ToolStripMenuItem menuGenre;
        private System.Windows.Forms.ToolStripMenuItem menuAlbums;
        private System.Windows.Forms.ToolStripMenuItem menuPlaylists;
        private System.Windows.Forms.ToolStripMenuItem menuFavorites;
        private System.Windows.Forms.ToolStripMenuItem menuStats;
        private System.Windows.Forms.ToolStripMenuItem emailSettingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private RDLC_layer.DataSet1TableAdapters.PlaylistDetailsTableAdapter playlistDetailsTableAdapter1;
    }
}