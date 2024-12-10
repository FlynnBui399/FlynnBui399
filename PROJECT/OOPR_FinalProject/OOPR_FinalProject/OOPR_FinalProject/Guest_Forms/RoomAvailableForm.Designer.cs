namespace OOPR_FinalProject.Guest_Forms
{
    partial class RoomAvailableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomAvailableForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            background_panel = new System.Windows.Forms.Panel();
            main_panel = new System.Windows.Forms.Panel();
            logo_icon = new System.Windows.Forms.PictureBox();
            avairoom_label = new System.Windows.Forms.Label();
            rooms_table = new System.Windows.Forms.DataGridView();
            logout_panel = new System.Windows.Forms.Panel();
            logout_icon = new System.Windows.Forms.PictureBox();
            login_label = new System.Windows.Forms.Label();
            intro_lb = new System.Windows.Forms.Label();
            background_panel.SuspendLayout();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rooms_table).BeginInit();
            logout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).BeginInit();
            SuspendLayout();
            // 
            // background_panel
            // 
            background_panel.BackColor = System.Drawing.Color.Snow;
            background_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            background_panel.Controls.Add(main_panel);
            background_panel.Location = new System.Drawing.Point(14, 11);
            background_panel.Name = "background_panel";
            background_panel.Size = new System.Drawing.Size(1038, 576);
            background_panel.TabIndex = 1;
            // 
            // main_panel
            // 
            main_panel.BackColor = System.Drawing.Color.Ivory;
            main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            main_panel.Controls.Add(intro_lb);
            main_panel.Controls.Add(logo_icon);
            main_panel.Controls.Add(avairoom_label);
            main_panel.Controls.Add(rooms_table);
            main_panel.Controls.Add(logout_panel);
            main_panel.Location = new System.Drawing.Point(-2, -2);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1038, 578);
            main_panel.TabIndex = 0;
            // 
            // logo_icon
            // 
            logo_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            logo_icon.Image = (System.Drawing.Image)resources.GetObject("logo_icon.Image");
            logo_icon.Location = new System.Drawing.Point(31, 3);
            logo_icon.Name = "logo_icon";
            logo_icon.Size = new System.Drawing.Size(67, 62);
            logo_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logo_icon.TabIndex = 23;
            logo_icon.TabStop = false;
            // 
            // avairoom_label
            // 
            avairoom_label.AutoSize = true;
            avairoom_label.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold);
            avairoom_label.Location = new System.Drawing.Point(14, 84);
            avairoom_label.Name = "avairoom_label";
            avairoom_label.Size = new System.Drawing.Size(243, 31);
            avairoom_label.TabIndex = 26;
            avairoom_label.Text = "Available Room Here:";
            // 
            // rooms_table
            // 
            rooms_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            rooms_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            rooms_table.BackgroundColor = System.Drawing.Color.Ivory;
            rooms_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            rooms_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            rooms_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            rooms_table.DefaultCellStyle = dataGridViewCellStyle2;
            rooms_table.GridColor = System.Drawing.Color.Snow;
            rooms_table.Location = new System.Drawing.Point(3, 118);
            rooms_table.Name = "rooms_table";
            rooms_table.RowHeadersWidth = 51;
            rooms_table.Size = new System.Drawing.Size(1030, 303);
            rooms_table.TabIndex = 25;
            // 
            // logout_panel
            // 
            logout_panel.BackColor = System.Drawing.Color.DarkCyan;
            logout_panel.Controls.Add(logout_icon);
            logout_panel.Controls.Add(login_label);
            logout_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            logout_panel.Location = new System.Drawing.Point(435, 464);
            logout_panel.Name = "logout_panel";
            logout_panel.Size = new System.Drawing.Size(157, 54);
            logout_panel.TabIndex = 1;
            logout_panel.Click += logout_panel_Click;
            // 
            // logout_icon
            // 
            logout_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            logout_icon.Image = (System.Drawing.Image)resources.GetObject("logout_icon.Image");
            logout_icon.Location = new System.Drawing.Point(3, 3);
            logout_icon.Name = "logout_icon";
            logout_icon.Size = new System.Drawing.Size(56, 51);
            logout_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            logout_icon.TabIndex = 1;
            logout_icon.TabStop = false;
            logout_icon.Click += logout_panel_Click;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Cursor = System.Windows.Forms.Cursors.Hand;
            login_label.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            login_label.ForeColor = System.Drawing.Color.Snow;
            login_label.Location = new System.Drawing.Point(65, 13);
            login_label.Name = "login_label";
            login_label.Size = new System.Drawing.Size(73, 28);
            login_label.TabIndex = 0;
            login_label.Text = "Log In";
            login_label.Click += logout_panel_Click;
            // 
            // intro_lb
            // 
            intro_lb.AutoSize = true;
            intro_lb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            intro_lb.Location = new System.Drawing.Point(413, 437);
            intro_lb.Name = "intro_lb";
            intro_lb.Size = new System.Drawing.Size(202, 24);
            intro_lb.TabIndex = 27;
            intro_lb.Text = "Log in for more details";
            // 
            // RoomAvailableForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cyan;
            ClientSize = new System.Drawing.Size(1067, 599);
            ControlBox = false;
            Controls.Add(background_panel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "RoomAvailableForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RoomAvailableForm";
            background_panel.ResumeLayout(false);
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)rooms_table).EndInit();
            logout_panel.ResumeLayout(false);
            logout_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel background_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox logo_icon;
        private System.Windows.Forms.Label avairoom_label;
        private System.Windows.Forms.DataGridView rooms_table;
        private System.Windows.Forms.Panel logout_panel;
        private System.Windows.Forms.PictureBox logout_icon;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label intro_lb;
    }
}