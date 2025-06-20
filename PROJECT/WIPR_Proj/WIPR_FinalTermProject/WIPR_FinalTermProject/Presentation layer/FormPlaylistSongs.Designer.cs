namespace WIPR_FinalTermProject.Forms_layer
{
    partial class FormPlaylistSongs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlaylistSongs));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNowPlaying = new System.Windows.Forms.Label();
            this.btnPlayAll = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblSongInfo = new System.Windows.Forms.Label();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblPermission = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstInPlaylist = new System.Windows.Forms.ListBox();
            this.lstAvailable = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Orange;
            this.btnClose.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(295, 486);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 39);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Orange;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(95, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 39);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(364, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "PLAYLIST MANAGEMENT";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.lblNowPlaying);
            this.panel1.Controls.Add(this.btnPlayAll);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.lblSongInfo);
            this.panel1.Controls.Add(this.btnMoveDown);
            this.panel1.Controls.Add(this.btnMoveUp);
            this.panel1.Controls.Add(this.lblCreator);
            this.panel1.Controls.Add(this.lblPermission);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.lstInPlaylist);
            this.panel1.Controls.Add(this.lstAvailable);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(16, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 549);
            this.panel1.TabIndex = 5;
            // 
            // lblNowPlaying
            // 
            this.lblNowPlaying.AutoSize = true;
            this.lblNowPlaying.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowPlaying.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNowPlaying.Location = new System.Drawing.Point(249, 455);
            this.lblNowPlaying.Name = "lblNowPlaying";
            this.lblNowPlaying.Size = new System.Drawing.Size(0, 20);
            this.lblNowPlaying.TabIndex = 36;
            // 
            // btnPlayAll
            // 
            this.btnPlayAll.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlayAll.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAll.ForeColor = System.Drawing.Color.Black;
            this.btnPlayAll.Location = new System.Drawing.Point(572, 410);
            this.btnPlayAll.Name = "btnPlayAll";
            this.btnPlayAll.Size = new System.Drawing.Size(109, 39);
            this.btnPlayAll.TabIndex = 35;
            this.btnPlayAll.Text = "Play All";
            this.btnPlayAll.UseVisualStyleBackColor = false;
            this.btnPlayAll.Click += new System.EventHandler(this.btnPlayAll_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Tomato;
            this.btnStop.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(556, 455);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 30);
            this.btnStop.TabIndex = 34;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlay.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(456, 410);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 39);
            this.btnPlay.TabIndex = 33;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblSongInfo
            // 
            this.lblSongInfo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblSongInfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongInfo.Location = new System.Drawing.Point(8, 410);
            this.lblSongInfo.Name = "lblSongInfo";
            this.lblSongInfo.Size = new System.Drawing.Size(241, 125);
            this.lblSongInfo.TabIndex = 32;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDown.Location = new System.Drawing.Point(687, 185);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(32, 40);
            this.btnMoveDown.TabIndex = 31;
            this.btnMoveDown.Text = "↓";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveUp.Location = new System.Drawing.Point(687, 139);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(32, 40);
            this.btnMoveUp.TabIndex = 30;
            this.btnMoveUp.Text = "↑";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.Location = new System.Drawing.Point(3, -1);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(87, 18);
            this.lblCreator.TabIndex = 5;
            this.lblCreator.Text = "Created by: ";
            this.lblCreator.Visible = false;
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.BackColor = System.Drawing.Color.LightCyan;
            this.lblPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermission.ForeColor = System.Drawing.Color.Red;
            this.lblPermission.Location = new System.Drawing.Point(3, 18);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(267, 18);
            this.lblPermission.TabIndex = 6;
            this.lblPermission.Text = "You can view but not modify this playlist";
            this.lblPermission.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(462, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Songs in Playlist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(74, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Available Songs";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Orange;
            this.btnRemove.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(494, 364);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 39);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstInPlaylist
            // 
            this.lstInPlaylist.FormattingEnabled = true;
            this.lstInPlaylist.ItemHeight = 16;
            this.lstInPlaylist.Location = new System.Drawing.Point(440, 122);
            this.lstInPlaylist.Name = "lstInPlaylist";
            this.lstInPlaylist.Size = new System.Drawing.Size(241, 228);
            this.lstInPlaylist.TabIndex = 26;
            this.lstInPlaylist.SelectedIndexChanged += new System.EventHandler(this.lstInPlaylist_SelectedIndexChanged);
            // 
            // lstAvailable
            // 
            this.lstAvailable.FormattingEnabled = true;
            this.lstAvailable.ItemHeight = 16;
            this.lstAvailable.Location = new System.Drawing.Point(41, 122);
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.Size = new System.Drawing.Size(241, 228);
            this.lstAvailable.TabIndex = 25;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(74, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 23);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Playlist\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Playlist Songs";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(16, 606);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(228, 46);
            this.player.TabIndex = 8;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // FormPlaylistSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(765, 654);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlaylistSongs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPlaylistSongs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstInPlaylist;
        private System.Windows.Forms.ListBox lstAvailable;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblPermission;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Label lblSongInfo;
        private System.Windows.Forms.Button btnPlayAll;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblNowPlaying;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}